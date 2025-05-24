using Dao.Domain;
using Dao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Implementaciones
{
    /// <summary>
    /// Producto Memory "implementa" la intarfaz IProductoDao
    /// </summary>
    public class ProductoMemoryDao : IProductoDao
    {
        //Estas clases suelen ser singleton, ya que tenemos una instancia única para toda la aplicación

        private List<Producto> productos = new List<Producto>();

        public ProductoMemoryDao()
        {
            //Generamos algunos objetos por defecto
            productos.Add(new Producto(1, "Fideos terrabusi moñito 500g", 3000, "0001", DateTime.Now.AddYears(10)));
            productos.Add(new Producto(2, "Fideos marolio largo 500g", 2500, "0002", DateTime.Now.AddYears(11)));
            productos.Add(new Producto(3, "Fideos arcor tirabuzón 500g", 1800, "0003", DateTime.Now.AddYears(15)));
        }

        public void Agregar(Producto producto)
        {
            int ultimoId = productos.Count;
            producto.Id = ultimoId + 1; //Le agregamos un id más a nuestros listado
            productos.Add(producto);
        }

        public int Eliminar(int id)
        {
            //A la antigua, buscando el elemento y luego eliminándolo.
            Producto producto = ObtenerPorId(id);
            productos.Remove(producto);

            return 1;

            //Linq, a través de una expresión lambda
            //productos.RemoveAll(o => o.Id == id);
        }

        public int Modificar(Producto producto)
        {
            //Para modificar, primero debemos buscar el producto a ser modificado
            Producto produ = ObtenerPorId(producto.Id);

            produ.CodigoBarra = producto.CodigoBarra;
            produ.Nombre = producto.Nombre;
            produ.FechaVencimiento = producto.FechaVencimiento;
            produ.Precio = producto.Precio;

            return 1;
        }

        public List<Producto> ObtenerPorCodBar(string codbar)
        {
            //Linq, es una tecnología de .net que nos permite hacer entre cosas
            //filtros...
            return productos.Where(o => o.CodigoBarra.Contains(codbar)).ToList();
        }

        public List<Producto> ObtenerPorFechaVencimiento(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NotImplementedException();
        }

        public Producto ObtenerPorId(int id)
        {
            foreach (Producto item in productos)
            {
                if(item.Id == id)
                {
                    //Encontré el producto en mi lista
                    return item;
                }
            }

            return null;            
        }

        public List<Producto> ObtenerTodos()
        {
            return productos;
        }
    }
}
