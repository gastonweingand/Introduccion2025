using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases.Herencia
{
    internal class Motocicleta : Vehiculo
    {
        public Motocicleta(int maxFuel, int maxNroPasajeros, int velocidad) : base(maxFuel, maxNroPasajeros, velocidad)
        {
        }

        public override void Acelerar()
        {
            throw new NotImplementedException();
        }

        public override void Desacelerar()
        {
            throw new NotImplementedException();
        }
    }
}
