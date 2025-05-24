using Dao.Domain;
using Dao.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Implementaciones
{
    public class ProductoFileDao : IProductoDao
    {        
        public void Agregar(Producto producto)
        {
            //using es un bloque de liberación de recursos a la fuerza
            using (StreamWriter sw = new StreamWriter(Settings.FilePathDB, true))
            {
                //Deberíamos definir un formato para guardar el archivo
                sw.WriteLine(producto);
            }
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Producto producto)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerPorCodBar(string codbar)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerPorFechaVencimiento(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NotImplementedException();
        }

        public Producto ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> productos = new List<Producto>();
            //Leer los registros desde el file y convertirlos a objetos

            using (StreamReader sr = new StreamReader(Settings.FilePathDB))
            {
                while (!sr.EndOfStream)
                {
                    //Mientras tenga contenigo en mi archivo, avanzo de a una lína
                    string linea = sr.ReadLine();

                    string[] campos = linea.Split(',');

                    //string campoIdNombre = campos[0].Split(':')[0];
                    string campoIdValor = campos[0].Split(':')[1];
                    string campoNombreValor = campos[1].Split(':')[1];
                    string campoPrecioValor = campos[2].Split(':')[1];
                    string campoCodigoBarraValor = campos[3].Split(':')[1];
                    //string campoFechaVencimientoValor = campos[4].Split(':')[1];

                    Producto producto = new Producto();
                    producto.Id = int.Parse(campoIdValor);
                    producto.Nombre = campoNombreValor;
                    producto.Precio = decimal.Parse(campoPrecioValor);
                    producto.CodigoBarra = campoCodigoBarraValor;
                    //producto.FechaVencimiento = DateTime.Parse(campoFechaVencimientoValor);

                    productos.Add(producto);
                }
            }

            return productos;
        }
    }
}
