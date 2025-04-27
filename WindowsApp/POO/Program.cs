using POO.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defino la variable (objeto) llamado taxi1
            //del tipo Taxi
            Taxi taxi1;
            //Con el new (Instancia de la clase Taxi)
            taxi1 = new Taxi("ABC", Color.Red); //Recién aquí taxi1 ocupa espacio en memoria RAM

            Taxi taxi2 = new Taxi("Z", Color.White);

            Taxi taxi3 = new Taxi("A", Color.Red, 1234, 1);

            taxi3.Patente = "B";

            taxi1.Solicitar();

            taxi1.RecibirPagoPorViaje();

            taxi1.CargarCombustible(10);

            taxi1.Patente = "ABX123";
            taxi1.ColorPintura = Color.Black;
            taxi1.KmRecorridos = 1000;

            Console.WriteLine(taxi1);

            Console.Read();
        }
    }
}
