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
    public partial class InterfazSorteo : Form
    {
        public List<Pelea> Peleas { get; set; }
        public InterfazSorteo(List<Pelea> peleas)
        {
            InitializeComponent();
            establecerColumnasDeTabla();
            Peleas = peleas;
            ActualizarTabla();
        }

        private void establecerColumnasDeTabla()
        {
            DgvGallos.Columns.Add("nombre1", "Gallo 1");
            DgvGallos.Columns.Add("peso1", "Peso");
            DgvGallos.Columns.Add("nombre2", "Gallo 2");
            DgvGallos.Columns.Add("peso2", "Peso");


            foreach (DataGridViewTextBoxColumn columna in DgvGallos.Columns)
            {
                columna.Width = 121;
            }
        }

        private void ActualizarTabla()
        {
            DgvGallos.Rows.Clear();
            foreach (var pelea in Peleas)
            {
                DgvGallos.Rows.Add(
                    pelea.Gallo1.Id,
                    pelea.Gallo1.Peso,
                    pelea.Gallo2.Id,
                    pelea.Gallo2.Peso
                );
            }
        }


    }
}
