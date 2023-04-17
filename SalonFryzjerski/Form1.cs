using SalonFryzjerski.models;
using System.Data.SqlClient;

namespace SalonFryzjerski
{
    public partial class Form1 : Form
    {
        public int LoggedUserId { get; set; }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void log_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passTextBox.PasswordChar = '*';
        }

        private void log_Click_1(object sender, EventArgs e)
        {
            string username = loginTextBox.Text;
            string password = passTextBox.Text;
            Connection con = new Connection();
            
            if (con.CheckLogin(username, password))
            {
                LoggedUserId = con.GetFryzjerId(username, password);
                MessageBox.Show("Zalogowano");
                MainPanel mainPanel = new MainPanel(LoggedUserId);
                mainPanel.LoggedFryzjerId = LoggedUserId;
                mainPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane logowania");
            }
                

            
            
            

            
            
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}