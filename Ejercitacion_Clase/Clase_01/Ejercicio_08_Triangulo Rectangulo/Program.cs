using System;

namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escribir un programa que imprima por consola un triángulo como el siguiente:

                *
                ***
                *****
                *******
                *********
                El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5
             */

            string ingresoUsuario;
            int numeroIngresado;
            string dibujando = "*";
            int contador = 1;

            Console.WriteLine("Ingrese la cantidad de filas que desea dibujar: ");
            ingresoUsuario = Console.ReadLine();
            while(!int.TryParse(ingresoUsuario, out numeroIngresado))
            {
                Console.WriteLine("Error, solo numeros enteros: ");
                ingresoUsuario = Console.ReadLine();
            }

            for (int i = 0; i < numeroIngresado; i++)
            {
                Console.WriteLine(Environment.NewLine);
                for (int j = 1; j <= contador; j++)
                 {
                    Console.Write(dibujando);                                  
                 }
                
                contador += 2;
            }       
        }

    }
}
