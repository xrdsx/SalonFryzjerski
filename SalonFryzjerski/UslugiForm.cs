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
    public partial class UslugiForm : Form
    {
        public int LoggedUserId { get; set; }
        public UslugiForm(int loggedUser)
        {
            InitializeComponent();
        }

        private void UslugiForm_Load(object sender, EventArgs e)
        {
            Uslugi uslugi = new Uslugi();
            
            dataGridView1.DataSource = uslugi.GetUslugi();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Uslugi uslugi = new Uslugi();
            uslugi.nazwaUslugi = textBox1.Text;
            uslugi.cena = Convert.ToInt32(numericUpDown1.Value);
            uslugi.AddUsluga(uslugi);
            MainPanel mainPanel = new MainPanel(LoggedUserId);
            mainPanel.LoggedFryzjerId = LoggedUserId;
            mainPanel.Show();
            this.Hide();

        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            

        }

        private void wrocButton_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel(LoggedUserId);
            mainPanel.LoggedFryzjerId = LoggedUserId;
            mainPanel.Show();
            this.Hide();
        }
    }
}
