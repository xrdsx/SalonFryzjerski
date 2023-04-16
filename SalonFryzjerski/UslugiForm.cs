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
            LoggedUserId = loggedUser;
            groupBox2.Visible = false;
            numericUpDown2.Visible = false;
            button2.Visible = true;
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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uslugi uslugi = new Uslugi();
            uslugi.cena = Convert.ToInt32(numericUpDown2.Value);
            uslugi.idUslugi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            uslugi.UpdateCena();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            numericUpDown2.Visible = true;
            groupBox2.Visible = true;
            button1.Visible = true;
            numericUpDown2.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            label3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
