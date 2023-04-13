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
    public partial class MainPanel : Form
    {
        public string LoggedUser { get; set; }
        public int LoggedFryzjerId { get; set; }


        public MainPanel()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FryzjerForm fryzjerForm = new FryzjerForm();
            fryzjerForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            label2.Text = LoggedUser;
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
            UslugiForm uslugiForm = new UslugiForm();
            uslugiForm.Show();
            this.Hide();
        }
    }
}
