


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
            return "Server=" + MachineName + ";Database=Salon_fryzjerski;Trusted_Connection=true";

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

        







    }
}
