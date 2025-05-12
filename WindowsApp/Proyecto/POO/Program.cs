using POO.Clases;
using POO.Clases.Agregacion;
using POO.Clases.Composicion;
using POO.Clases.Figuras;
using POO.Clases.Herencia;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Composición y agregación
                Direccion direccion = new Direccion();
                direccion.Localidad = "Boulogne";
                direccion.Calle = "Sarratea";
                direccion.Numero = 1000;
                direccion.Provincia = "Buenos Aires";

                Cliente cliente = new Cliente(1, "Pedrito", DateTime.Now.AddYears(-20), direccion);

                TarjetaCredito tarjetaCredito = new TarjetaCredito();
                tarjetaCredito.EntidadBancaria = "Galicia";
                tarjetaCredito.FechaVencimiento = DateTime.Now.AddYears(2);
                tarjetaCredito.Numero = "YYYY-YYYY-YYYY-YYYY";

                Console.WriteLine(cliente);

                //Opcionalmente le asignamos una tarjeta de crédito al cliente (Agregación)
                cliente.TarjetaCredito = tarjetaCredito;

                Console.WriteLine(cliente);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          




            //Ejercicio de figuras geométricas

            Cuadrado cuadrado = new Cuadrado(4, 100, 50);
            Rectangulo rectangulo = new Rectangulo(8, 3, 400, 200);

            List<FiguraGeometrica> figuras = new List<FiguraGeometrica>();

            figuras.Add(rectangulo);
            figuras.Add(cuadrado);

            foreach (FiguraGeometrica figura in figuras)
            {
                Console.WriteLine(figura);
                Console.WriteLine($"Área: {figura.Area().ToString("0.00")}");
                Console.WriteLine($"Perímetro: {figura.Perimetro().ToString("0.00")}");
            }


            //Defino la variable (objeto) llamado taxi1
            //del tipo Taxi
            Taxi taxi1;
            //Con el new (Instancia de la clase Taxi)
            taxi1 = new Taxi("ABC", Color.Red); //Recién aquí taxi1 ocupa espacio en memoria RAM

            taxi1.Solicitar();

            taxi1.RecibirPagoPorViaje();

            taxi1.CargarCombustible(10);

            taxi1.Patente = "ABX123";
            taxi1.ColorPintura = Color.Black;
            taxi1.KmRecorridos = 1000;

            Console.WriteLine(taxi1);

            //Clase Nro 4- Relaciones entre clases

            Auto auto = new Auto("Sedán", 40, 5, 0);
            auto.Acelerar();
            auto.DoblarDerecha();

            Avion avion = new Avion(10000, 2, 1000, 100, 0);
            avion.Acelerar();
            avion.Ascender();

            //El problema es que vehículo en la vida real
            //No podría ser jamás un objeto concreto
            Vehiculo vehiculoAuto = new Auto("Descapotable", 60, 2, 0);
            vehiculoAuto.Acelerar();
            vehiculoAuto.Desacelerar();

            Vehiculo vehiculoAvion = new Avion(10000, 2, 600, 2, 0);
            vehiculoAvion.Acelerar();
            vehiculoAvion.Desacelerar();

            //Si quiero tratar a un objeto que se definió como una abstración
            //Con un tripo más concreto, debo hacer un CAST
            (vehiculoAvion as Avion).Ascender(); //Método propio del avión
            (vehiculoAuto as Auto).DoblarDerecha(); //Método propio del auto

            Console.WriteLine(auto);
            Console.WriteLine(avion);
            Console.WriteLine(vehiculoAvion);
            Console.WriteLine(vehiculoAuto);

            List<Auto> autos = new List<Auto>(); //Concretas
            List<Avion> avions = new List<Avion>(); //Concretas
            List<Vehiculo> vehiculos = new List<Vehiculo>(); //Abstracciones

            Motocicleta motocicleta = new Motocicleta(0, 0, 0);

            vehiculos.Add(auto);
            vehiculos.Add(avion);
            vehiculos.Add(vehiculoAuto);
            vehiculos.Add(vehiculoAvion);
            vehiculos.Add(motocicleta);

            foreach (Vehiculo item in vehiculos)
            {
                //Reflection -> Técnica para conocer la metadata de mis objetos
                if (item is Auto)
                {
                    Console.WriteLine((item as Auto).Modelo);
                    continue;
                }
                if (item is Avion)
                {
                    Console.WriteLine((item as Avion).MaxAltitud);
                }
            }



            Taxi taxi2 = new Taxi("Z", Color.White);

            Taxi taxi3 = new Taxi("A", Color.Red, 1234, 1);

            taxi3.Patente = "B";



            Console.Read();
        }
    }
}
