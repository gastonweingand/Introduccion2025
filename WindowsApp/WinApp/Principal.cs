using POO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCrearTaxi_Click(object sender, EventArgs e)
        {

            if (txtPatente.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar la patente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Taxi taxi = new Taxi(colorPintura: Color.Aqua, patente: txtPatente.Text);

            //Taxi taxi = new Taxi();
            //taxi.Patente = txtPatente.Text;

            MessageBox.Show(taxi.ToString());
        }
    }
}
