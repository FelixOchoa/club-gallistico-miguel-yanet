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
    public partial class ListarPollos : Form
    {
        public List<Pollo> Pollos { get; set; }
        public List<Pelea2> Peleas { get; set; }


        public ListarPollos(List<Pollo> pollos, List<Pelea2> peleas)
        {
            InitializeComponent();
            establecerColumnasDeTabla();
            Pollos = pollos;
            Peleas = peleas;
            ActualizarTabla();
        }

        private void PanelListarGallos_Paint(object sender, PaintEventArgs e)
        {

        }
        private void establecerColumnasDeTabla()
        {
            DGVPollos.Columns.Add("nombre", "Nombre");
            DGVPollos.Columns.Add("peso", "Peso");
            DGVPollos.Columns.Add("color", "Color");
            DGVPollos.Columns.Add("pelea", "Pelea");
            DGVPollos.Columns.Add("nombreDueno", "Nombre Dueño");
            foreach ( DataGridViewTextBoxColumn columna in DGVPollos.Columns)
            {
                columna.Width = 121; 
            }
        }

        private void ActualizarTabla()
        {
            DGVPollos.Rows.Clear();
            foreach (var pollo in Pollos)
            {
                DGVPollos.Rows.Add(
                    pollo.Id,
                    pollo.Peso,
                    pollo.Color,
                    pollo.Pelea,
                    pollo.nombreDueno
                );
            }
        }

        private void BTRegGallo_Click(object sender, EventArgs e)
        {
            Pollo pollo = new Pollo();
            List<Pollo> pollosMatch = new List<Pollo>();
            List<Pollo> pollosNoMatch = new List<Pollo>();
            bool noSeHagaMatch = false;

            string id = DGVPollos.CurrentRow.Cells["nombre"].Value.ToString();

            pollo = Pollos.Find(predicate => predicate.Id.Equals(id));
            if (pollo.Pelea.Equals("Si")) { return; }

            Pollos.OrderBy(subject => subject.Peso);
            Pollos.ForEach(subject => {
                if ((pollo.Peso == subject.Peso) && subject.Pelea.Equals("No"))
                {
                    pollosMatch.Add(subject);
                }
                else
                {
                    pollosNoMatch.Add(subject);
                }
            });

            pollosMatch.OrderBy(subject => subject.Peso);
            pollosNoMatch.OrderBy(subject => subject.Peso);

            if (pollosMatch.Count != 0)
            {
                do
                {
                    Pollo polloMatch = pollosMatch[new Random().Next(0, pollosMatch.Count)];
                    polloMatch = polloMatch.Id.Equals(pollo.Id) ? null : polloMatch;

                    if (polloMatch is null)
                    {
                        noSeHagaMatch = true;
                        break;
                    }
                    else
                    {
                        polloMatch.Pelea = "Si";
                        pollo.Pelea = "Si";
                        Pelea2 pelea = new Pelea2(pollo, polloMatch);
                        Peleas.Add(pelea);
                        ActualizarTabla();
                    }

                } while (noSeHagaMatch);

            }
        }
    }
}
