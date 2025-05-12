using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Taxi
    {
        //Atributos

        //Encapsulamiento ->Variable privada (Atributo, Field)
        //+ un método de lectura (+Get) + un método de escritura (+Set)
        //private string patente;

        //public string GetPatente()
        //{
        //    return patente;
        //}

        //public void SetPatente(string patente)
        //{
        //   this.patente = patente;
        //}

        /// <summary>
        /// Cuando compila .net al lenguaje intermedio IL
        /// Microsoft automáticamente te genera lo de arriba
        /// </summary>
        public string Patente { get; set; } //Property         

        public Color ColorPintura { get; set; }

        public int KmRecorridos { get; set; }

        public int CombustibleActual { get; set; }


        //Constructores
        public Taxi() //POR DEFECTO
        {
            Console.WriteLine("Creando un objeto de tipo Taxi");
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~Taxi() {
            Console.WriteLine($"Destruyendo el objeto taxi {Patente}");
        }


        /// <summary>
        /// Constructor con 2 argumentos
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="colorPintura"></param>
        public Taxi(string patente, Color colorPintura)
        {
            Console.WriteLine("Creando un objeto de tipo Taxi con 2 argumentos");
            Patente = patente;
            ColorPintura = colorPintura;
        }

        public Taxi(string patente, Color colorPintura, int kmRecorridos, int combustibleActual = 10) : this(patente, colorPintura)
        {
            KmRecorridos = kmRecorridos;
            CombustibleActual = combustibleActual;
        }


        //Comportamiento
        public void Solicitar()
        {
            Console.WriteLine("Alguien está solicitando el taxi.");
        }

        public void RecibirPagoPorViaje()
        {
            Console.WriteLine("Alguien está pagando por el viaje recorrido.");
        }

        public void CargarCombustible(int litros)
        {
            this.CombustibleActual += litros;
        }

        public override string ToString()
        {
            return $"Patente: {Patente}, KmRecorridos: {KmRecorridos}";
        }
    }
}
