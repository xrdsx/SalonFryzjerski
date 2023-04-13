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
        public UslugiForm()
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
    }
}
