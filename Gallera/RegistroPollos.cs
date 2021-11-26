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
    public partial class RegistroPollos : Form
    {
        public List<Pollo> Pollos { get; set; }
        public RegistroPollos(List<Pollo> pollos)
        {
            InitializeComponent();
            Pollos = pollos;
        }

        private void TBPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PanelPollo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BTRegPollo_Click(object sender, EventArgs e)
        {
            Pollo pollo = new Pollo();
            pollo.Id = TBID.Text;
            pollo.Color = TBColor.Text;
            pollo.Peso = TBPeso.Text;
            pollo.Pelea = "No";
            pollo.nombreDueno = TBNombreDueno.Text;

            Pollos.Add(pollo);
        }
    }
}
