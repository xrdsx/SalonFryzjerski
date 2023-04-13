


using System.Data.SqlClient;
using System.Security.Principal;

namespace SalonFryzjerski.models
{
    public class Connection
    {
        public SqlConnection connection;

        public Connection()
        {
            connection = new SqlConnection();
            connection.ConnectionString = GetConnectionString();
        }
        public void Connect()
        {
            connection = new SqlConnection(GetConnectionString());
            connection.Open();
        }
        private string GetConnectionString()
        {
            string MachineName = Environment.MachineName + "\\SQLEXPRESS";
            return "Server=" + MachineName + ";Database=salo_fryzjerski;Trusted_Connection=true";

        }

        public string GetFullName(string username, string password)
        {
            string fullName = "";

            SqlCommand cmd = new SqlCommand("SELECT Fryzjer.Imie, Fryzjer.Nazwisko FROM Fryzjer JOIN Login ON Fryzjer.idFryzjera = Login.fryzjer_id WHERE Login.username=@username AND password_hash=@password", connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string firstName = reader.GetString(0);
                string lastName = reader.GetString(1);
                fullName = firstName + " " + lastName;
            }

            reader.Close();

            return fullName;
        }

        public int GetFryzjerId(string username)
        {
            int fryzjerId = -1;

            SqlCommand cmd = new SqlCommand("SELECT fryzjer_id FROM Login WHERE username=@username", connection);
            cmd.Parameters.AddWithValue("@username", username);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                fryzjerId = reader.GetInt32(0);
            }

            reader.Close();

            return fryzjerId;
        }

        public string GetFullNameById(int idFryzjer)
        {
            string query = "SELECT Imie, Nazwisko FROM Fryzjer WHERE idFryzjera=@idFryzjer";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@idFryzjer", idFryzjer);

            SqlDataReader reader = cmd.ExecuteReader();

            string fullName = "";

            if (reader.HasRows)
            {
                reader.Read();
                fullName = reader["Imie"].ToString() + " " + reader["Nazwisko"].ToString();
            }

            reader.Close();

            return fullName;
        }







    }
}
