﻿using SalonFryzjerski.models;
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



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wyborFryzjera = Convert.ToInt32(comboBox1.SelectedValue);
            Zlecenia zlecenia = new Zlecenia();
            zlecenia.Data = dataDateTimePicker.Value;
            zlecenia.KlientFK = klientFkCcomboBox.SelectedIndex + 1;
            zlecenia.UslugaFK = usługaFkComboBox.SelectedIndex + 1;
            Connection connection = new Connection();
            zlecenia.FryzjerFK = wyborFryzjera;
            zlecenia.CzasTrwania = Convert.ToInt32(czasTrwanianumericUpDown.Value);
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
    }
}
