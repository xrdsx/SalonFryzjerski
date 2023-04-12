using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SalonFryzjerski.models
{
    public class Rozliczenia
    {
        public int idRozliczenia { get; set; }
        public int PracownikFK { get; set; }
        public int IloscGodzin { get; set; }
        public decimal Naleznosc { get; set; }

        public Rozliczenia()
        {
            idRozliczenia = -1;
        }

        public void Create()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO Rozliczenia (PracownikFK, IloscGodzin, Naleznosc) " +
                           "VALUES (@PracownikFK, @IloscGodzin, @Naleznosc)";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@PracownikFK", PracownikFK);
                command.Parameters.AddWithValue("@IloscGodzin", IloscGodzin);
                command.Parameters.AddWithValue("@Naleznosc", Naleznosc);

                command.ExecuteNonQuery();

                query = "SELECT @@IDENTITY";
                command.CommandText = query;
                idRozliczenia = Convert.ToInt32(command.ExecuteScalar());
            }

            con.connection.Close();
        }

        public static Rozliczenia Read(int idRozliczenia)
        {
            Connection con = new Connection();
            con.Connect();

            Rozliczenia rozliczenie = null;

            string query = "SELECT * FROM Rozliczenia WHERE idRozliczenia=@idRozliczenia";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idRozliczenia", idRozliczenia);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rozliczenie = new Rozliczenia();
                        rozliczenie.idRozliczenia = idRozliczenia;
                        rozliczenie.PracownikFK = Convert.ToInt32(reader["PracownikFK"]);
                        rozliczenie.IloscGodzin = Convert.ToInt32(reader["IloscGodzin"]);
                        rozliczenie.Naleznosc = Convert.ToDecimal(reader["Naleznosc"]);
                    }
                }
            }

            con.connection.Close();

            return rozliczenie;
        }

        public void Update()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "UPDATE Rozliczenia " +
                           "SET PracownikFK=@PracownikFK, IloscGodzin=@IloscGodzin, Naleznosc=@Naleznosc " +
                           "WHERE idRozliczenia=@idRozliczenia";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@PracownikFK", PracownikFK);
                command.Parameters.AddWithValue("@IloscGodzin", IloscGodzin);
                command.Parameters.AddWithValue("@Naleznosc", Naleznosc);
                command.Parameters.AddWithValue("@idRozliczenia", idRozliczenia);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }

        public static void Delete(int idRozliczenia)
        {
            Connection con = new Connection();
            con.Connect();

            string query = "DELETE FROM Rozliczenia WHERE idRozliczenia=@idRozliczenia";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idRozliczenia", idRozliczenia);
                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }
    }
}