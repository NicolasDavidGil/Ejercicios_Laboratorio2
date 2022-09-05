using System;
using BibliotecaNico;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

                bool Validar(int valor, int min, int max)

                valor: dato a validar.
                min: mínimo valor incluido.
                max: máximo valor incluido.
                Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

                Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
             */

            string ingresoUsuario;
            int numeroIngresado;
            int minimoIngresado = int.MaxValue;
            int maximoIngresado = int.MinValue;
            float acumuladorIngresos = 0;
            int cantidadIngresos = 0;

            Console.WriteLine("Bienvenido" + Environment.NewLine);

            do
            {
                Console.WriteLine("Ingrese un numero entero entre -100 y 100: ");
                ingresoUsuario = Console.ReadLine();
                while (!int.TryParse(ingresoUsuario, out numeroIngresado))
                {
                    Console.WriteLine("Error, reingrese un numero entero entre -100 y 100: ");
                    ingresoUsuario = Console.ReadLine();
                }
                if(ValidadorMinMax.Validar(numeroIngresado, 100, -100))
                {
                    acumuladorIngresos += numeroIngresado;
                   
                    if(numeroIngresado > maximoIngresado)
                    {
                        maximoIngresado = numeroIngresado;
                    }
                    if(numeroIngresado < minimoIngresado)
                    {
                        minimoIngresado = numeroIngresado;
                    }
                    cantidadIngresos++;
                }
                else
                {
                    Console.WriteLine("Numero Ingresado fuera de rango." + Environment.NewLine);
                }               
            } while (cantidadIngresos < 10);

            acumuladorIngresos = acumuladorIngresos / (float)cantidadIngresos;

            Console.WriteLine(Environment.NewLine + "Se ha completado el ingreso.");
            Console.WriteLine("El numero maximo ingresado es: " + maximoIngresado);
            Console.WriteLine("El numero minimo ingresado es: " + minimoIngresado);
            Console.WriteLine("El promedio de los numeros ingresados es: " + acumuladorIngresos);
        }
    }
}
