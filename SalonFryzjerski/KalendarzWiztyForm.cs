using SalonFryzjerski;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonFryzjerski.models
{
    public partial class KalendarzWiztyForm : Form
    {
        public int LoggedUserId { get; set; }
        
        public KalendarzWiztyForm(int loggedUserId)
        {
            InitializeComponent();
            LoggedUserId = loggedUserId;
        }

        private void KalendarzWiztyForm_Load(object sender, EventArgs e)
        {
            ZleceniaViewModel zleceniaViewModel = new ZleceniaViewModel();
            Fryzjer fryzjer = new Fryzjer();
            DataView dataView = fryzjer.GetAllFryzjerzy();
            dataView.Table.Columns.Add("FullName", typeof(string), "Imie + ' ' + Nazwisko");
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            string startDateTime = startDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string endDateTime = endDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            dataGridView1.DataSource = zleceniaViewModel.GetData(LoggedUserId, startDateTime, endDateTime);
            comboBox1.DataSource = dataView;
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "idFryzjera";
            if (LoggedUserId != 1)
            {
                comboBox1.Visible = false;
                buttonWyszukuj.Visible = false;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zlecenia zlecenia = new Zlecenia();
            ZleceniaViewModel zleceniaViewModel = new ZleceniaViewModel();
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            string startDateTime = startDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string endDateTime = endDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            zlecenia.idZlecenia = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            zlecenia.Delete();
            dataGridView1.DataSource = zleceniaViewModel.GetData(LoggedUserId, startDateTime, endDateTime);
        }

        private void buttonCofnij_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel(LoggedUserId);
            mainPanel.LoggedFryzjerId = LoggedUserId;
            mainPanel.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ZleceniaViewModel zleceniaViewModel = new ZleceniaViewModel();
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            string startDateTime = startDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string endDateTime = endDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            dataGridView1.DataSource = zleceniaViewModel.GetData(LoggedUserId, startDateTime, endDateTime);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ZleceniaViewModel zleceniaViewModel = new ZleceniaViewModel();
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            string startDateTime = startDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string endDateTime = endDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            dataGridView1.DataSource = zleceniaViewModel.GetData(LoggedUserId, startDateTime, endDateTime);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void buttonWyszukuj_Click(object sender, EventArgs e)
        {
            ZleceniaViewModel zleceniaViewModel = new ZleceniaViewModel();
            DataRowView data = (DataRowView)comboBox1.SelectedItem;
            int wyborFryzjera = (int)data["idFryzjera"];
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            string startDateTime = startDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string endDateTime = endDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            
            dataGridView1.DataSource = zleceniaViewModel.GetSuperData(wyborFryzjera, startDateTime, endDateTime);

        }
    }
}


