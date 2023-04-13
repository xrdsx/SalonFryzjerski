using SalonFryzjerski.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonFryzjerski
{
    public partial class ZleceniaForm : Form
    {
        public int LoggedUserId { get; set; }
        public ZleceniaForm(int loggedUserId)
        {
            InitializeComponent();
            LoggedUserId = loggedUserId;
        }


        private void ZleceniaForm_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.Connect();

            DataTable klienci = Fryzjer.GetKlienciForLoggedFryzjer(LoggedUserId, con.connection);

            foreach (DataRow row in klienci.Rows)
            {
                klientFkCcomboBox.Items.Add(row["Imie"].ToString() + " " + row["Nazwisko"].ToString());
            }
            string fullName = con.GetFullNameById(LoggedUserId);
            textBox1.Text = fullName;
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void klientFkCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fryzjerFkComboBoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
