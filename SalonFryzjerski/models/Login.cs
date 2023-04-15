using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonFryzjerski.models
{
    public class Login
    {
        public int FryzjerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Login(int fryzjerId, string username, string password)
        {
            FryzjerId = fryzjerId;
            Username = username;
            Password = password;
            
        }

        public void Create()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO Login (username, password_hash, fryzjer_id) " +
                           "VALUES (@username, @password_hash, @fryzjer_id)";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                // PasswordHelper to klasa pomocnicza do hashowania hasła
                command.Parameters.AddWithValue("@username", Username);
                command.Parameters.AddWithValue("@password_hash", Password);
                command.Parameters.AddWithValue("@fryzjer_id", FryzjerId);
                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }
    }
}
