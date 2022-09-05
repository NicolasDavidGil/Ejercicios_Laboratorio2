using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            double areaCuadrado;

            areaCuadrado = Math.Pow(longitudLado, 2);

            return areaCuadrado;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            double areaTriangulo;

            areaTriangulo = (baseTriangulo * altura) / 2;

            return areaTriangulo;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            double areaCirculo;

            areaCirculo = (3.1415 * radio) / 2;

            return areaCirculo;
        }
    }
}
