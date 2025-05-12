using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases.Figuras
{
    internal class Cuadrado : FiguraGeometrica
    {
        #region Propiedades

        public float Lado { get; set; }

        #endregion

        #region Constructores

        public Cuadrado(int lado, int x, int y) : base(x, y)
        {
            this.Lado = lado;
        }

        #endregion


        #region Métodos

        public override float Area()
        {
            return Lado * Lado; 
            //Relación de asociación de tipo <use> Math.Pow(Lado, 2);
            //Se da cuando utilizamos servicios de otras clases dentro de un método
        }

        public override float Perimetro()
        {
            return Lado * 4;
        }

        public override string ToString()
        {
            return base.ToString() + $", Cuadrado - > Lado {Lado}";
        }

        #endregion
    }
}
