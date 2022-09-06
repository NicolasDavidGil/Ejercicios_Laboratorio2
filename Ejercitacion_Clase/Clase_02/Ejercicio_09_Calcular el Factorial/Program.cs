using System;
using BibliotecaNico;

namespace Ejercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            El factorial de un número es una operación que consiste en multiplicar un numero “n” 
            por todos los números enteros positivos que estén debajo de él, 
            por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

            En una aplicación de consola, desarrollar un método estático que calcule el factorial de un 
            número dado.
             */

            int numeroIngresado;
            int resultadoFactorial;

            numeroIngresado = ValidarIngresoNumeros.PedirNumeroEnteroEnRango("Ingrese un numero: ", "Ingreso incorrecto. Solo numeros positivos.", 0, int.MaxValue);
            
            resultadoFactorial = CalcularFactorial(numeroIngresado);

            Console.WriteLine("El factorial de " + numeroIngresado + " es: " + resultadoFactorial);
        }

        static int CalcularFactorial(int numero)
        {
            int resultado = 1;

            for(int i = numero; i > 0; i--)
            {
                resultado *= i;
            }

            return resultado;
        }

    }
}
