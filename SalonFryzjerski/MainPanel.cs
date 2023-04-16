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
    public partial class MainPanel : Form
    {
        public string LoggedUser { get; set; }
        public int LoggedFryzjerId { get; set; }


        public MainPanel(int loggedUserId)
        {
            InitializeComponent();
            LoggedFryzjerId = loggedUserId;
            button5.Visible = false;
            button1.Visible = false;
            button6.Visible = false;
            if(LoggedFryzjerId == 1)
            {
                button5.Visible = true;
                button1.Visible = true;
                button6.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FryzjerForm fryzjerForm = new FryzjerForm(LoggedFryzjerId);
            fryzjerForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            Fryzjer fryzjer = new Fryzjer();
            
            label3.Text = fryzjer.GetFullNameById(LoggedFryzjerId);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            // Wyświetlamy komunikat o wylogowaniu
            MessageBox.Show("Wylogowano.");

            // Tworzymy nowe okno logowania
            Form1 form1 = new Form1();

            // Zamykamy bieżące okno
            this.Close();

            // Otwieramy nowe okno logowania
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KlientForm klientForm = new KlientForm(LoggedFryzjerId);

            klientForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZleceniaForm zleceniaForm = new ZleceniaForm(LoggedFryzjerId);
            zleceniaForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KalendarzWiztyForm kalendarzWiztyForm = new KalendarzWiztyForm(LoggedFryzjerId);
            kalendarzWiztyForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UslugiForm uslugiForm = new UslugiForm(LoggedFryzjerId);
            uslugiForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GeneratorRaportowForm generator = new GeneratorRaportowForm(LoggedFryzjerId);
            generator.Show();
            this.Hide();

        }
    }
}
