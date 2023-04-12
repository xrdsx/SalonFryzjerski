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
        private BindingList<Fryzjer> fryzjerList;
        public FryzjerForm()
        {
            InitializeComponent();

            LoadFryzjerList();
        }
        private void FryzjerForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadFryzjerList()
        {
            fryzjerList = new BindingList<Fryzjer>();
            Connection connection = new Connection();
            using (connection.connection)
            {
                connection.Connect();
                   
                

                string query = "SELECT * FROM Fryzjer";

                using (SqlCommand command = new SqlCommand(query, connection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fryzjer fryzjer = new Fryzjer();
                            fryzjer.idFryzjera = Convert.ToInt32(reader["idFryzjera"]);
                            fryzjer.Imie = Convert.ToString(reader["Imie"]);
                            fryzjer.Nazwisko = Convert.ToString(reader["Nazwisko"]);
                            fryzjer.Stawka = Convert.ToDecimal(reader["Stawka"]);
                            fryzjer.IloscGodzin = Convert.ToInt32(reader["IloscGodzin"]);
                            fryzjerList.Add(fryzjer);
                        }
                    }
                }

                connection.connection.Close();
            }

            fryzjerDataGridView.DataSource = fryzjerList;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Fryzjer fryzjer = new Fryzjer();
            fryzjer.Imie = imieTextBox.Text;
            fryzjer.Nazwisko = nazwiskoTextBox.Text;
            fryzjer.Stawka = Convert.ToDecimal(stawkaNumericUpDown.Value);
            fryzjer.IloscGodzin = Convert.ToInt32(iloscGodzinNumericUpDown.Value);
            fryzjer.Create();
            fryzjerList.Add(fryzjer);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Fryzjer fryzjer = fryzjerDataGridView.SelectedRows[0].DataBoundItem as Fryzjer;
            fryzjer.Imie = imieTextBox.Text;
            fryzjer.Nazwisko = nazwiskoTextBox.Text;
            fryzjer.Stawka = Convert.ToDecimal(stawkaNumericUpDown.Value);
            fryzjer.IloscGodzin = Convert.ToInt32(iloscGodzinNumericUpDown.Value);
            fryzjer.Update();
            fryzjerDataGridView.Refresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Fryzjer fryzjer = fryzjerDataGridView.SelectedRows[0].DataBoundItem as Fryzjer;
            fryzjerList.Remove(fryzjer);
            Fryzjer.Delete(fryzjer.idFryzjera);
        }

        private void fryzjerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (fryzjerDataGridView.SelectedRows.Count > 0)
            {
                Fryzjer fryzjer = fryzjerDataGridView.SelectedRows[0].DataBoundItem as Fryzjer;
                imieTextBox.Text = fryzjer.Imie;
                nazwiskoTextBox.Text = fryzjer.Nazwisko;
                stawkaNumericUpDown.Value = fryzjer.Stawka;
                iloscGodzinNumericUpDown.Value = fryzjer.IloscGodzin;
            }
        }
    }
}

