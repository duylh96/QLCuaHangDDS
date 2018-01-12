using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;

namespace QLCuaHangDDS.BUS
{
    public class BanHangBUS
    {
        public static bool exportPDF(DataTable dataTable)
        {
            System.IO.FileStream fs = new FileStream("C/Bill.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fnthead = new iTextSharp.text.Font(bfntHead, 16, 1, BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("Hóa đơn bán hàng".ToUpper(), fnthead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 8, 2, BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_CENTER;
            prgAuthor.Add(new Chunk("Author : Hoàng Duy", fntAuthor));
            prgAuthor.Add(new Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fnthead));

            //Write Table
            PdfPTable table = new PdfPTable(dataTable.Columns.Count);
            //Table Header
            BaseFont bfnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(bfnColumnHeader, 10, 1, BaseColor.WHITE);
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.GRAY;
                //cell.AddElement(new Chunk())
            }
            return true;
        }
    }
}
