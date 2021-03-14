﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
            System.IO.FileStream fs = new FileStream(lokacija, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(naslov.ToUpper(), fntHead));
            document.Add(prgHeading);

            string slika = @"C:\Users\Nikola\Desktop\tpj-projekat\sistem\slike\admin.png";
            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(slika);
            //Resize image depend upon your need
            png.ScaleToFit(140f, 120f);
            //Give space before image
            png.SpacingBefore = 10f;
            //Give some space after the image
            png.SpacingAfter = 1f;
            png.Alignment = Element.ALIGN_CENTER;

            document.Add(png);
            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, iTextSharp.text.BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk(string.Format("Author : {0}", Sesija.dajSessiju().Daj_admina()), fntAuthor));
            prgAuthor.Add(new Chunk("\nDatum : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(tabela_podataka.Item2.Columns.Count);
            table.WidthPercentage = 100;

            float[] widths = tabela_podataka.Item1.ToArray();
            table.SetWidths(widths);

            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 0, iTextSharp.text.BaseColor.WHITE);
            for (int i = 0; i < tabela_podataka.Item2.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();

                cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                cell.AddElement(new Chunk(tabela_podataka.Item2.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }

            BaseFont font_tabela = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font f = new Font(font_tabela, 9, 1, iTextSharp.text.BaseColor.BLACK);
            //table Data
            for (int i = 0; i < tabela_podataka.Item2.Rows.Count; i++)
            {
                for (int j = 0; j < tabela_podataka.Item2.Columns.Count; j++)
                {

                    PdfPCell cell = new PdfPCell();

                    cell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
                    cell.AddElement(new Chunk(tabela_podataka.Item2.Rows[i][j].ToString(), f));
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
