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
            List <Gallo> gallosMatch = new List<Gallo>();
            List<Gallo> gallosNoMatch = new List<Gallo>();
            bool noSeHagaMatch = false;

            foreach (var gallo in Gallos)
            {
                if (gallo.Pelea.Equals("Si")) { continue; }
                double x = 0;
                double y = 0;
                double z = 0;
                double tot = 0;
                Gallos.OrderBy(subject => subject.Peso);
                Gallos.ForEach(subject =>
                {
                    if ((Math.Abs(gallo.Peso - subject.Peso) <= 0.10000000000000142) && subject.Pelea.Equals("No"))
                    {
                        y = gallo.Peso;
                        z = subject.Peso;
                        tot = gallo.Peso - subject.Peso;
                        x = Math.Abs(gallo.Peso - subject.Peso);

                        gallosMatch.Add(subject);
                    }
                    else
                    {
                        y = gallo.Peso;
                        z = subject.Peso;
                        tot = gallo.Peso - subject.Peso;
                        x = Math.Abs(gallo.Peso - subject.Peso);
                        gallosNoMatch.Add(subject);
                    }
                });

                gallosMatch.OrderBy(subject => subject.Peso);
                gallosNoMatch.OrderBy(subject => subject.Peso);

                if (gallosMatch.Count != 0)
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
                            noSeHagaMatch = false;
                            galloMatch.Pelea = "Si";
                            gallo.Pelea = "Si";
                            Pelea pelea = new Pelea(gallo, galloMatch);
                            Peleas.Add(pelea);
                            ActualizarTabla();
                        }

                    } while (noSeHagaMatch);

                }
                gallosMatch.Clear();
                gallosNoMatch.Clear();
            }
         }

        private void DgvGallos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
