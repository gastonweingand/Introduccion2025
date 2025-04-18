



using System;
using System.Collections.Generic;
using System.Linq;

namespace MiPrimerConsola
{
    public class Program
    {
        /// <summary>
        /// Punto de entrada a un programa en .NET
        /// </summary>
        /// <param name="args">Recibir argumentos desde la línea de comandos</param>
        static void Main(string[] args)
        {
            //EJERCICIOS SECUENCIALES
            //1) Dado el valor de la hora y la cantidad de horas trabajadas por un empleado, calcular su sueldo
            decimal valorHora;
            decimal horasTrabajadas;
            decimal sueldoTotal;

            Console.WriteLine("Por favor ingrese el valor de la hora de trabajo en $");

            //Condicional -> Evaluación sobre ciertas variables de un programa 
            //Comparación válidas: A > B, <, >=, <=, == (Iguales en comparaciones), != (Diferente)

            //if (decimal.TryParse(Console.ReadLine(), out valorHora) == true)
            if (decimal.TryParse(Console.ReadLine(), out valorHora)){ //Significa que pude convertir correctamente
                Console.WriteLine("Sí se pudo convertir el valor en algo decimal");
            }
            else
            {
                //No se pudo convertir correctamente
                Console.WriteLine("No se pudo convertir el valor ingresar por parte del usuario");
            }

            Console.WriteLine("Por favor ingrese la cantidad de horas trabajadas");
            horasTrabajadas = decimal.Parse(Console.ReadLine());
            sueldoTotal = valorHora * horasTrabajadas;
            
            Console.WriteLine($"El sueldo que le toca es $ {sueldoTotal}");

            //2) Ejercicio condicional múltiple
            //Dado el IMC ingresado por el usuario:
            //1) <18, infrapeso
            //2) >=18 y <=25 en peso
            //3) >25, sobrepreso

            //Pseint -> Flujogramas y pseucódigo (Solamente puedo resolver ejericio con IF anidados)
            //Excel = SI() Sí anidados

            //Ejemplo con SI anidado - NO RECOMENDABLE PARA NOSOTROS
            decimal imc;
            Console.WriteLine("Por favor ingrese el IMC");
            imc = decimal.Parse(Console.ReadLine());

            if (imc < 18)
            {
                Console.WriteLine("Usted tiene infrapeso");
            }
            else
            {
                if(imc <= 25)
                {
                    Console.WriteLine("Estás en peso normal");
                }
                else
                {
                    Console.WriteLine("Estás en sobpreso");
                }
            }

            //Ejemplo con condicional multimple if , else if, else
            if(imc < 18)
            {
                Console.WriteLine("Usted tiene infrapeso");
            }
            else if(imc <= 25)
            {
                Console.WriteLine("Estás en peso normal");
            }
            else if(imc <= 30)
            {
                Console.WriteLine("Estás un poco fuera de peso");
            }
            else
            {
                Console.WriteLine("Estás en sobrepeso");
            }

            //Operadores lógicos -> NOT (!), OR (||), AND (&&)

            if(imc > 18 && imc <= 25) //Ambas condiciones deben ser ciertas, para que todo sea cierto
            {
                Console.WriteLine("Usted tiene peso normal");
            }

            if(imc == 15 || imc == 16) //Con que una condición se cumpla, es cierto el IF
            {
                Console.WriteLine("CUIDADO! Estás muy abajo de peso");
            }

            if(!(imc > 30)) //Pensar como programadores, si no conviene invertir el signo de la comparación
                //Preguntar directamente if (imc <= 30)
            {
                //Console.WriteLine("Estás con demasiada obesidad");
                Console.WriteLine("Al menos sé que no estás con demasiada obesidad");
            }

            //switch-case
            //Condicional etiquetada/valores nomenclados

            //Se ingresan las horas trabajadas de un empleado y se las multiplica por su sueldo base
            //Para el sueldo base hay 3 categorías: 1)Operario = $2000, 2)Jefe = $2500, 3)Gerente = $3000

            int categoria = 0;
            int horasTrabajo = 0;
            int sueldo = 0;
            const int sueldoOperario = 2000;
            const int sueldoJefe = 2500;
            const int sueldoGerente = 3000;

            Console.WriteLine("Por favor ingrese la categoría del empleado. 1)Operario, 2)Jefe, 3, 4 o 5)Gerente.");
            categoria = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese las horas trabajadas");
            horasTrabajo = int.Parse(Console.ReadLine());

            switch (categoria)
            {

                case 1:
                    sueldo = horasTrabajo * sueldoOperario;
                    break;
                case 2:
                    sueldo = horasTrabajo * sueldoJefe;
                    break;
                case 3:
                case 4:
                case 5:
                    sueldo = horasTrabajo * sueldoGerente;
                    break;
                default:
                    Console.WriteLine("Lo que ingresó no es válido");
                    break;
            }

            Console.WriteLine($"El sueldo calculado es de $ {sueldo}");

            Console.WriteLine("Bienvenidos al curso de Programación");

            Console.WriteLine($"Recibo cantidad de argumentos {args.Length}");

            //Recorremos los argumentos que se reciben por proceso
            foreach (var elemento in args)
            {
                Console.WriteLine($"Elemento recibido: {elemento}");
            }            

            //Variables
            //Primitivas -> Value types
            int edad = 0;
            double dinero = 40000;
            float precio = 0.0f;
            char unCaracter = 'A';
            string cadena = "Con doble comillas";
            bool valorBoolean = default;

            Console.WriteLine($"Mostrando variables {edad}, {precio}, {valorBoolean}, {cadena}");

            Console.WriteLine("Ingrese un nuevo valor para nuestra cadena");

            //Capturo lo que el usuario ingrese por consola
            cadena = Console.ReadLine();

            Console.WriteLine($"Mostrando el nuevo valor de la variable cadena: {cadena}");

            //Variables de tipo Object -> Reference types
            DateTime fecha = DateTime.Now;

            Console.WriteLine($"Mostrando solamente mes y día {fecha.Month} {fecha.Year}");
            Console.WriteLine($"Formato de fecha dia-mes-año hora-minutos {fecha.ToString("dd/MM/yyyy HH:mm")}");
            Console.WriteLine($"Formato de fecha Mes-Dia {fecha.ToString("MM-dd")}");

            List<object> lista = new List<object>();

            lista.Add(fecha);
            lista.Add(dinero);
            lista.Add(precio);
            lista.Add(cadena);
            lista.Add(valorBoolean);
            lista.Add(unCaracter);

            foreach (var elemento in lista)
            {
                Console.WriteLine($"Variable en la lista: {elemento}");
            }

            List<string> cadenas = new List<string>();

            cadenas.Add("Imaginemos que esto en un prompt para chatGPT");
            cadenas.Add("Sos un experto en TI");
            cadenas.Add("Otra cosa...");

            foreach (var elemento in cadenas)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("Escribo una línea y agrega el fin de línea (ENTER)");
            Console.Write('H'); //Write es caracter a caracter o string pero no se pone el enter automático
            Console.Write('o');
            Console.Write('l');
            Console.Write('a');
            Console.WriteLine(); //Esta instrucción si no recibe nada hace el ENTER

            //Espero a que el usuario presione algo para finalizar mi programa
            Console.WriteLine("Presione una tecla para finalizar");
            //Tomamos cualquier caracter por parte del usuario
            Console.ReadKey();
        }
    }
}
