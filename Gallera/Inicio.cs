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
    public partial class Inicio : Form
    {
        public List<Gallo> Gallos { get; set; }
        public List<Pollo> Pollos { get; set; }

        public Inicio()
        {
            InitializeComponent();
            IniciarListas();
        }

        private void IniciarListas()
        {
            Gallos = new List<Gallo>();
            Pollos = new List<Pollo>(); 
        }
        private void openForm(object formChild)
        {
            if (this.childContainer.Controls.Count > 0)
            {
                this.childContainer.Controls.RemoveAt(0);

            }

            Form FormChild = formChild as Form;
            FormChild.TopLevel = false;
            FormChild.Dock = DockStyle.Fill;
            this.childContainer.Controls.Add(FormChild);
            this.childContainer.Tag = FormChild;
            FormChild.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new RegistroGallos(Gallos));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openForm(new RegistroPollos(Pollos));
        }

        private void BTListarGallo_Click(object sender, EventArgs e)
        {
            openForm(new ListarGallos(Gallos));

        }

        private void BTListarPollo_Click(object sender, EventArgs e)
        {
            openForm(new ListarPollos(Pollos));

        }
    }
}
