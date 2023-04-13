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
            Fryzjer fryzjer = new Fryzjer();
            dataGridView1.DataSource = fryzjer.GetWizytyForLoggedFryzjer(LoggedUserId);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


