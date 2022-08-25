using System;

namespace Ejercicio_09
{
    internal class Program
    {
        static void Main()
        {
            /*
             *  Escribir un programa que imprima por consola un triángulo como el siguiente:

                        *
                       ***
                      *****
                     *******
                    *********

                El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
             */

            string ingresoUsuario;
            int numeroIngresado;
            string dibujo = "*";
            string espaciado = " ";
            int cantidadEspaciado;
            int cantidadDibujos = 1;


            Console.WriteLine("Ingrese la altura que desea que tenga el triangulo(max 8): ");
            ingresoUsuario = Console.ReadLine();
            while(!int.TryParse(ingresoUsuario, out numeroIngresado))
            {
                Console.WriteLine("Error, ingrese solo numeros enteros: ");
                ingresoUsuario = Console.ReadLine();
            }

            cantidadEspaciado = numeroIngresado - 1;

            for (int j = 0; j < numeroIngresado; j++)
            {
                for (int i = 1; i <= cantidadEspaciado; i++)
                {
                    Console.Write(espaciado);                    
                }
                for(int k = 0; k < cantidadDibujos; k++)
                {
                    Console.Write(dibujo);
                }
                Console.WriteLine(Environment.NewLine);
                cantidadEspaciado -= 1;
                cantidadDibujos += 2;
            }
        }
    }
}
