using POO.Clases.Composicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases.Agregacion
{
    internal class Cliente
    {
        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        //Agregación
        public TarjetaCredito TarjetaCredito { get; set; }

        //Composición ->Debe exisitir un objeto dirección para que un cliente exista
        public Direccion Direccion { get; set; }

        public Cliente(int Codigo, string Nombre, DateTime FechaNacimiento, Direccion direccion)
        {
            if (direccion == null)
                throw new ArgumentNullException("No se puede crear un cliente sin dirección");

            this.Direccion = direccion;
            this.Nombre = Nombre;
            this.Codigo = Codigo;
            this.FechaNacimiento = FechaNacimiento;
        }

        public override string ToString()
        {
            //Puedo o no tener datos de tarjeta, porque es opcional
            string datosTarjeta = (TarjetaCredito != null) ? $"Numero {TarjetaCredito.Numero}" : "";
            //Dirección al ser composición siempre existe
            string datosDireccion = $"Dirección: Calle {Direccion.Calle} {Direccion.Numero}";

            return $"Nombre cliente: {Nombre}, Tarjeta de crédito: {datosTarjeta}, Dirección: {datosDireccion}";
        }
    }
}
