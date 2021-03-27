using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Reflection;

namespace sistem.pdf_kreator
{
    public class PdfKreator : IKreator
    {
        private static PdfKreator kreator = null;
        private PdfKreator() { }

        public static PdfKreator Daj_pdf_kreatora()
        {
            if (PdfKreator.kreator == null)
            {
                PdfKreator.kreator = new PdfKreator();
            }
            return PdfKreator.kreator;
        }

        #region kreiraj_pdf_dokument_i_prikaži_ga
        public void Kreiraj(Tuple<List<float>, DataTable> tabela_podataka, string lokacija, string naslov)
        {
            System.IO.FileStream fs = new FileStream(lokacija, FileMode.CreateNew, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

           
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(naslov.ToUpper(), fntHead));
            document.Add(prgHeading);   

            string slika = @"C:\Users\NikolaTošić\Desktop\projekat\sistem\slike\admin.png";
            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(slika);
            
            png.ScaleToFit(140f, 120f);
           
            png.SpacingBefore = 10f;
            
            png.SpacingAfter = 1f;
            png.Alignment = Element.ALIGN_CENTER;

            document.Add(png);
            
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, iTextSharp.text.BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk(string.Format("Autor : {0}", Sesija.dajSessiju().Daj_admina()), fntAuthor));
            prgAuthor.Add(new Chunk("\nDatum : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

           
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

          
            document.Add(new Chunk("\n", fntHead));

          
            PdfPTable table = new PdfPTable(tabela_podataka.Item2.Columns.Count);
            table.WidthPercentage = 100;

            float[] widths = tabela_podataka.Item1.ToArray();
            table.SetWidths(widths);

         
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 0, iTextSharp.text.BaseColor.WHITE);
            for (int i = 0; i < tabela_podataka.Item2.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                Paragraph paragraf = new Paragraph(new Chunk(tabela_podataka.Item2.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                paragraf.Alignment = Element.ALIGN_CENTER;

                cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                cell.AddElement(paragraf);
                table.AddCell(cell);
            }

            BaseFont font_tabela = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font f = new Font(font_tabela, 10, 2, iTextSharp.text.BaseColor.BLACK);
            //podaci u tabeli
            for (int i = 0; i < tabela_podataka.Item2.Rows.Count; i++)
            {
                for (int j = 0; j < tabela_podataka.Item2.Columns.Count; j++)
                {

                    PdfPCell cell = new PdfPCell();
                    Paragraph paragraf = new Paragraph(new Chunk(tabela_podataka.Item2.Rows[i][j].ToString(), f));
                    paragraf.Alignment = Element.ALIGN_LEFT;

                    cell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
                    cell.AddElement(paragraf);
                    table.AddCell(cell);
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();

        }
        #endregion
    }
}
