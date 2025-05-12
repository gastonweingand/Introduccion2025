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
        private IProductoDao daoProductos = new ProductoMemoryDao();

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
    }
}
