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
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace SalonFryzjerski
{
    public partial class GeneratorRaportowForm : Form
    {
        public int LoggedUserId { get; set; }
        public GeneratorRaportowForm(int id)
        {
            InitializeComponent();
            LoggedUserId = id;
        }

        private void GeneratorRaportowForm_Load(object sender, EventArgs e)
        {
            Fryzjer fryzjer = new Fryzjer();
            DataTable table = fryzjer.LoadTable();

            List<Fryzjer> fryzjerowie = new List<Fryzjer>();
            foreach (DataRow row in table.Rows)
            {
                Fryzjer f = new Fryzjer();
                f.idFryzjera = Convert.ToInt32(row["idFryzjera"]);
                f.Imie = row["Imie"].ToString();
                f.Nazwisko = row["Nazwisko"].ToString();
                fryzjerowie.Add(f);
            }

            comboBox1.DataSource = fryzjerowie;
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "idFryzjera";

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label14.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pobierz wybranego fryzjera z ComboBoxa
            Fryzjer fryzjer = comboBox1.SelectedItem as Fryzjer;

            // Pobierz daty z DateTimePickerów
            DateTime dataOd = dateTimePicker1.Value.Date;
            DateTime dataDo = dateTimePicker2.Value.Date;

            // Pobierz podstawową wypłatę dla wybranego fryzjera
            decimal podstawowaWyplata = fryzjer.GetPodstawowaWyplata(fryzjer.idFryzjera);

            // Pobierz liczbę zleceń wykonanych w wybranym okresie
            decimal liczbaZlecen = fryzjer.GetLiczbaZlecenWykonanych(fryzjer.idFryzjera, dataOd, dataDo);

            // Oblicz bonus dla wybranego okresu i liczby zleceń
            decimal bonus = fryzjer.ObliczBonus(liczbaZlecen);

            decimal wypłata = podstawowaWyplata + bonus;

            if (Raport.CzyRaportJuzWygenerowany(fryzjer.idFryzjera, dataOd, dataDo))
            {
                MessageBox.Show("Raport dla tego fryzjera i okresu już został wygenerowany.");
                return;
            }
            // Wygeneruj raport w formacie Word
            using (var folderBrowser = new FolderBrowserDialog())
            {
                string fileName = "";
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowser.SelectedPath;
                    fileName = selectedFolder + @"\Rachunek_" + fryzjer.FullName.Replace(" ", "") + "_" + dataOd.ToString("MMyyyy") + ".docx";

                    Raport raportGenerator = new Raport();
                    raportGenerator.GenerujRaportWord(fryzjer, dataOd, dataDo, podstawowaWyplata, liczbaZlecen, bonus, wypłata, fileName);
                    raportGenerator.Create(fryzjer, dataOd, dataDo, podstawowaWyplata, liczbaZlecen, bonus, wypłata);
                }

            }

            label7.Text = fryzjer.FullName;
            label8.Text = dataOd.ToShortDateString();
            label9.Text = dataDo.ToShortDateString();
            label10.Text = podstawowaWyplata.ToString();
            label11.Text = liczbaZlecen.ToString();
            label12.Text = bonus.ToString("c");
            label14.Text = wypłata.ToString() + " zł";

            // Wyświetlenie etykiet z danymi raportu
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label14.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel(LoggedUserId);
            mainPanel.LoggedFryzjerId = LoggedUserId;
            mainPanel.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dataOd = dateTimePicker1.Value.Date;
            DateTime dataDo = dateTimePicker2.Value.Date;

            Raport.GenerujRaportyWszystkichIZapiszDoFolderu(dataOd, dataDo);
        }
    }
}
