using System;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
                El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
                Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
             */

            string ingresoConsola;
            int numeroIngresado;
            string respuestaSalida;
            int sumatoriaAntecesores = 0;
            int sumatoriaSucesores = 0;

            Console.WriteLine("Bienvenido.");
            Console.WriteLine("Vamos a calcular centros numericos entre 1 y el numero que desees.");

            do
            {
                Console.WriteLine("Ingrese el numero hasta el que desea calcular: ");
                ingresoConsola = Console.ReadLine();

                if(int.TryParse(ingresoConsola, out numeroIngresado))
                {
                    for(int i = 1; i <= numeroIngresado; i++)
                    {
                        for(int j = 0; j < i; j++)
                        {
                            sumatoriaAntecesores += j;
                        }          
                        for(int k = i + 1; k <= numeroIngresado; k++)
                        {
                            sumatoriaSucesores += k;
                        }
                        if(sumatoriaSucesores == sumatoriaAntecesores)
                        {
                            Console.WriteLine(i + " es un centro numerico.");                   
                        }
                        sumatoriaAntecesores = 0;
                        sumatoriaSucesores = 0;
                    }
                }else
                {
                    Console.WriteLine("Ingreso incorrecto.");
                }

                Console.WriteLine(Environment.NewLine + "Desea realizar otra operacion (si - no): ");
                respuestaSalida = Console.ReadLine();
                while(respuestaSalida != "si" && respuestaSalida != "no")
                {
                    Console.WriteLine("Error, reingrese soloo si o no: ");
                    respuestaSalida = Console.ReadLine();
                }
            } while (respuestaSalida != "no");       
        }
    }
}
