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
        public GeneratorRaportowForm(int loggedUser)
        {
            InitializeComponent();
            LoggedUserId = loggedUser;
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
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            string fileName = "";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderBrowser.SelectedPath;
                fileName = selectedFolder + "\\Raport_" + fryzjer.idFryzjera + "_" + DateTime.Now.ToString("dd-MM-yyyy") + ".docx";
                
            }
            // Tworzenie nowego pliku Word
            using (DocX document = DocX.Create(fileName))
            {
                // Dodawanie zawartości do dokumentu
                Paragraph paragraph1 = document.InsertParagraph();
                paragraph1.AppendLine("Rachunek za okres od " + dataOd.ToShortDateString() + " do " + dataDo.ToShortDateString()).Bold().FontSize(24).Color(Color.Blue).Alignment = Alignment.center;

                Paragraph paragraph2 = document.InsertParagraph();
                paragraph2.AppendLine("Fryzjer: " + fryzjer.FullName).Bold().FontSize(16);

                Paragraph paragraph3 = document.InsertParagraph();
                paragraph3.AppendLine("Okres od: " + dataOd.ToShortDateString() + " do: " + dataDo.ToShortDateString()).Bold().FontSize(16);

                Paragraph paragraph4 = document.InsertParagraph();
                paragraph4.AppendLine("Podstawowa wypłata: " + podstawowaWyplata.ToString("c")).FontSize(14);

                Paragraph paragraph5 = document.InsertParagraph();
                paragraph5.AppendLine("Suma zleceń: " + liczbaZlecen.ToString("c")).FontSize(14);

                Paragraph paragraph6 = document.InsertParagraph();
                paragraph6.AppendLine("Bonus: " + bonus.ToString("c")).FontSize(14);

                // Dodawanie podpisów
                Table table = document.AddTable(1, 2);
                table.AutoFit = AutoFit.Contents;
                table.Design = TableDesign.TableNormal;
                table.Alignment = Alignment.center;
                table.Rows[0].Cells[0].Paragraphs.First().Append("Numer konta bankowego:").Bold().FontSize(14);
                table.Rows[0].Cells[1].Paragraphs.First().Append("").FontSize(14);
                document.InsertTable(table);

                Paragraph paragraph7 = document.InsertParagraph();
                paragraph7.AppendLine("Wypłata: " + wypłata.ToString("c")).Bold().FontSize(18).Color(Color.Green);

                

                // Dodawanie podpisów
                Paragraph pracownik = document.InsertParagraph();
                pracownik.AppendLine("Podpis pracownika: ___________________________ Data: _____________________").FontSize(14).SpacingAfter(30).Alignment = Alignment.left;

                Paragraph szef = document.InsertParagraph();
                szef.AppendLine("Podpis pracodawcy: ________________________________ Data: _____________________").FontSize(14).SpacingAfter(30).Alignment = Alignment.right;

                // Zapisanie dokumentu
                document.Save();
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
    }
}
