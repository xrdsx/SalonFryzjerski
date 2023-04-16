


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



        public int GetFryzjerId(string username, string password)
        {
            Connect();
            int fryzjerId = -1;

            SqlCommand cmd = new SqlCommand("SELECT fryzjer_id FROM Login WHERE username=@username AND password_hash=@password", connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                fryzjerId = reader.GetInt32(0);
            }

            reader.Close();
            connection.Close();
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

        public bool CheckLogin(string login, string pass)
        {
            Connect();
            bool result = false;

            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE username=@username AND password_hash=@password", connection);
            cmd.Parameters.AddWithValue("@username", login);
            cmd.Parameters.AddWithValue("@password", pass);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                result = true;
            }

            reader.Close();
            connection.Close();
            return result;
        }
        





    }
}
