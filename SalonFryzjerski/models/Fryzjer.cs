using System;
using System.Collections.Generic;
using System.Data;
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
        public decimal? Stawka { get; set; }
        public int? IloscGodzin { get; set; }

        public Fryzjer()
        {
            Imie = "";
            Nazwisko = "";
        }
        
        private Fryzjer(int idFryzjera, string imie, string nazwisko, decimal stawka, int iloscGodzin)
        {
            this.idFryzjera = idFryzjera;
            Imie = imie;
            Nazwisko = nazwisko;
            Stawka = stawka;
            IloscGodzin = iloscGodzin;
        }
       

        public void Create()
        {
            Fryzjer fryzjer = this;
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO Fryzjer (Imie, Nazwisko, Stawka, IloscGodzin) " +
                           "VALUES (@Imie, @Nazwisko, @Stawka, @IloscGodzin)";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Imie", fryzjer.Imie);
                command.Parameters.AddWithValue("@Nazwisko", fryzjer.Nazwisko);
                command.Parameters.AddWithValue("@Stawka", fryzjer.Stawka);
                command.Parameters.AddWithValue("@IloscGodzin", fryzjer.IloscGodzin);

                command.ExecuteNonQuery();

                query = "SELECT @@IDENTITY";
                command.CommandText = query;
                idFryzjera = Convert.ToInt32(command.ExecuteScalar());
            }

            con.connection.Close();
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
        public void Delete()
        {
            Fryzjer fryzjer = this;
            Connection con = new Connection();
            con.Connect();

            string query = "DELETE FROM Fryzjer WHERE idFryzjera=@idFryzjera";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idFryzjera", fryzjer.idFryzjera);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }
        public DataTable LoadTable() 
        {
            
            Connection con = new Connection();
            con.Connect();

            string query = "SELECT * FROM Fryzjer";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            
            con.connection.Close();

            return table;
        }
    }
}
