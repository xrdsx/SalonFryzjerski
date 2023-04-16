using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalonFryzjerski.models
{
    public class ZleceniaViewModel:Zlecenia
    {



        public DataTable GetData(int id, string startDate, string endDate)
        {
            Connection con = new Connection();
            con.Connect();
            DateTime startDateTime = DateTime.ParseExact(startDate, "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            DateTime endDateTime = DateTime.ParseExact(endDate, "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            string query = String.Format("SELECT z.idZlecenia, z.Data, z.czasTrwania, u.cena, u.NazwaUslugi, k.Imie, k.Nazwisko, f.Imie, f.Nazwisko FROM Zlecenia z JOIN UslugiSlownik u ON z.UslugaFK = u.idUslugi JOIN Klient k ON z.KlientFK = k.idKlienta JOIN Fryzjer f ON z.FryzjerFK = f.idFryzjera JOIN Login l ON z.FryzjerFK = l.fryzjer_id WHERE z.FryzjerFK = l.fryzjer_id AND l.fryzjer_id = {0} AND z.Data BETWEEN '{1}' AND '{2}'", id, startDate, endDate);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con.connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.Columns[6].ColumnName = "Imię klienta";
            dt.Columns[7].ColumnName = "Nazwisko klienta";

            con.connection.Close();
            return dt;
        }
        public DataTable GetSuperData(int id, string startDate, string endDate)
        {
            Connection con = new Connection();
            con.Connect();
            DateTime startDateTime = DateTime.ParseExact(startDate, "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            DateTime endDateTime = DateTime.ParseExact(endDate, "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            string query = String.Format("SELECT z.idZlecenia, z.Data, z.czasTrwania, u.cena, u.NazwaUslugi, k.Imie, k.Nazwisko, f.Imie, f.Nazwisko FROM Zlecenia z JOIN UslugiSlownik u ON z.UslugaFK = u.idUslugi JOIN Klient k ON z.KlientFK = k.idKlienta JOIN Fryzjer f ON z.FryzjerFK = f.idFryzjera WHERE z.FryzjerFK = {0} AND z.Data BETWEEN '{1}' AND '{2}'", id, startDate, endDate);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con.connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.Columns[6].ColumnName = "Imię klienta";
            dt.Columns[7].ColumnName = "Nazwisko klienta";

            con.connection.Close();
            return dt;
        }







    }
}
