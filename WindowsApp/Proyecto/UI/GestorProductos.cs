using Dao.Domain;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class GestorProductos : Form
    {
        private bool alta;

        public Producto Producto { get; set; }
        public GestorProductos(bool alta = true, Producto producto = null)
        {
            InitializeComponent();

            this.alta = alta;
            this.Text = (alta) ? "Alta de producto" : "Modificar producto";
            Producto = producto;

            if (producto != null)
            {
                //Asignar datos a la UI
                txtCodBar.Text = producto.CodigoBarra;
                txtNombre.Text = producto.Nombre;
                numPrecio.Value = producto.Precio;
                calFecha.SelectionStart = producto.FechaVencimiento;
            }
        }


        private void btnAceptar_MouseDown(object sender, MouseEventArgs e)
        {
            //Hacer todas las validaciones pertinentes
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Nombre no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (alta)
                Producto = new Producto();
            //Cargo los datos desde la UI a mi objeto producto
            Producto.Nombre = txtNombre.Text;
            Producto.Precio = numPrecio.Value;
            Producto.CodigoBarra = txtCodBar.Text;
            Producto.FechaVencimiento = calFecha.SelectionStart;       

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
