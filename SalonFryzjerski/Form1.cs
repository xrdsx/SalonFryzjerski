using SalonFryzjerski.models;
using System.Data.SqlClient;

namespace SalonFryzjerski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //log.Visible = false;
            
            //if(con.connection.State == System.Data.ConnectionState.Open)
            //{
            //    log.Visible = true;
            //}
        }

        private void log_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void log_Click_1(object sender, EventArgs e)
        {
            string username = loginTextBox.Text;
            string password = passTextBox.Text;
            Connection con = new Connection();
            
            if (con.CheckLogin(username, password))
            {
                MessageBox.Show("Zalogowano");
                MainPanel mainPanel = new MainPanel();
                mainPanel.LoggedFryzjerId = con.GetFryzjerId(username, password);
                mainPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane logowania");
            }
                

            
            
            

            
            
        }
    }
}