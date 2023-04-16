using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace SalonFryzjerski.models
{
    public class Raport
    {
        public Fryzjer Fryzjer { get; set; }
        public DateTime DataOd { get; set; }
        public DateTime DataDo { get; set; }
        public decimal PodstawowaWyplata { get; set; }
        public decimal SumaZlecen { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Wyplata { get; set; }


        public void Create(Fryzjer fryzjer, DateTime dataOd, DateTime dataDo, decimal podstawowaWyplata, decimal liczbaZlecen, decimal bonus, decimal wypłata)
        {
            Connection con = new Connection();
            con.Connect();

            string query = "INSERT INTO Wypłaty (idFryzjera, OkresOd, OkresDo, PodstawowaWypłata, SumaZlecen, Bonus, Wyplata) " +
                           "VALUES (@idFryzjera, @OkresOd, @OkresDo, @PodstawowaWypłata, @SumaZlecen, @Bonus, @Wyplata)";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idFryzjera", fryzjer.idFryzjera);
                command.Parameters.AddWithValue("@OkresOd", dataOd);
                command.Parameters.AddWithValue("@OkresDo", dataDo);
                command.Parameters.AddWithValue("@PodstawowaWypłata", podstawowaWyplata);
                command.Parameters.AddWithValue("@SumaZlecen", liczbaZlecen);
                command.Parameters.AddWithValue("@Bonus", bonus);
                command.Parameters.AddWithValue("@Wyplata", wypłata);

                command.ExecuteNonQuery();
            }

            con.connection.Close();
        }

        public void GenerujRaportWord(Fryzjer fryzjer, DateTime dataOd, DateTime dataDo, decimal podstawowaWyplata, decimal liczbaZlecen, decimal bonus, decimal wypłata, string filePath)
        {
            // Tworzenie nowego pliku Word
            using (DocX document = DocX.Create(filePath))
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
        }

        public static bool CzyRaportJuzWygenerowany(int idFryzjera, DateTime dataOd, DateTime dataDo)
        {
            Connection con = new Connection();
            con.Connect();

            string query = "SELECT COUNT(*) FROM Wypłaty WHERE idFryzjera=@idFryzjera AND OkresOd=@OkresOd AND OkresDo=@OkresDo";

            using (SqlCommand command = new SqlCommand(query, con.connection))
            {
                command.Parameters.AddWithValue("@idFryzjera", idFryzjera);
                command.Parameters.AddWithValue("@OkresOd", dataOd);
                command.Parameters.AddWithValue("@OkresDo", dataDo);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public static void GenerujRaportyWszystkichIZapiszDoFolderu(DateTime dataOd, DateTime dataDo)
        {
            // Utwórz nowy folder Raporty/MMyyyy w wybranej lokalizacji
            string selectedFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string raportyFolder = Path.Combine(selectedFolder, "Raporty", dataOd.ToString("MMyyyy"));
            Directory.CreateDirectory(raportyFolder);

            // Dla każdego pracownika wygeneruj raport i zapisz go w nowym folderze
            foreach (Fryzjer fryzjer in Fryzjer.GetAllFryzjer())
            {
                decimal podstawowaWyplata = fryzjer.GetPodstawowaWyplata(fryzjer.idFryzjera);
                decimal liczbaZlecen = fryzjer.GetLiczbaZlecenWykonanych(fryzjer.idFryzjera, dataOd, dataDo);
                decimal bonus = fryzjer.ObliczBonus(liczbaZlecen);
                decimal wypłata = podstawowaWyplata + bonus;

                if (Raport.CzyRaportJuzWygenerowany(fryzjer.idFryzjera, dataOd, dataDo))
                {
                    continue;
                }

                string fileName = Path.Combine(raportyFolder, $"Rachunek_{fryzjer.FullName.Replace(" ", "")}.docx");

                Raport raportGenerator = new Raport();
                raportGenerator.GenerujRaportWord(fryzjer, dataOd, dataDo, podstawowaWyplata, liczbaZlecen, bonus, wypłata, fileName);

                // Dodaj wypłatę do bazy danych
                raportGenerator.Create(fryzjer, dataOd, dataDo, podstawowaWyplata, liczbaZlecen, bonus, wypłata);
            }

            MessageBox.Show("Raporty zostały wygenerowane i zapisane w folderze " + raportyFolder);
        }




    }





}

