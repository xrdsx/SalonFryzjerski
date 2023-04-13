﻿using System;
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
        public int? PodstawowaWyplata { get; set; }

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

        public string GetFullNameById(int idFryzjer)
        {
            Connection connection = new Connection();
            connection.Connect();
            string query = "SELECT Imie, Nazwisko FROM Fryzjer WHERE idFryzjera=@idFryzjer";
            SqlCommand cmd = new SqlCommand(query, connection.connection);
            cmd.Parameters.AddWithValue("@idFryzjer", idFryzjer);

            SqlDataReader reader = cmd.ExecuteReader();

            string fullName = "";

            if (reader.HasRows)
            {
                reader.Read();
                fullName = reader["Imie"].ToString() + " " + reader["Nazwisko"].ToString();
            }

            reader.Close();
            connection.connection.Close();
            
            return fullName;
        }

        public void Update()
        {
            Fryzjer fryzjer = this;
            Connection con = new Connection();
            con.Connect();

            string query = "UPDATE Fryzjer " +
                           "SET Imie=@Imie, Nazwisko=@Nazwisko, Stawka=@Stawka, IloscGodzin=@IloscGodzin " +
                           "WHERE idFryzjera=@idFryzjera";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@Imie", fryzjer.Imie);
                command.Parameters.AddWithValue("@Nazwisko", fryzjer.Nazwisko);
                command.Parameters.AddWithValue("@Stawka", fryzjer.Stawka);
                command.Parameters.AddWithValue("@IloscGodzin", fryzjer.IloscGodzin);
                command.Parameters.AddWithValue("@idFryzjera", fryzjer.idFryzjera);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }
        public void Delete()
        {
            Fryzjer fryzjer = this;
            Connection con = new Connection();
            con.Connect();

            string query = "DELETE FROM Login WHERE fryzjer_id=@idFryzjera;" +
                           "DELETE FROM Fryzjer WHERE idFryzjera=@idFryzjera;";

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

        public DataTable GetWizytyForLoggedFryzjer(int loggedFryzjerId)
        {
            Connection connection1 = new Connection();
            connection1.Connect();
            string query = "SELECT * FROM Zlecenia WHERE FryzjerFK=@idFryzjer";
            SqlCommand cmd = new SqlCommand(query, connection1.connection);
            cmd.Parameters.AddWithValue("@idFryzjer", loggedFryzjerId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection1.connection.Close();
            return table;
        }


        

    }
}
