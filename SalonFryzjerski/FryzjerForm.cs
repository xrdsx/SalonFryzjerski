using SalonFryzjerski.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonFryzjerski
{
    public partial class FryzjerForm : Form
    {
        public int LoggedUserId { get; set; }

        public FryzjerForm(int loggedUser)
        {
            InitializeComponent();
            updateButton.Visible = false;
            LoggedUserId = loggedUser;
            LoadFryzjer();
        }
        private void FryzjerForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadFryzjer()
        {
            Fryzjer fryzjer = new Fryzjer();
            var dt = fryzjer.LoadTable();
            Uslugi uslugi = new Uslugi();
            uslugi.GetUslugi();
            fryzjerDataGridView.DataSource = dt;
            fryzjerDataGridView.DataMember = dt.TableName;
            fryzjerDataGridView.Columns["idFryzjera"].Visible = true;

        }

        private void addButton_Click(object sender, EventArgs e)
        {


        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {


        }

        private void fryzjerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (fryzjerDataGridView.SelectedRows.Count > 0)
            {
                Fryzjer fryzjer = fryzjerDataGridView.SelectedRows[0].DataBoundItem as Fryzjer;
                imieTextBox.Text = fryzjer.Imie;
                nazwiskoTextBox.Text = fryzjer.Nazwisko;
                stawkaNumericUpDown.Value = (decimal)fryzjer.Stawka;
                iloscGodzinNumericUpDown.Value = (decimal)fryzjer.IloscGodzin;
            }
        }

        private void fryzjerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            Fryzjer fryzjer = new Fryzjer();
            fryzjer.Imie = imieTextBox.Text;
            fryzjer.Nazwisko = nazwiskoTextBox.Text;
            fryzjer.Stawka = Convert.ToDecimal(stawkaNumericUpDown.Value);
            fryzjer.IloscGodzin = Convert.ToInt32(iloscGodzinNumericUpDown.Value);
            MessageBox.Show(fryzjer.Create());
            //fryzjer.Create();

            

            LoadFryzjer();
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {

            Fryzjer fryzjer = new Fryzjer();
            fryzjer.idFryzjera = Convert.ToInt32(fryzjerDataGridView.SelectedRows[0].Cells[0].Value);
            fryzjer.Delete();
            LoadFryzjer();
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            imieTextBox.Text = fryzjerDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            imieTextBox.Text = fryzjerDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            nazwiskoTextBox.Text = fryzjerDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            stawkaNumericUpDown.Value = Convert.ToDecimal(fryzjerDataGridView.SelectedRows[0].Cells[3].Value);
            iloscGodzinNumericUpDown.Value = Convert.ToDecimal(fryzjerDataGridView.SelectedRows[0].Cells[4].Value);
            updateButton.Visible = true;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Fryzjer fryzjer = new Fryzjer();
            fryzjer.idFryzjera = Convert.ToInt32(fryzjerDataGridView.CurrentRow.Cells["idFryzjera"].Value);
            fryzjer.Imie = imieTextBox.Text;
            fryzjer.Nazwisko = nazwiskoTextBox.Text;
            fryzjer.Stawka = Convert.ToDecimal(stawkaNumericUpDown.Value);
            fryzjer.IloscGodzin = Convert.ToInt32(iloscGodzinNumericUpDown.Value);
            fryzjer.Update();
            updateButton.Visible = false;
            LoadFryzjer();
        }

        private void stawkaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel(LoggedUserId);
            mainPanel.LoggedFryzjerId = LoggedUserId;
            mainPanel.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

