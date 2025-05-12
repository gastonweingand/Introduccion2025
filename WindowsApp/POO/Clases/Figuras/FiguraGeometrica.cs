using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases.Figuras
{
    internal abstract class FiguraGeometrica
    {
        #region Propiedades
        public int X { get; set; }

        public int Y { get; set; }

        #endregion

        #region Constructores
        protected FiguraGeometrica(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        #endregion

        #region Métodos Abstractos

        /// <summary>
        /// Método que deberán implementar las clases hijas especificando cómo es el cálculo pertinente
        /// </summary>
        /// <returns>Valor del área de la figura geométrica</returns>
        public abstract float Area();

        public abstract float Perimetro();

        #endregion

        #region Métodos Concretos

        public override string ToString()
        {
            return $"X [{X}] : Y [{Y}]";
        }

        #endregion
    }
}
