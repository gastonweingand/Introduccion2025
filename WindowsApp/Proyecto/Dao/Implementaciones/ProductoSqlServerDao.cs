using Dao.Domain;
using Dao.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Implementaciones
{
    public class ProductoSqlServerDao : IProductoDao
    {
        private string connString = ConfigurationManager.ConnectionStrings["DBIntroduccion"].ConnectionString;
        public void Agregar(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Producto producto)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerPorCodBar(string codbar)
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
            //ADO.NET: Tecnología por defecto que propone la plataforma de Microsoft
            //

            //SqlConnection: Establece una conexión segura a mi motor de DB
            //SQlCommand: Ejecuta comandos sobre la connection
            //  1) ExecuteReader() -> Lectura de datos
            //  2) ExecuteScalar() -> INSERT (Guarda datos nuevos y me retorna el ID automático)
            //  3) ExecuteNonQuery() -> UPDATEs y DELETEs (Retorna un int con las filas afectadas)

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string command = "SELECT * FROM Producto";

                using (SqlCommand sqlCommand = new SqlCommand(command, conn))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //Significa que estoy leyendo un registro...
                        Producto producto = new Producto();
                        producto.Id = int.Parse(reader["Id"].ToString());
                        producto.Nombre = reader["Nombre"].ToString();
                        producto.Precio = decimal.Parse(reader["Precio"].ToString());
                        producto.CodigoBarra = reader["CodigoBarra"].ToString();
                        producto.FechaVencimiento = DateTime.Parse(reader["FechaVencimiento"].ToString());

                        //producto.Categoria  = 

                        productos.Add(producto);
                    }
                }
            }

            return productos;
        }
    }
}
