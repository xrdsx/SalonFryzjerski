using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonFryzjerski.models
{
    public class Fryzjer
    {
        public int idFryzjera { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public decimal Stawka { get; set; }
        public int IloscGodzin { get; set; }

        public Fryzjer()
        {
            idFryzjera = -1;
        }

        public void Create()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO Fryzjer (Imie, Nazwisko, Stawka, IloscGodzin) " +
                           "VALUES (@Imie, @Nazwisko, @Stawka, @IloscGodzin)";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Imie", Imie);
                command.Parameters.AddWithValue("@Nazwisko", Nazwisko);
                command.Parameters.AddWithValue("@Stawka", Stawka);
                command.Parameters.AddWithValue("@IloscGodzin", IloscGodzin);

                command.ExecuteNonQuery();

                query = "SELECT @@IDENTITY";
                command.CommandText = query;
                idFryzjera = Convert.ToInt32(command.ExecuteScalar());
            }

            con.connection.Close();
        }

        public static Fryzjer Read(int idFryzjera)
        {
            Connection con = new Connection();
            con.Connect();

            Fryzjer fryzjer = null;

            string query = "SELECT * FROM Fryzjer WHERE idFryzjera=@idFryzjera";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idFryzjera", idFryzjera);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fryzjer = new Fryzjer();
                        fryzjer.idFryzjera = idFryzjera;
                        fryzjer.Imie = Convert.ToString(reader["Imie"]);
                        fryzjer.Nazwisko = Convert.ToString(reader["Nazwisko"]);
                        fryzjer.Stawka = Convert.ToDecimal(reader["Stawka"]);
                        fryzjer.IloscGodzin = Convert.ToInt32(reader["IloscGodzin"]);
                    }
                }
            }

            con.connection.Close();

            return fryzjer;
        }

        public void Update()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "UPDATE Fryzjer " +
                           "SET Imie=@Imie, Nazwisko=@Nazwisko, Stawka=@Stawka, IloscGodzin=@IloscGodzin " +
                           "WHERE idFryzjera=@idFryzjera";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Imie", Imie);
                command.Parameters.AddWithValue("@Nazwisko", Nazwisko);
                command.Parameters.AddWithValue("@Stawka", Stawka);
                command.Parameters.AddWithValue("@IloscGodzin", IloscGodzin);
                command.Parameters.AddWithValue("@idFryzjera", idFryzjera);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }
        public static void Delete(int idFryzjera)
        {
            Connection con = new Connection();
            con.Connect();

            string query = "DELETE FROM Fryzjer WHERE idFryzjera=@idFryzjera";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idFryzjera", idFryzjera);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }
    }
}
