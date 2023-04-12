using SalonFryzjerski.models;

namespace SalonFryzjerski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
            Connection con = new Connection();
            con.Connect();
            if(con.connection.State == System.Data.ConnectionState.Open)
            {
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FryzjerForm fryzjerForm = new FryzjerForm();
            fryzjerForm.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}