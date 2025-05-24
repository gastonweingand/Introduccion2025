using Dao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Interfaces
{
    internal interface ICategoriaDAO
    {
        void Agregar(Categoria categoria);

        int Modificar(Categoria categoria);

        int Eliminar(int id);

        Categoria ObtenerPorId(int id);

        List<Categoria> ObtenerTodos();
    }
}
