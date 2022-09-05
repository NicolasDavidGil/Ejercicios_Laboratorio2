using System;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Escribir un programa que determine si un año es bisiesto.
                Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
                Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
             */


            string ingresoMinimoUsurio;
            string ingresoMaximoUsurio;
            int minimoIngresado;
            int maximoIngresado;

            Console.WriteLine("Bienvenido.");
            Console.WriteLine("Calculemos años bisiestos!!");

            Console.WriteLine(Environment.NewLine + "Ingrese el año inicial del calculo: ");
            ingresoMinimoUsurio = Console.ReadLine();
            while (!int.TryParse(ingresoMinimoUsurio, out minimoIngresado))
            {
                Console.WriteLine(Environment.NewLine + "Error, solo numeros enteros, reingrese: ");
                ingresoMinimoUsurio = Console.ReadLine();
            }

            Console.WriteLine(Environment.NewLine + "Ingrese el año final del calculo: ");
            ingresoMaximoUsurio = Console.ReadLine();
            while (!int.TryParse(ingresoMaximoUsurio, out maximoIngresado))
            {
                Console.WriteLine(Environment.NewLine + "Error, solo numeros enteros, reingrese: ");
                ingresoMaximoUsurio = Console.ReadLine();
            }
            Console.WriteLine(Environment.NewLine);
            for (int i = minimoIngresado; i <= maximoIngresado; i++)
            {
                if((i % 4 == 0 && i % 100 !=0) || (i % 100 == 0 && i % 400 == 0))
                {
                    Console.WriteLine(i + " es un año bisiesto.");
                }
            }
        }
    }
}
