using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SalonFryzjerski.models
{
    public class Klient
    {
        public int idKlienta { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime Ostatnia_wizyta { get; set; }
        public DateTime Nastepna_wizyta { get; set; }

        public Klient()
        {
            idKlienta = -1;
        }

        public void Create()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO Klient (Imie, Nazwisko, Ostatnia_wizyta, Nastepna_wizyta) " +
                           "VALUES (@Imie, @Nazwisko, @Ostatnia_wizyta, @Nastepna_wizyta)";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Imie", Imie);
                command.Parameters.AddWithValue("@Nazwisko", Nazwisko);
                command.Parameters.AddWithValue("@Ostatnia_wizyta", Ostatnia_wizyta);
                command.Parameters.AddWithValue("@Nastepna_wizyta", Nastepna_wizyta);

                command.ExecuteNonQuery();

                query = "SELECT @@IDENTITY";
                command.CommandText = query;
                idKlienta = Convert.ToInt32(command.ExecuteScalar());
            }

            con.connection.Close();
        }

        public static Klient Read(int idKlienta)
        {
            Connection con = new Connection();
            con.Connect();

            Klient klient = null;

            string query = "SELECT * FROM Klient WHERE idKlienta=@idKlienta";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idKlienta", idKlienta);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        klient = new Klient();
                        klient.idKlienta = idKlienta;
                        klient.Imie = Convert.ToString(reader["Imie"]);
                        klient.Nazwisko = Convert.ToString(reader["Nazwisko"]);
                        klient.Ostatnia_wizyta = Convert.ToDateTime(reader["Ostatnia_wizyta"]);
                        klient.Nastepna_wizyta = Convert.ToDateTime(reader["Nastepna_wizyta"]);
                    }
                }
            }

            con.connection.Close();

            return klient;
        }

        public void Update()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "UPDATE Klient " +
                           "SET Imie=@Imie, Nazwisko=@Nazwisko, Ostatnia_wizyta=@Ostatnia_wizyta, Nastepna_wizyta=@Nastepna_wizyta " +
                           "WHERE idKlienta=@idKlienta";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Imie", Imie);
                command.Parameters.AddWithValue("@Nazwisko", Nazwisko);
                command.Parameters.AddWithValue("@Ostatnia_wizyta", Ostatnia_wizyta);
                command.Parameters.AddWithValue("@Nastepna_wizyta", Nastepna_wizyta);
                command.Parameters.AddWithValue("@idKlienta", idKlienta);
                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }

        public static void Delete(int idKlienta)
        {
            Connection con = new Connection();
            con.Connect();

            string query = "DELETE FROM Klient WHERE idKlienta=@idKlienta";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idKlienta", idKlienta);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }
    }
}