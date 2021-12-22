using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallera
{
    public class GeneradorPdf
    {
        public List<Pelea> Peleas { get; set; }
        public string Path { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public GeneradorPdf(List<Pelea> peleas, string path, string nombre, DateTime fecha)
        {
            Peleas = peleas;
            Path = path;
            Nombre = nombre;
            Fecha = fecha;
        }

        public void Crear()
        {
            Document documento = new Document(PageSize.A4);

            PdfWriter writer;
       
            try
            {
                writer = PdfWriter.GetInstance(documento, new FileStream(Path + "/" + Nombre + ".pdf", FileMode.CreateNew));
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ya existe un archivo con el mismo nombre, intente de nuevo", "Continuar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            documento.AddTitle(Nombre);
            documento.AddCreator("Felix Ochoa");

            documento.Open();

            Font fuente = new Font(Font.FontFamily.HELVETICA);

            documento.Add(new Paragraph("Coliseo gallistico Miguel Yaneth"));
            documento.Add(Chunk.NEWLINE);
            documento.Add(new Paragraph("Torneo del " + Fecha.ToShortDateString()));
            documento.Add(Chunk.NEWLINE);

            PdfPTable tblPrueba = new PdfPTable(6);
            tblPrueba.WidthPercentage = 100;
            PdfPCell Numero = new PdfPCell(new Phrase("NO.", fuente));
            Numero.BorderWidth = 0.75f;
            PdfPCell Galleria = new PdfPCell(new Phrase("Gallería", fuente));
            Galleria.BorderWidth = 0.75f;
            PdfPCell PlacaGalleria = new PdfPCell(new Phrase("Placa gallería", fuente));
            PlacaGalleria.BorderWidth = 0.75f;
            PdfPCell Peso = new PdfPCell(new Phrase("Peso", fuente));
            Peso.BorderWidth = 0.75f;
            PdfPCell Color = new PdfPCell(new Phrase("Color", fuente));
            Color.BorderWidth = 0.75f;
            PdfPCell Resultado = new PdfPCell(new Phrase("    Resultado", fuente));
            Resultado.BorderWidth = 0.75f;


            tblPrueba.AddCell(Numero);
            tblPrueba.AddCell(Galleria);
            tblPrueba.AddCell(PlacaGalleria);
            tblPrueba.AddCell(Peso);
            tblPrueba.AddCell(Color);
            tblPrueba.AddCell(Resultado);

            foreach (var animal in Peleas)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        Galleria = new PdfPCell(new Phrase(animal.Gallo1.nombreDueno, fuente));
                        Galleria.BorderWidth = 0.75f;
                        PlacaGalleria = new PdfPCell(new Phrase(animal.Gallo1.Id.ToString(), fuente));
                        PlacaGalleria.BorderWidth = 0.75f;
                        Peso = new PdfPCell(new Phrase(animal.Gallo1.Peso.ToString(), fuente));
                        Peso.BorderWidth = 0.75f;
                        Color = new PdfPCell(new Phrase(animal.Gallo1.Color.ToString(), fuente));
                        Color.BorderWidth = 0.75f;
                        Numero = new PdfPCell(new Phrase((Peleas.IndexOf(animal) + 1).ToString(), fuente));
                        Numero.BorderWidth = 0.75f;
                        Numero.BorderWidthBottom = 0;
                        Resultado = new PdfPCell(new Phrase(string.Empty, fuente));
                        Resultado.BorderWidth = 0.75f;
                        Resultado.BorderWidthBottom = 0;
                    }
                    else
                    {
                        Galleria = new PdfPCell(new Phrase(animal.Gallo2.nombreDueno, fuente));
                        Galleria.BorderWidth = 0.75f;
                        PlacaGalleria = new PdfPCell(new Phrase(animal.Gallo2.Id.ToString(), fuente));
                        PlacaGalleria.BorderWidth = 0.75f;
                        Peso = new PdfPCell(new Phrase(animal.Gallo2.Peso.ToString(), fuente));
                        Peso.BorderWidth = 0.75f;
                        Color = new PdfPCell(new Phrase(animal.Gallo2.Color.ToString(), fuente));
                        Color.BorderWidth = 0.75f;
                        Numero = new PdfPCell(new Phrase(string.Empty, fuente));
                        Numero.BorderWidth = 0.75f;
                        Numero.BorderWidthTop = 0;
                        Resultado = new PdfPCell(new Phrase(string.Empty, fuente));
                        Resultado.BorderWidth = 0.75f;
                        Resultado.BorderWidthTop = 0;
                    }

                    tblPrueba.AddCell(Numero);
                    tblPrueba.AddCell(Galleria);
                    tblPrueba.AddCell(PlacaGalleria);
                    tblPrueba.AddCell(Peso);
                    tblPrueba.AddCell(Color);
                    tblPrueba.AddCell(Resultado);
                }
                
            }

            documento.Add(tblPrueba);

            documento.Close();
            writer.Close();
            documento.Dispose();
            writer.Dispose();
        }
    }
}
