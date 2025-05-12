using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases.Herencia
{
    internal class Auto : Vehiculo
    {      
        public string Modelo { get; set; }

        public Auto(string modelo, int maxFuel, int maxNroPasajeros, int velocidad) : base(maxFuel, maxNroPasajeros, velocidad)
        {
            this.Modelo = modelo;
        }

        public void DoblarIzquierda()
        {
            Console.WriteLine("Girando las ruedas a la izquierda");
            Acelerar();
            Console.WriteLine("Vuelvo a posición original");
            Desacelerar();
        }

        public void DoblarDerecha()
        {
            Console.WriteLine("Girando las ruedas a la derecha");
            Acelerar();
            Console.WriteLine("Vuelvo a posición original");
            Desacelerar();
        }

        public override void Acelerar()
        {
            Console.WriteLine("Soy un auto y estoy acelerando");
        }

        public override void Desacelerar()
        {
            Console.WriteLine("Soy un auto y estoy desacelerando");
        }

        public override string ToString()
        {
            return base.ToString() + $"[Auto] Modelo: {Modelo}";
        }
    }
}
