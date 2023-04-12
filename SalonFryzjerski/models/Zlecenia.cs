using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SalonFryzjerski.models
{
    public class Zlecenia
    {
        public int idZlecenia { get; set; }
        public DateTime Data { get; set; }
        public int KlientFK { get; set; }
        public int FryzjerFK { get; set; }
        public int UslugaFK { get; set; }

        public Zlecenia()
        {
            idZlecenia = -1;
        }

        public void Create()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO Zlecenia (Data, KlientFK, FryzjerFK, UslugaFK) " +
                           "VALUES (@Data, @KlientFK, @FryzjerFK, @UslugaFK)";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Data", Data);
                command.Parameters.AddWithValue("@KlientFK", KlientFK);
                command.Parameters.AddWithValue("@FryzjerFK", FryzjerFK);
                command.Parameters.AddWithValue("@UslugaFK", UslugaFK);

                command.ExecuteNonQuery();

                query = "SELECT @@IDENTITY";
                command.CommandText = query;
                idZlecenia = Convert.ToInt32(command.ExecuteScalar());
            }

            con.connection.Close();
        }

        public static Zlecenia Read(int idZlecenia)
        {
            Connection con = new Connection();
            con.Connect();

            Zlecenia zlecenie = null;

            string query = "SELECT * FROM Zlecenia WHERE idZlecenia=@idZlecenia";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idZlecenia", idZlecenia);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        zlecenie = new Zlecenia();
                        zlecenie.idZlecenia = idZlecenia;
                        zlecenie.Data = Convert.ToDateTime(reader["Data"]);
                        zlecenie.KlientFK = Convert.ToInt32(reader["KlientFK"]);
                        zlecenie.FryzjerFK = Convert.ToInt32(reader["FryzjerFK"]);
                        zlecenie.UslugaFK = Convert.ToInt32(reader["UslugaFK"]);
                    }
                }
            }

            con.connection.Close();

            return zlecenie;
        }

        public void Update()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "UPDATE Zlecenia " +
                           "SET Data=@Data, KlientFK=@KlientFK, FryzjerFK=@FryzjerFK, UslugaFK=@UslugaFK " +
                           "WHERE idZlecenia=@idZlecenia";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Data", Data);
                command.Parameters.AddWithValue("@KlientFK", KlientFK);
                command.Parameters.AddWithValue("@FryzjerFK", FryzjerFK);
                command.Parameters.AddWithValue("@UslugaFK", UslugaFK);
                command.Parameters.AddWithValue("@idZlecenia", idZlecenia);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }
        public static void Delete(int idZlecenia)
        {
            Connection con = new Connection();
            con.Connect();

            string query = "DELETE FROM Zlecenia WHERE idZlecenia=@idZlecenia";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idZlecenia", idZlecenia);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }

    }
}
