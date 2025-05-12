using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases.Herencia
{
    internal class Avion : Vehiculo
    {
        public int MaxAltitud { get; set; }

        public int NroMotores { get; set; }

        public Avion(int maxAltitud, int nroMotores, int maxFuel, int maxNroPasajeros, int velocidad) : base(maxFuel, maxNroPasajeros, velocidad)
        {
            this.MaxAltitud = maxAltitud;
            this.NroMotores = nroMotores;
        }

        public void Descender()
        {
            Console.WriteLine("Establecimiento mecanismos para el descenso");
            Acelerar();
            Console.WriteLine("Vuelvo a posición original");
            Desacelerar();
        }

        public void Ascender()
        {
            Console.WriteLine("Establecimiento mecanismos para el ascenso");
            Acelerar();
            Console.WriteLine("Vuelvo a posición original");
            Desacelerar();
        }

        public override void Acelerar()
        {
            Console.WriteLine("Soy un avión y estoy acelerando");
        }

        public override void Desacelerar()
        {
            Console.WriteLine("Soy un avión y estoy acelerando");
        }

        public override string ToString()
        {
            return base.ToString() + $"[Avión] MaxAltitud: {MaxAltitud}, NroMotores: {NroMotores}";
        }

    }
}
