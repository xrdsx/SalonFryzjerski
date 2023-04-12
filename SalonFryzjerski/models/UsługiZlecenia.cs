using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SalonFryzjerski.models
{
    public class UslugiZlecenia
    {
        public int idUslugiZlecenia { get; set; }
        public int UslugaFK { get; set; }
        public int ZlecenieFK { get; set; }
        public int PracownikFK { get; set; }
        public int KlientFK { get; set; }
        public decimal Naleznosc { get; set; }

        public UslugiZlecenia()
        {
            idUslugiZlecenia = -1;
        }

        public void Create()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO UslugiZlecenia (UslugaFK, ZlecenieFK, PracownikFK, KlientFK, Naleznosc) " +
                           "VALUES (@UslugaFK, @ZlecenieFK, @PracownikFK, @KlientFK, @Naleznosc)";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@UslugaFK", UslugaFK);
                command.Parameters.AddWithValue("@ZlecenieFK", ZlecenieFK);
                command.Parameters.AddWithValue("@PracownikFK", PracownikFK);
                command.Parameters.AddWithValue("@KlientFK", KlientFK);
                command.Parameters.AddWithValue("@Naleznosc", Naleznosc);

                command.ExecuteNonQuery();

                query = "SELECT @@IDENTITY";
                command.CommandText = query;
                idUslugiZlecenia = Convert.ToInt32(command.ExecuteScalar());
            }

            con.connection.Close();
        }

        public static UslugiZlecenia Read(int idUslugiZlecenia)
        {
            Connection con = new Connection();
            con.Connect();

            UslugiZlecenia uslugiZlecenia = null;

            string query = "SELECT * FROM UslugiZlecenia WHERE idUslugiZlecenia=@idUslugiZlecenia";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idUslugiZlecenia", idUslugiZlecenia);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uslugiZlecenia = new UslugiZlecenia();
                        uslugiZlecenia.idUslugiZlecenia = idUslugiZlecenia;
                        uslugiZlecenia.UslugaFK = Convert.ToInt32(reader["UslugaFK"]);
                        uslugiZlecenia.ZlecenieFK = Convert.ToInt32(reader["ZlecenieFK"]);
                        uslugiZlecenia.PracownikFK = Convert.ToInt32(reader["PracownikFK"]);
                        uslugiZlecenia.KlientFK = Convert.ToInt32(reader["KlientFK"]);
                        uslugiZlecenia.Naleznosc = Convert.ToDecimal(reader["Naleznosc"]);
                    }
                }
            }

            con.connection.Close();

            return uslugiZlecenia;
        }
        public void Update()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "UPDATE UslugiZlecenia " +
                           "SET UslugaFK=@UslugaFK, ZlecenieFK=@ZlecenieFK, PracownikFK=@PracownikFK, KlientFK=@KlientFK, Naleznosc=@Naleznosc " +
                           "WHERE idUslugiZlecenia=@idUslugiZlecenia";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idUslugiZlecenia", idUslugiZlecenia);
                command.Parameters.AddWithValue("@UslugaFK", UslugaFK);
                command.Parameters.AddWithValue("@ZlecenieFK", ZlecenieFK);
                command.Parameters.AddWithValue("@PracownikFK", PracownikFK);
                command.Parameters.AddWithValue("@KlientFK", KlientFK);
                command.Parameters.AddWithValue("@Naleznosc", Naleznosc);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }

        public static void Delete(int idUslugiZlecenia)
        {
            Connection con = new Connection();
            con.Connect();

            string query = "DELETE FROM UslugiZlecenia WHERE idUslugiZlecenia=@idUslugiZlecenia";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idUslugiZlecenia", idUslugiZlecenia);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }
    }
}