using Dao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Interfaces
{
    /// <summary>
    /// Patrón Dao: Establece un contrato de acceso a datos
    /// para cada entidad del dominio
    /// Producto, Cliente y Venta
    /// IProductoDao, IClienteDao y IVentaDao
    /// </summary>
    public interface IProductoDao
    {
        void Agregar(Producto producto);

        int Modificar(Producto producto);

        int Eliminar(int id);

        Producto ObtenerPorId(int id);

        List<Producto> ObtenerTodos();

        List<Producto> ObtenerPorCodBar(string codbar);

        List<Producto> ObtenerPorFechaVencimiento(DateTime fechaDesde, DateTime fechaHasta);
    }
}
