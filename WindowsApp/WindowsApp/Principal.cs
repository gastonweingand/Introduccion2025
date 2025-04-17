using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler
        /// </summary>
        /// <param name="sender">Control que creo el evento</param>
        /// <param name="e">argumentos que vienen predefinidos</param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mostrando texto en may");
            MessageBox.Show(txtNombre.Text.ToUpper(), "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando la aplicación");
        }

        private void Principal_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.X + " " + e.Y;
        }
    }
}
