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
        public string FullName
        {
            get { return Imie + " " + Nazwisko; }
        }


        public string Create()
        {
            Fryzjer fryzjer = this;
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO Fryzjer (Imie, Nazwisko, Stawka, IloscGodzin) " +
                           "VALUES (@Imie, @Nazwisko, @Stawka, @IloscGodzin);";

            string randomLoginString = "";
            string randomPasswordString = "";
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
            string query1 = "INSERT INTO Login (username, password_hash, fryzjer_id,role) " +
                            "VALUES (@login,@password,@fryzjer_id,@role)";
            using (SqlCommand command = new SqlCommand(query1, con.connection))
            {
                randomLoginString = Guid.NewGuid().ToString();
                randomPasswordString = Guid.NewGuid().ToString();
                command.Parameters.AddWithValue("@login", fryzjer.Imie.First() + fryzjer.Nazwisko + randomLoginString.Substring(0, 4));
                command.Parameters.AddWithValue("@password", randomPasswordString.Substring(0, 8));
                command.Parameters.AddWithValue("@fryzjer_id", idFryzjera);
                command.Parameters.AddWithValue("@role", "andrzej");     //Zmienic tego stringa, najlepiej int albo bool 0 fryzjer 1 superfryzjer
                command.ExecuteNonQuery();

            }
            
            con.connection.Close();
            return "Login:"+""+ fryzjer.Imie.First() + fryzjer.Nazwisko + randomLoginString.Substring(0, 4) + " " +"Haslo:"+ "" + randomPasswordString.Substring(0, 8);

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
            string query = "DELETE FROM Zlecenia WHERE FryzjerFk= @idFryzjera;";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idFryzjera", fryzjer.idFryzjera);

                command.ExecuteNonQuery();
            }
            string query1 = "DELETE FROM Login WHERE fryzjer_id = @idFryzjera;";

            using (SqlCommand command = new SqlCommand(query1, con.connection))
            {
                command.Parameters.AddWithValue("@idFryzjera", fryzjer.idFryzjera);

                command.ExecuteNonQuery();
            }
            
            string query2 = "DELETE FROM Fryzjer WHERE idFryzjera=@idFryzjera;";

            using (SqlCommand command = new SqlCommand(query2, con.connection))
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

       
        public decimal GetPodstawowaWyplata(int idFryzjera)
        {
            decimal podstawowaWyplata = 0;
            Connection connection = new Connection();
            connection.Connect();
            string query = "SELECT PodstawowaWyplata FROM Fryzjer WHERE idFryzjera=@idFryzjera";
            SqlCommand cmd = new SqlCommand(query, connection.connection);
            cmd.Parameters.AddWithValue("@idFryzjera", idFryzjera);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                podstawowaWyplata = Convert.ToDecimal(reader["PodstawowaWyplata"]);
            }

            reader.Close();
            connection.connection.Close();

            return podstawowaWyplata;
        }

        public int GetLiczbaZlecenWykonanych(int idFryzjera, DateTime dataOd, DateTime dataDo)
        {
            int liczbaZlecen = 0;
            Connection connection = new Connection();
            connection.Connect();
            string query = "SELECT COUNT(*) FROM Zlecenia WHERE FryzjerFK=@idFryzjera AND Data >= @DataOd AND Data <= @DataDo";
            SqlCommand cmd = new SqlCommand(query, connection.connection);
            cmd.Parameters.AddWithValue("@idFryzjera", idFryzjera);
            cmd.Parameters.AddWithValue("@DataOd", dataOd);
            cmd.Parameters.AddWithValue("@DataDo", dataDo);

            liczbaZlecen = (int)cmd.ExecuteScalar();

            connection.connection.Close();

            return liczbaZlecen;
        }

        public decimal ObliczBonus(decimal liczbaZlecen)
        {
            decimal bonus = 0;

            if (liczbaZlecen > 50)
            {
                bonus = 300;
            }
            else if (liczbaZlecen > 40)
            {
                bonus = 150;
            }
            else if (liczbaZlecen > 1)
            {
                bonus = 100;
            }

            return bonus;
        }
        public DataView GetAllFryzjerzy()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "SELECT * FROM Fryzjer";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            con.connection.Close();

            return table.DefaultView;
        }

        



    }
}
