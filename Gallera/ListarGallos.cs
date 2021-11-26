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
        public ListarGallos(List<Gallo> gallos)
        {
            InitializeComponent();
            establecerColumnasDeTabla();
            Gallos = gallos;
            ActualizarTabla();
        }

        private void establecerColumnasDeTabla()
        {
            DgvGallos.Columns.Add("nombre", "Nombre");
            DgvGallos.Columns.Add("peso", "Peso");
            DgvGallos.Columns.Add("color", "Color");
            DgvGallos.Columns.Add("pelea", "Pelea");
            DgvGallos.Columns.Add("nombreDueno", "Nombre Dueño");
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
    }
}
