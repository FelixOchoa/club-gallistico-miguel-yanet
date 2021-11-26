using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallera
{
    public partial class ListarGallos : Form
    {
        public List<Gallo> Gallos { get; set; }
        public List<Pelea> Peleas { get; set; }
        public ListarGallos(List<Gallo> gallos, List<Pelea> peleas)
        {
            InitializeComponent();
            establecerColumnasDeTabla();
            Gallos = gallos;
            Peleas = peleas;
            ActualizarTabla();
        }

        private void establecerColumnasDeTabla()
        {
            DgvGallos.Columns.Add("nombre", "Nombre");
            DgvGallos.Columns.Add("peso", "Peso");
            DgvGallos.Columns.Add("color", "Color");
            DgvGallos.Columns.Add("pelea", "Pelea");
            DgvGallos.Columns.Add("nombreDueno", "Nombre Dueño");
            foreach (DataGridViewTextBoxColumn columna in DgvGallos.Columns)
            {
                columna.Width = 121;
            }
        }

        private void ActualizarTabla()
        {
            DgvGallos.Rows.Clear();
            foreach (var gallo in Gallos)
            {
                DgvGallos.Rows.Add(
                    gallo.Id,
                    gallo.Peso,
                    gallo.Color,
                    gallo.Pelea,
                    gallo.nombreDueno
                );
            }
        }

        private void PanelListarGallos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTRegGallo_Click(object sender, EventArgs e)
        {
            Gallo gallo = new Gallo();
            List <Gallo> gallosMatch = new List<Gallo>();
            List<Gallo> gallosNoMatch = new List<Gallo>();
            bool noSeHagaMatch = false;

            string id = DgvGallos.CurrentRow.Cells["nombre"].Value.ToString();

            gallo = Gallos.Find(predicate => predicate.Id.Equals(id));

            Gallos.OrderBy(subject => subject.Peso);
            Gallos.ForEach( subject => {
                if((gallo.Peso == subject.Peso) && subject.Pelea.Equals("No"))
                {
                    gallosMatch.Add(subject); 
                }
                else
                {
                    gallosNoMatch.Add(subject);
                }
            });

            gallosMatch.OrderBy( subject => subject.Peso);
            gallosNoMatch.OrderBy( subject => subject.Peso);

            if(gallosMatch.Count != 0)
            {
                do
                {
                    Gallo galloMatch = gallosMatch[new Random().Next(0, gallosMatch.Count)];
                    galloMatch = galloMatch.Id.Equals(gallo.Id) ? null : galloMatch;

                    if (galloMatch is null)
                    {
                        noSeHagaMatch = true;
                        break;
                    }
                    else
                    {
                        galloMatch.Pelea = "Si";
                        gallo.Pelea = "Si";
                        Pelea pelea = new Pelea(gallo, galloMatch);
                        Peleas.Add(pelea);
                        ActualizarTabla();
                    }

                } while (noSeHagaMatch);

            }
         }
    }
}
