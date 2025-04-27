using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LLamando a una función por valor
            //Lo que se hace es enviar "UNA COPIA" del valor de la variable
            int nro1 = 100;
            Console.WriteLine($"Mostrando la variale antes de invocar a la función {nro1}");
            PorValor(nro1);
            Console.WriteLine($"Mostrando la variale luego de invocar a la función {nro1}");

            //LLamando a una función por referencia
            //Lo que se hace es enviar un puntero a la variable (Enviar la variable original)
            //CUIDADO!!!
            int nro2 = 100;
            Console.WriteLine($"Mostrando la variale antes de invocar a la función {nro2}");
            PorReferencia(ref nro2);
            Console.WriteLine($"Mostrando la variale luego de invocar a la función {nro2}");


            //Función: Agrupamiento de código (Reutilización)
            MostrarMensajeBienvenida();

            for (int i = 0; i < 50; i++)
            {
                MostrarMensaje($"Nro del interador: {i.ToString()}");
            }

            int nroA = 45;

            int nroB = 90;            

            int total;

            total = Sumar(nroA, nroB);

            Console.WriteLine($"La suma es {total}");

            Console.WriteLine(Sumar(1, 2));

            //Cálculo del área de un círculo

            Console.WriteLine("Por favor ingrese el radio del circulo en cm.");

            double radio = double.Parse(Console.ReadLine());

            double area = CalcularAreaCirculo(radio);

            Console.WriteLine($"El área del círculo es de {area.ToString("0.00")} cm2");
        }

        private static void PorValor(int a)
        {
            Console.WriteLine($"Mostrando el argumento recibido {a}");
            a = 500;
            Console.WriteLine($"Mostrando el argumento recibido {a} luego de modificarlo");
        }

        private static void PorReferencia(ref int a)
        {
            Console.WriteLine($"Mostrando el argumento recibido {a}");
            a = 500;
            Console.WriteLine($"Mostrando el argumento recibido {a} luego de modificarlo");
        }



        /// <summary>
        /// Función que recibe argumentos y retorna algo
        /// </summary>
        /// <param name="a">nro 1</param>
        /// <param name="b">nro 2</param>
        /// <returns>Total de la suma</returns>
        private static int Sumar(int a, int b) //Firma de la función
        {
            //Cuerpo de la función (Implementación)
            int total = 0;

            total = a + b;

            return total;
        }

        /// <summary>
        /// Función que solo retorno ALGO
        /// </summary>
        /// <returns>El valor de PI</returns>
        private static double GetPi()
        {
            return Math.PI;
        }

        /// <summary>
        /// Función que recibe argumentos y retorna algo
        /// </summary>
        /// <param name="radio">Argumento recibido</param>
        /// <returns>El cálculo del área</returns>
        private static double CalcularAreaCirculo(double radio)
        {
            return GetPi() * Math.Pow(radio, 2);
        }

        /// <summary>
        /// No recibe argumentos y no hay devolución
        /// </summary>
        private static void MostrarMensajeBienvenida()
        {
            Console.WriteLine("Bienvenidos a la programación");
        }

        /// <summary>
        /// Función que recibe argumentos pero no hay retorno
        /// </summary>
        /// <param name="texto">Texto a mostrar por pantalla</param>
        private static void MostrarMensaje(string texto)
        {
            Console.WriteLine(texto);
            Console.WriteLine("----------------------------");
        }
    }
}
