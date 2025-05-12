using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Domain
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public string CodigoBarra { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public Producto()
        {
            
        }
        public Producto(int id, string nombre, decimal precio, string codigoBarra, DateTime fechaVencimiento)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            CodigoBarra = codigoBarra;
            FechaVencimiento = fechaVencimiento;
        }
    }
}
