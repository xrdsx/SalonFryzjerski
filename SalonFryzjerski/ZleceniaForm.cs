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

            Fryzjer fryzjer = new();
            //DataTable klienci = Fryzjer.GetWizytyForLoggedFryzjer(LoggedUserId);
            Klient klient = new();
            Uslugi usluga = new();

            //klientFkCcomboBox.DataSource = klient.GetKlients().Distinct();
            //foreach (DataRow row in klienci.Rows)
            //{
            //    klientFkCcomboBox.Items.Add(row["Imie"].ToString() + " " + row["Nazwisko"].ToString());
            //}
            //string fullName = fryzjer.GetFullNameById(LoggedUserId);
            DataView fryzjerzy = fryzjer.GetAllFryzjerzy();
            fryzjerzy.Table.Columns.Add("FullName", typeof(string), "Imie + ' ' + Nazwisko");
            DataView dataView = klient.LoadTable();
            dataView.Table.Columns.Add("FullName", typeof(string), "Imie + ' ' + Nazwisko");
            DataView data = usluga.GetUslugi();
            data.Table.Columns.Add("FullName", typeof(string), "NazwaUslugi + ' ' + Cena");
            klientFkCcomboBox.DataSource = dataView;
            klientFkCcomboBox.DisplayMember = "FullName";
            klientFkCcomboBox.ValueMember = "idKlienta";
            usługaFkComboBox.DataSource = data;
            usługaFkComboBox.DisplayMember = "FullName";
            usługaFkComboBox.ValueMember = "idUslugi";
            comboBox1.DataSource = fryzjerzy;
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "idFryzjera";
            label7.Visible = false;
            if(LoggedUserId != 1)
            {
                comboBox1.Visible = false;
                label3.Visible = false;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Zlecenia zlecenia = new Zlecenia();
            zlecenia.Data = dataDateTimePicker.Value;
            zlecenia.KlientFK = Convert.ToInt32(klientFkCcomboBox.SelectedValue);
            zlecenia.UslugaFK = Convert.ToInt32(usługaFkComboBox.SelectedValue);
            if (LoggedUserId == 1)
            {
                int wyborFryzjera = Convert.ToInt32(comboBox1.SelectedValue);
                zlecenia.FryzjerFK = wyborFryzjera;
            }
            else
            {
                zlecenia.FryzjerFK = LoggedUserId;
            }
            zlecenia.CzasTrwania = Convert.ToInt32(czasTrwanianumericUpDown.Value);
            zlecenia.KwotaDoZaplaty = Convert.ToDecimal(label7.Text);
            zlecenia.Create();
            MainPanel mainPanel = new MainPanel(LoggedUserId);
            mainPanel.LoggedFryzjerId = LoggedUserId;
            mainPanel.Show();
            this.Hide();

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

        private void klientBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
            MainPanel mainPanel = new MainPanel(LoggedUserId);
            mainPanel.LoggedFryzjerId = LoggedUserId;
            mainPanel.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uslugi usluga = new Uslugi();
            int uslugaId = Convert.ToInt32(((DataRowView)usługaFkComboBox.SelectedItem)["idUslugi"]);
            decimal cenaUslugi = usluga.GetCenaById(uslugaId);
            int czasTrwania = (int)czasTrwanianumericUpDown.Value;
            decimal cena = 0;
            if (czasTrwania <= 30)
            {
                cena = cenaUslugi + 15;
            }
            else if (czasTrwania <= 60)
            {
                cena = cenaUslugi + 25;
            }
            else if (czasTrwania <= 90)
            {
                cena = cenaUslugi + 40;
            }

            label7.Text = cena.ToString();
            label7.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
