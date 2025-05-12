using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases.Agregacion
{
    internal class TarjetaCredito
    {
        public string Numero { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public string EntidadBancaria { get; set; } //Debería ser una composición
    }
}
