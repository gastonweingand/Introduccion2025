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
    public class CategoriaSqlServerDao : ICategoriaDao
    {
        #region Commands
        private readonly string insertCommand = "INSERT INTO Categoria (Nombre,Descripcion) VALUES (@Nombre,@Descripcionoria);select @@Identity";

        private readonly string deleteCommand = "DELETE FROM Categoria WHERE Id = @Id";

        private readonly string updateCommand = "UPDATE Categoria SET Id = @ID, Nombre = @Nombre, Descripcion = @Descripcion where Id = @Id";

        private readonly string selectCommand = "SELECT * FROM Categoria";

        private readonly string selectOne = "SELECT * FROM Categoria WHERE Id = @Id";

        #endregion

        public void Agregar(Categoria categoria)
        {
            //Cuando necesito el conn string lo llamo directamente
            string conn = Settings.ConnString;

            throw new NotImplementedException();
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Categoria ObtenerPorId(int id)
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
                        Categoria categoria = new Categoria();
                        categoria.Id = int.Parse(reader["Id"].ToString());
                        categoria.Nombre = reader["Nombre"].ToString();
                        categoria.Descripcion = reader["Descripcion"].ToString();

                        return categoria;
                    }
                    return null;
                }
            }
        }

        public List<Categoria> ObtenerTodos()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (SqlConnection conn = new SqlConnection(Settings.ConnString))
            {
                conn.Open();

                using (SqlCommand sqlCommand = new SqlCommand(this.selectCommand, conn))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //Significa que estoy leyendo un registro...
                        Categoria categoria = new Categoria();
                        categoria.Id = int.Parse(reader["Id"].ToString());
                        categoria.Nombre = reader["Nombre"].ToString();
                        categoria.Descripcion = reader["Descripcion"].ToString();

                        categorias.Add(categoria);
                    }
                }
            }

            return categorias;
        }
    }
}
