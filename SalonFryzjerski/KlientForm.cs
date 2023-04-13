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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SalonFryzjerski
{
    public partial class KlientForm : Form
    {
        

        public KlientForm()
        {
            InitializeComponent();
            
            
            



        }

        private void KlientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient();
            klient.Imie = imieTextBox.Text;
            klient.Nazwisko = nazwiskoTextBox.Text;
            klient.NumerTelefonu = Convert.ToInt32(numerTelefonuNumericUpDown.Value);
            klient.OpisWlosow = opisTextBox.Text;
            klient.Create();

            this.Close(); // zamknij bieżące okno

            MainPanel mainPanel = new MainPanel();
            mainPanel.Show(); // otwórz okno MainPanel



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // zamknij bieżące okno

            MainPanel mainPanel = new MainPanel();
            mainPanel.Show(); // otwórz okno MainPanel

        }
    }
}
