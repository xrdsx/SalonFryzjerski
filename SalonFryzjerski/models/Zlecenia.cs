using System;
using System.Collections.Generic;
using System.Data;
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
        public int CzasTrwania { get; set; }

        public Zlecenia()
        {
            Data = DateTime.Now;
        }

        public void Create()
        {
            Zlecenia zlecenie = this;
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO Zlecenia (Data, KlientFK, FryzjerFK, UslugaFK, CzasTrwania) " +
                           "VALUES (@Data, @KlientFK, @FryzjerFK, @UslugaFK, @CzasTrwania)";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Data", zlecenie.Data);
                command.Parameters.AddWithValue("@KlientFK", zlecenie.KlientFK);
                command.Parameters.AddWithValue("@FryzjerFK", zlecenie.FryzjerFK);
                command.Parameters.AddWithValue("@UslugaFK", zlecenie.UslugaFK);
                command.Parameters.AddWithValue("@CzasTrwania", zlecenie.CzasTrwania);

                command.ExecuteNonQuery();

                query = "SELECT @@IDENTITY";
                command.CommandText = query;
                idZlecenia = Convert.ToInt32(command.ExecuteScalar());
            }

            con.connection.Close();
        }

        public void Update()
        {
            Zlecenia zlecenie = this;
            Connection con = new Connection();
            con.Connect();

            string query = "UPDATE Zlecenia " +
                           "SET Data=@Data, KlientFK=@KlientFK, FryzjerFK=@FryzjerFK, UslugaFK=@UslugaFK, CzasTrwania=@CzasTrwania " +
                           "WHERE idZlecenia=@idZlecenia";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Data", zlecenie.Data);
                command.Parameters.AddWithValue("@KlientFK", zlecenie.KlientFK);
                command.Parameters.AddWithValue("@FryzjerFK", zlecenie.FryzjerFK);
                command.Parameters.AddWithValue("@UslugaFK", zlecenie.UslugaFK);
                command.Parameters.AddWithValue("@CzasTrwania", zlecenie.CzasTrwania);
                command.Parameters.AddWithValue("@idZlecenia", zlecenie.idZlecenia);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }

        public void Delete()
        {
            Zlecenia zlecenie = this;
            Connection con = new Connection();
            con.Connect();

            string query = "DELETE FROM Zlecenia WHERE idZlecenia=@idZlecenia";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idZlecenia", zlecenie.idZlecenia);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }

        public DataTable LoadTable()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "SELECT * FROM Zlecenia";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            con.connection.Close();

            return table;
        }
        

        public DataTable GetZleceniaForLoggedFryzjer(int loggedFryzjerId, SqlConnection connection)
        {
            string query = "SELECT * FROM Zlecenie WHERE IdFryzjer=@idFryzjer";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@idFryzjer", loggedFryzjerId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }

}
