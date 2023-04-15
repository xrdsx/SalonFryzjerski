using SalonFryzjerski.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonFryzjerski
{
    public class Raport
    {
        public Fryzjer Fryzjer { get; set; }
        public DateTime DataOd { get; set; }
        public DateTime DataDo { get; set; }
        public decimal PodstawowaWyplata { get; set; }
        public decimal SumaZlecen { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Wyplata { get; set; }


        public void Create()
        {
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO Wypłaty (idFryzjera, OkresOd, OkresDo, PodstawowaWypłata, SumaZlecen, Bonus, Wyplata) " +
                           "VALUES (@idFryzjera, @OkresOd, @OkresDo, @PodstawowaWypłata, @SumaZlecen, @Bonus, @Wyplata)";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idFryzjera", Fryzjer.idFryzjera);
                command.Parameters.AddWithValue("@OkresOd", DataOd);
                command.Parameters.AddWithValue("@OkresDo", DataDo);
                command.Parameters.AddWithValue("@PodstawowaWypłata", PodstawowaWyplata);
                command.Parameters.AddWithValue("@SumaZlecen", SumaZlecen);
                command.Parameters.AddWithValue("@Bonus", Bonus ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Wyplata", Wyplata ?? (object)DBNull.Value);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }

    }




   
}
