using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases.Figuras
{
    internal class Rectangulo : FiguraGeometrica
    {
        #region Propiedades

        public float Base { get; set; }

        public float Altura { get; set; }


        #endregion

        #region Constructores

        public Rectangulo(int lbase, int altura, int x, int y) : base(x , y)
        {
            this.Base = lbase;
            this.Altura = altura;
        }

        #endregion


        #region Métodos

        public override float Area()
        {
            return Base * Altura; 
        }

        public override float Perimetro()
        {
            return (Base * 2) + (Altura * 2);
        }

        public override string ToString()
        {
            return base.ToString() + $", Rectángulo - > Base: {Base}, Altura: {Altura}";
        }

        #endregion
    }
}
