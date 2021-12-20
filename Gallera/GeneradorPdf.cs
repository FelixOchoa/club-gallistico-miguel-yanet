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
        public GeneradorPdf(List<Pelea> peleas, string path, string nombre)
        {
            Peleas = peleas;
            Path = path;
            Nombre = nombre;
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

            documento.Add(new Paragraph("DUELOS"));
            documento.Add(Chunk.NEWLINE);

            PdfPTable tblPrueba = new PdfPTable(6);
            tblPrueba.WidthPercentage = 100;
            PdfPCell AnimalA = new PdfPCell(new Phrase("Gallo A", fuente));
            AnimalA.BorderWidth = 0;
            AnimalA.BorderWidthBottom = 0.75f;
            PdfPCell PesoA = new PdfPCell(new Phrase("Peso", fuente));
            PesoA.BorderWidth = 0;
            PesoA.BorderWidthBottom = 0.75f;
            PdfPCell DuenioA = new PdfPCell(new Phrase("Dueño", fuente));
            DuenioA.BorderWidth = 0;
            DuenioA.BorderWidthBottom = 0.75f;
            tblPrueba.WidthPercentage = 100;
            PdfPCell AnimalB = new PdfPCell(new Phrase("Gallo B", fuente));
            AnimalB.BorderWidth = 0;
            AnimalB.BorderWidthBottom = 0.75f;
            PdfPCell PesoB = new PdfPCell(new Phrase("Peso", fuente));
            PesoB.BorderWidth = 0;
            PesoB.BorderWidthBottom = 0.75f;
            PdfPCell DuenioB = new PdfPCell(new Phrase("Dueño", fuente));
            DuenioB.BorderWidth = 0;
            DuenioB.BorderWidthBottom = 0.75f;

            tblPrueba.AddCell(AnimalA);
            tblPrueba.AddCell(PesoA);
            tblPrueba.AddCell(DuenioA);
            tblPrueba.AddCell(AnimalB);
            tblPrueba.AddCell(PesoB);
            tblPrueba.AddCell(DuenioB);

            foreach (var animal in Peleas)
            {
                AnimalA = new PdfPCell(new Phrase(animal.Gallo1.Id, fuente));
                AnimalA.BorderWidth = 0;
                PesoA = new PdfPCell(new Phrase(animal.Gallo1.Peso.ToString(), fuente));
                PesoA.BorderWidth = 0;
                DuenioA = new PdfPCell(new Phrase(animal.Gallo1.nombreDueno.ToString(), fuente));
                DuenioA.BorderWidth = 0;
                AnimalB = new PdfPCell(new Phrase(animal.Gallo2.Id, fuente));
                AnimalB.BorderWidth = 0;
                PesoB = new PdfPCell(new Phrase(animal.Gallo2.Peso.ToString(), fuente));
                PesoB.BorderWidth = 0;
                DuenioB = new PdfPCell(new Phrase(animal.Gallo2.nombreDueno, fuente));
                DuenioB.BorderWidth = 0;

                tblPrueba.AddCell(AnimalA);
                tblPrueba.AddCell(PesoA);
                tblPrueba.AddCell(DuenioA);
                tblPrueba.AddCell(AnimalB);
                tblPrueba.AddCell(PesoB);
                tblPrueba.AddCell(DuenioB);

            }

            documento.Add(tblPrueba);

            documento.Close();
            writer.Close();
            documento.Dispose();
            writer.Dispose();
        }
    }
}
