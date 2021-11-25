﻿using System;
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
    public partial class RegistroGallos : Form
    {
        public List<Gallo> Gallos { get; set; }
        public RegistroGallos(List<Gallo> gallos)
        {
            InitializeComponent();
            Gallos = gallos;
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

        private void BTRegGallo_Click(object sender, EventArgs e)
        {
            Gallo gallo = new Gallo();

            gallo.Id = TBID.Text;
            gallo.Color = TBColor.Text;
            gallo.Peso = TBPeso.Text;
            gallo.Pelea = "No";

            Gallos.Add(gallo);
        }

    }
}
