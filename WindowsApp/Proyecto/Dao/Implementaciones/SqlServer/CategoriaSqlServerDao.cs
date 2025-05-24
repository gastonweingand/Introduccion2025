using Dao.Domain;
using Dao.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Implementaciones
{
    internal class CategoriaSqlServerDao : ICategoriaDAO
    {
        #region Commands

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
            throw new NotImplementedException();
        }

        public List<Categoria> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
