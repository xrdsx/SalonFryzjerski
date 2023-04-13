using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonFryzjerski.models
{
    public class Uslugi
    {
        public int idUslugi { get; set; }
        public string nazwaUslugi { get; set; }
        public decimal cena { get; set; }
        

        public Uslugi()
        {
            
        }
        public Uslugi(int idUslugi, string nazwaUslugi, decimal cena)
        {
            this.idUslugi = idUslugi;
            this.nazwaUslugi = nazwaUslugi;
            this.cena = cena;
        }
        public DataView GetUslugi()
        {
            Connection con = new Connection();
            con.Connect();
            string query = "SELECT * FROM UslugiSlownik";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con.connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.connection.Close();
            return dt.DefaultView;
        }
        
        public void AddUsluga(Uslugi usluga)
        {
            
            Connection connection = new Connection();
            connection.connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection.connection;
                command.CommandText = "INSERT INTO UslugiSlownik (NazwaUslugi, cena) VALUES (@NazwaUslugi, @cena)";
                command.Parameters.AddWithValue("@NazwaUslugi", usluga.nazwaUslugi);
                command.Parameters.AddWithValue("@cena", usluga.cena);
                command.ExecuteNonQuery();
            }
            connection.connection.Close();
        }
        public void DeleteUsluga(int idUslugi)
        {
            Connection connection = new Connection();
            connection.connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection.connection;
                command.CommandText = "DELETE FROM UslugiSlownik WHERE idUslugi=@idUslugi";
                command.Parameters.AddWithValue("@idUslugi", idUslugi);
                command.ExecuteNonQuery();
            }
            connection.connection.Close();
        }
        public void UpdateCena(int idUslugi)
        {
            Connection connection = new Connection();
            connection.connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection.connection;
                command.CommandText = "UPDATE UslugiSlownik SET cena=@cena WHERE idUslugi=@idUslugi";
                command.Parameters.AddWithValue("@idUslugi", idUslugi);
                command.Parameters.AddWithValue("@cena", cena);
                command.ExecuteNonQuery();
            }
            connection.connection.Close();
        }
    }
}
