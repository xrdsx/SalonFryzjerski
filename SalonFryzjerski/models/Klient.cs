using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SalonFryzjerski.models
{
    public class Klient
    {
        public int idKlienta { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int NumerTelefonu { get; set; }
        public string OpisWlosow { get; set; }
        public List<Klient> ListaKlientow{ get; set; }


        public Klient()
        {
            Imie = "";
            Nazwisko = "";
            
            OpisWlosow = "";
        }

        private Klient(int idKlienta, string imie, string nazwisko, int numerTelefonu, string opisWlosow)
        {
            this.idKlienta = idKlienta;
            Imie = imie;
            Nazwisko = nazwisko;
            NumerTelefonu = numerTelefonu;
            OpisWlosow = opisWlosow;
        }

        public void Create()
        {
            Klient klient = this;
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO Klient (Imie, Nazwisko, NumerTelefonu, OpisWlosow) " +
                           "VALUES (@Imie, @Nazwisko, @NumerTelefonu, @OpisWlosow)";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Imie", klient.Imie);
                command.Parameters.AddWithValue("@Nazwisko", klient.Nazwisko);
                command.Parameters.AddWithValue("@NumerTelefonu", klient.NumerTelefonu);
                command.Parameters.AddWithValue("@OpisWlosow", klient.OpisWlosow);
                

                command.ExecuteNonQuery();

                query = "SELECT @@IDENTITY";
                command.CommandText = query;
                idKlienta = Convert.ToInt32(command.ExecuteScalar());
            }

            con.connection.Close();
        }

        public void Update()
        {
            Klient klient = this;
            Connection con = new Connection();
            con.Connect();

            string query = "UPDATE Klient " +
                           "SET Imie=@Imie, Nazwisko=@Nazwisko, NumerTelefonu=@NumerTelefonu, OpisWlosow=@OpisWlosow " +
                           "WHERE idKlienta=@idKlienta";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Imie", klient.Imie);
                command.Parameters.AddWithValue("@Nazwisko", klient.Nazwisko);
                command.Parameters.AddWithValue("@NumerTelefonu", klient.NumerTelefonu);
                command.Parameters.AddWithValue("@OpisWlosow", klient.OpisWlosow);
                command.Parameters.AddWithValue("@idKlienta", klient.idKlienta);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }

        public void Delete()
        {
            Klient klient = this;
            Connection con = new Connection();
            con.Connect();

            string query = "DELETE FROM Klient WHERE idKlienta=@idKlienta";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idKlienta", klient.idKlienta);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }
        

        public DataView LoadTable()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "SELECT * FROM Klient";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            con.connection.Close();

            return table.DefaultView;
        }
        
    }
}
