using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using iText;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Colors;
using iText.IO.Image;
using iText.Kernel.Pdf.Action;
using System.Reflection;

namespace SERVICIOS
{
    public class ReportesPDF
    {

        public void CrearReportePDF(List<Object> listaObjetos)
        {
            Type tipo = listaObjetos[0].GetType();
            var columnas = tipo.GetProperties();


            String s = DateTime.Now.ToString();
            s = s.Replace("/", "-").Replace(":", ".");
            s = "Reporte Sadaet" + s;
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)  + "\\";
            String ruta = path + s + ".pdf";
            
            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter(ruta);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Header
            Paragraph header = new Paragraph("Reporte SADAET")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);

            // New line
            Paragraph newline = new Paragraph(new Text("\n"));

            document.Add(newline);
            document.Add(header);

            // Add sub-header
            Paragraph subheader = new Paragraph("Reporte de " + listaObjetos[0].GetType().ToString())
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(15);
            document.Add(subheader);

            // Line separator
            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);

            // Add paragraph1
            Paragraph paragraph1 = new Paragraph("Este es un reporte generado en PDF directamente del sistema SADAET");
            document.Add(paragraph1);

            

            // Table
            Table table = new Table((columnas.Count()), false);

            //Agregamos los encabezados.
            foreach (var item in columnas)
            {
                Cell encabezado = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph(item.Name.ToString()));
                table.AddCell(encabezado);
            }



            //Agregamos los objetos a la tabla 
            foreach (Object elemento in listaObjetos)
            {

                for (int i = 0; i <= columnas.Count()-1; i++)
                {
                    string str = elemento.GetType().GetProperties()[i].GetValue(elemento).ToString();
                    Cell celda = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(str));
                    table.AddCell(celda);
                }
                
            }

            document.Add(table);


            // Hyper link
            Link link = new Link("presione aquí",
               PdfAction.CreateURI("https://sadaet-ayuda.netlify.app"));
            Paragraph hyperLink = new Paragraph("Por favor ")
               .Add(link.SetBold().SetUnderline()
               .SetItalic().SetFontColor(ColorConstants.BLUE))
               .Add(" para ir a la ayuda en linea de SADAET.");

            document.Add(newline);
            document.Add(hyperLink);

            //// Page numbers
            //int n = pdf.GetNumberOfPages();
            //for (int i = 1; i <= n; i++)
            //{
            //    document.ShowTextAligned(new Paragraph(String
            //       .Format("Pagina" + i + " de " + n)),
            //       559, 806, i, TextAlignment.RIGHT,
            //       VerticalAlignment.TOP, 0);
            //}

            // Close document
            document.Close();

            
            Process.Start(ruta);



        }

        



    }
}
