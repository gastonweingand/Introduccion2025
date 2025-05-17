using Dao.Domain;
using Dao.Implementaciones;
using Dao.Interfaces;
using System;
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
    public partial class Productos : Form
    {
        private IProductoDao daoProductos = new ProductoSqlServerDao();

        public Productos()
        {
            InitializeComponent();
        }

        private void btnTraerTodo_Click(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            //Se limpia la grilla
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = daoProductos.ObtenerTodos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GestorProductos gestorProductos = new GestorProductos();

            if (gestorProductos.ShowDialog() == DialogResult.OK)
            {
                //Si se dio ok, significa que retorno un Producto nuevo
                //Debería agregarlo a mi backend
                Producto productoNuevo = gestorProductos.Producto;
                //Llamo a mi acceso a datos para agregar este nuevo producto en memoria
                daoProductos.Agregar(productoNuevo);
                RefrescarGrilla();

                MessageBox.Show("Producto agregado correctamente");
            }
            else
                MessageBox.Show("Operación cancelada");
        }

        private void btnObtenerPorId_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text); //Recordar utilizar tryParse
            Producto producto = daoProductos.ObtenerPorId(id);

            if (producto != null)
                MessageBox.Show($"Producto encontrado {producto}");
            else
                MessageBox.Show("No encontrado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnObtenerPorCodBar_Click(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();

            productos = daoProductos.ObtenerPorCodBar(txtCodBar.Text);

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Primero tengo que obtener el objeto a modificar

            if (dgvProductos.SelectedRows.Count == 1)
            {
                Producto producto = dgvProductos.SelectedRows[0].DataBoundItem as Producto;

                GestorProductos gestorProductos = new GestorProductos(false, producto);

                if (gestorProductos.ShowDialog() == DialogResult.OK)
                {
                    //Si se dio ok, significa que retorno el producto modificado
                    Producto productoModificado = gestorProductos.Producto;
                    //Llamo a mi acceso a datos para modificar este producto en memoria
                    daoProductos.Modificar(productoModificado);
                    RefrescarGrilla();

                    MessageBox.Show("Producto modificado correctamente");
                }
                else
                    MessageBox.Show("Operación cancelada");
            }
            else
            {
                MessageBox.Show("Debe selecciona al menos una fila.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 1)
            {
                Producto producto = dgvProductos.SelectedRows[0].DataBoundItem as Producto;

                //Para eliminar, se suele reconfirmar la operación
                if(MessageBox.Show($"¿Desea eliminar el producto {producto.Nombre}?", "Confirmación", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //Acá voy a eliminar del repositorio
                    daoProductos.Eliminar(producto.Id);
                    RefrescarGrilla();
                    MessageBox.Show("Producto eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("Se canceló la operación");
                }
            }
            else
            {
                MessageBox.Show("Debe selecciona al menos una fila.");
            }
        }
    }
}