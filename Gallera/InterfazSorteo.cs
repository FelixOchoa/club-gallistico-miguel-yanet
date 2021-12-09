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
            DgvGallos.Columns.Add("nombredueno1", "Dueño 1");
            DgvGallos.Columns.Add("nombre2", "Gallo 2");
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
                    pelea.Gallo1.Id,
                    pelea.Gallo1.Peso,
                    pelea.Gallo1.nombreDueno,
                    pelea.Gallo2.Id,
                    pelea.Gallo2.Peso,
                    pelea.Gallo2.nombreDueno
                );
            }
        }

        private void PanelListarGallos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Emparejar_Click(object sender, EventArgs e)
        {

        }

        private void DgvGallos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancelarPelea_Click(object sender, EventArgs e)
        {
            string id1 = DgvGallos.CurrentRow.Cells["nombre1"].Value.ToString();
            string id2 = DgvGallos.CurrentRow.Cells["nombre2"].Value.ToString();
            Pelea pelea = Peleas.Find(predicate => predicate.Gallo1.Id.Equals(id1));
            pelea.Gallo1.Pelea = "No";
            pelea.Gallo2.Pelea = "No";
            Peleas.Remove(pelea);
            ActualizarTabla();
        }
    }
}
