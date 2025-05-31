using Dao.Domain;
using Dao.Implementaciones;
using Dao.Interfaces;
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

        private ICategoriaDao datoCategorias = new CategoriaSqlServerDao();

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

            if (cmbCategorias.SelectedItem.ToString() == "--Seleccione--")
            {
                MessageBox.Show("Debe seleccionar un valor para la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Categoria categoriaSeleccionada = cmbCategorias.SelectedItem as Categoria;


            if (alta)
                Producto = new Producto();
            //Cargo los datos desde la UI a mi objeto producto
            Producto.Nombre = txtNombre.Text;
            Producto.Precio = numPrecio.Value;
            Producto.CodigoBarra = txtCodBar.Text;
            Producto.FechaVencimiento = calFecha.SelectionStart;
            Producto.Categoria = categoriaSeleccionada;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void GestorProductos_Load(object sender, EventArgs e)
        {
            Categoria categoriaSeleccione = new Categoria();
            categoriaSeleccione.Id = 0;
            categoriaSeleccione.Nombre = "--Seleccione--";

            List<Categoria> categorias = new List<Categoria>();
            categorias.Add(categoriaSeleccione);

            categorias.AddRange(datoCategorias.ObtenerTodos());            

            //Tengo el listado de todas las categorías
            cmbCategorias.DataSource = categorias;

            if (Producto?.Categoria != null)
            {
                Categoria categoria = new Categoria();
                //Buscamos en ese listado qué categoría es la asignada para el objeto a modificar...
                foreach (Categoria c in categorias)
                {
                    if (c.Id == Producto.Categoria.Id)
                    {
                        categoria = c;
                        break;
                    }
                }
                //Finalmente lo asignamos como item seleccionado en el combo
                cmbCategorias.SelectedItem = categoria;
            }
        }
    }
}
