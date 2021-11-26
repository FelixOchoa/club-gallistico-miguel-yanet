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

        public ListarPollos(List<Pollo> pollos)
        {
            InitializeComponent();
            establecerColumnasDeTabla();
            Pollos = pollos;
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
    }
}
