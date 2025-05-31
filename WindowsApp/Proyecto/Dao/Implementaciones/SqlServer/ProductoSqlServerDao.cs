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
        #region Commands
        private readonly string insertCommand = "INSERT INTO Producto (Nombre,Precio,CodigoBarra,FechaVencimiento,IdCategoria) VALUES (@Nombre,@Precio,@CodigoBarra,@FechaVencimiento,@IdCategoria);select @@Identity";
        
        private readonly string deleteCommand = "DELETE FROM Producto WHERE Id = @Id";

        private readonly string updateCommand = "UPDATE Producto SET Nombre = @Nombre, Precio = @Precio, CodigoBarra = @CodigoBarra, FechaVencimiento=@FechaVencimiento, IdCategoria = @IdCategoria where Id = @Id";

        private readonly string selectCommand = "SELECT * FROM Producto";

        private readonly string selectOne = "SELECT * FROM Producto WHERE Id = @Id";

        private readonly string selectByCodBar = "SELECT * FROM Producto WHERE CodigoBarra LIKE @CodigoBarra";

        private readonly string selectByVencimiento = "SELECT * FROM Producto WHERE FechaVencimiento >= @FechaDesde and FechaVencimiento <= @FechaHasta";
        #endregion

        public void Agregar(Producto producto)
        {
            //Cómo hago para convertir un producto (Objeto) en un registro de mi DB
            //Si tuviese un framework como EF, hago esto y listo:
            //context.Producto.Insert(producto);

            if (producto != null)
            {
                //Vamos a insertar la información
                using (SqlConnection conn = new SqlConnection(Settings.ConnString))
                {
                    conn.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(this.insertCommand, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@Nombre", producto.Nombre);
                        sqlCommand.Parameters.AddWithValue("@Precio", producto.Precio);
                        sqlCommand.Parameters.AddWithValue("@CodigoBarra", producto.CodigoBarra);
                        sqlCommand.Parameters.AddWithValue("@FechaVencimiento", producto.FechaVencimiento);

                        //Concepto de deshidratación de objetos
                        //Extraer los datos que pueden ser primitivos u objetos para el momento de la persistencia
      
                        if(producto.Categoria != null)
                            sqlCommand.Parameters.AddWithValue("@IdCategoria", producto.Categoria.Id); //En este caso tenemos un valor de categoría
                        else
                            sqlCommand.Parameters.AddWithValue("@IdCategoria", DBNull.Value); //Categoría podría ser null

                        object retorno = sqlCommand.ExecuteScalar();

                        if (retorno != null) //Significa que estoy obteniendo un retorno desde mi consulta...
                        {
                            producto.Id = int.Parse(retorno.ToString());
                        }
                    }
                }
            }
            else
                throw new ArgumentNullException("No se puede insertar un registro nulo");

        }

        public int Eliminar(int id)
        {
            //Vamos a insertar la información
            using (SqlConnection conn = new SqlConnection(Settings.ConnString))
            {
                conn.Open();

                using (SqlCommand sqlCommand = new SqlCommand(this.deleteCommand, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Id", id);

                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public int Modificar(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(Settings.ConnString))
            {
                conn.Open();

                using (SqlCommand sqlCommand = new SqlCommand(this.updateCommand, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    sqlCommand.Parameters.AddWithValue("@Precio", producto.Precio);
                    sqlCommand.Parameters.AddWithValue("@CodigoBarra", producto.CodigoBarra);
                    sqlCommand.Parameters.AddWithValue("@FechaVencimiento", producto.FechaVencimiento);

                    if (producto.Categoria != null)
                        sqlCommand.Parameters.AddWithValue("@IdCategoria", producto.Categoria.Id); //En este caso tenemos un valor de categoría
                    else
                        sqlCommand.Parameters.AddWithValue("@IdCategoria", DBNull.Value); //Categoría podría ser null

                    sqlCommand.Parameters.AddWithValue("@Id", producto.Id);

                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> productos = new List<Producto>();
            //ADO.NET: Tecnología por defecto que propone la plataforma de Microsoft
            //Frameworks ORM -> Object relational mapping
            //Entity Framewok (EF) -> Nativo Microsoft
            //Dapper -> Alta prestación, similar en performance a ADO.NET
            //NHibernate -> Hibernate era originalmente de JAVA

            //SqlConnection: Establece una conexión segura a mi motor de DB
            //SQlCommand: Ejecuta comandos sobre la connection
            //  1) ExecuteReader() -> Lectura de datos
            //  2) ExecuteScalar() -> INSERT (Guarda datos nuevos y me retorna el ID automático)
            //  3) ExecuteNonQuery() -> UPDATEs y DELETEs (Retorna un int con las filas afectadas)

            using (SqlConnection conn = new SqlConnection(Settings.ConnString))
            {
                conn.Open();

                using (SqlCommand sqlCommand = new SqlCommand(this.selectCommand, conn))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //Significa que estoy leyendo un registro...
                        Producto producto = HidratarProducto(reader);

                        productos.Add(producto);
                    }
                }
            }

            return productos;
        }

        private static Producto HidratarProducto(SqlDataReader reader)
        {
            Producto producto = new Producto();
            producto.Id = int.Parse(reader["Id"].ToString());
            producto.Nombre = reader["Nombre"].ToString();
            producto.Precio = decimal.Parse(reader["Precio"].ToString());
            producto.CodigoBarra = reader["CodigoBarra"].ToString();
            producto.FechaVencimiento = DateTime.Parse(reader["FechaVencimiento"].ToString());

            //Acá debemos "hidratar", completar los datos primitivos
            //y luego voy hidratando cada objeto que necesite...
            //En este caso solo tenemos el objeto Categoria como agregación

            //Solamente puedo buscar si el IdCategoria es distinto a null
            if (reader["IdCategoria"] != DBNull.Value)
                producto.Categoria = new CategoriaSqlServerDao().ObtenerPorId(int.Parse(reader["IdCategoria"].ToString()));
            return producto;
        }

        public List<Producto> ObtenerPorCodBar(string codbar)
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection conn = new SqlConnection(Settings.ConnString))
            {
                conn.Open();

                using (SqlCommand sqlCommand = new SqlCommand(selectByCodBar, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@CodigoBarra", "%" + codbar + "%");

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //Significa que estoy leyendo un registro...
                        Producto producto = HidratarProducto(reader);

                        productos.Add(producto);
                    }
                }
            }

            return productos;
        }

        public Producto ObtenerPorId(int id)
        {
            using (SqlConnection conn = new SqlConnection(Settings.ConnString))
            {
                conn.Open();

                using (SqlCommand sqlCommand = new SqlCommand(this.selectOne, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Id", id);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        //Significa que estoy leyendo un registro...
                        Producto producto = HidratarProducto(reader);

                        return producto;
                    }
                    return null;
                }
            }
        }

        public List<Producto> ObtenerPorFechaVencimiento(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection conn = new SqlConnection(Settings.ConnString))
            {
                conn.Open();

                using (SqlCommand sqlCommand = new SqlCommand(selectByVencimiento, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    sqlCommand.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //Significa que estoy leyendo un registro...
                        Producto producto = HidratarProducto(reader);

                        productos.Add(producto);
                    }
                }
            }

            return productos;
        }
    }
}
