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
            pollo.Peso = Convert.ToDouble(TBPeso.Text);
            pollo.Pelea = "No";
            pollo.nombreDueno = TBNombreDueno.Text;


            if (TBID.Text == "")
            {
                MessageBox.Show("El campo de identificación está vacío", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(TBColor.Text == "")
            {
                MessageBox.Show("El campo de color está vacío", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TBPeso.Text == "")
            {
                MessageBox.Show("El campo de peso está vacío", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(TBNombreDueno.Text == "")
            {
                MessageBox.Show("El campo nombre dueño está vacío", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Pollos.Add(pollo);

                TBID.Text = "";
                TBColor.Text = "";
                TBPeso.Text = "";
                TBNombreDueno.Text = "";
                MessageBox.Show("El Pollo se ha registrado correctamente", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
