using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases.Herencia
{
    /// <summary>
    /// Superclase que nos permite representar diferentes tipos de vehículos
    /// </summary>
    internal abstract class Vehiculo
    {
        /// <summary>
        /// 
        /// </summary>
        public int MaxFuel { get; set; }

        public int MaxNroPasajeros { get; set; }

        public int Velocidad { get; set; }

        public Vehiculo(int maxFuel, int maxNroPasajeros, int velocidad)
        {
            MaxFuel = maxFuel;
            MaxNroPasajeros = maxNroPasajeros;
            Velocidad = velocidad;
        }

        /// <summary>
        /// Método que deben ser implementados en las clases hijas
        /// </summary>
        public abstract void Acelerar();

        /// <summary>
        /// Método que deben ser implementados en las clases hijas
        /// </summary>
        public abstract void Desacelerar();

        /// <summary>
        /// Método concreto (Con implementación)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"[Vehiculo] MaxFuel: {MaxFuel}, MaxNroPasajeros {MaxNroPasajeros}, Velocidad {Velocidad}";
        }
    }
}
