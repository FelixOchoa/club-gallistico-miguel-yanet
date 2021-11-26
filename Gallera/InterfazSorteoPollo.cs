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
    public partial class InterfazSorteoPollo : Form
    {
        public List<Pelea2> Peleas { get; set; }
        public InterfazSorteoPollo(List<Pelea2> peleas)
        {
            InitializeComponent();
            establecerColumnasDeTabla();
            Peleas = peleas;
            ActualizarTabla();
        }

        private void establecerColumnasDeTabla()
        {
            DgvGallos.Columns.Add("nombre1", "Pollo 1");
            DgvGallos.Columns.Add("peso1", "Peso");
            DgvGallos.Columns.Add("nombredueno1", "Dueño 1");
            DgvGallos.Columns.Add("nombre2", "Pollo 2");
            DgvGallos.Columns.Add("peso2", "Peso");
            DgvGallos.Columns.Add("nombredueno2", "Dueño 2");



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
                    pelea.Pollo1.Id,
                    pelea.Pollo1.Peso,
                    pelea.Pollo1.nombreDueno,
                    pelea.Pollo2.Id,
                    pelea.Pollo2.Peso,
                    pelea.Pollo2.nombreDueno
                );
            }
        }
    }
}
