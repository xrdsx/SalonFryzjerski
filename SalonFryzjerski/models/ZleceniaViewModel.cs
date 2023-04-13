using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalonFryzjerski.models
{
    public class ZleceniaViewModel
    {



        public DataTable GetData(int id)
        {
            Connection con = new Connection();
            con.Connect();
            string query = String.Format("SELECT z.idZlecenia, z.Data, z.czasTrwania, u.cena, u.NazwaUslugi, k.Imie, k.Nazwisko, f.Imie,f.Nazwisko, l.fryzjer_id FROM Zlecenia z JOIN UslugiSlownik u ON z.UslugaFK = u.idUslugi JOIN Klient k ON z.KlientFK = k.idKlienta JOIN Fryzjer f ON z.FryzjerFK = f.idFryzjera JOIN Login l ON z.FryzjerFK = l.fryzjer_id WHERE z.FryzjerFK = l.fryzjer_id AND l.fryzjer_id = {0}", id);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con.connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.connection.Close();
            return dt;
        }




    }
}
