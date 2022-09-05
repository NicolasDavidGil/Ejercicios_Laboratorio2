using System;
using BibliotecaNico;

namespace Ejercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

                El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

                Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

                Mostrar el resultado en la consola.
             */

            double baseTriangulo;
            double alturaTriangulo;
            double hipotenusaTriangulo;


            Console.WriteLine("        BIENVENIDO!");

            baseTriangulo = ValidarIngresoNumeros.PedirNumeroFlotanteEnRango("Ingrese la base del triangulo: ", "Error, ingreso invalido.", 1, int.MaxValue);
            Console.WriteLine("\n");
            alturaTriangulo = ValidarIngresoNumeros.PedirNumeroFlotanteEnRango("Ingrese la altura del triangulo: ", "Error, ingreso invalido.", 1, int.MaxValue);
            Console.WriteLine("\n");

            baseTriangulo = Math.Pow(baseTriangulo, 2);
            alturaTriangulo = Math.Pow(alturaTriangulo, 2);

            hipotenusaTriangulo = baseTriangulo + alturaTriangulo;
            hipotenusaTriangulo = Math.Sqrt(hipotenusaTriangulo);

            Console.WriteLine("La longitud de su hipotenusa es: " + hipotenusaTriangulo);
        }
    }
}
