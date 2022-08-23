using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string nombre;

            nombre = "Nicolas";

            string edadIngresada = Console.ReadLine();

            int edad = int.Parse(edadIngresada);



            bool resultado = int.TryParse(edadIngresada, out edad);

            if(resultado)
            {
                Console.WriteLine("Hola {0} {2}su edad es: {1}", nombre, edad, Environment.NewLine);
            }
            else
            {
                Console.WriteLine("error en el dato");
            }
                */
            //Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.


            string? numeroIngresado;
            int numeroIterando;
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            float acumuladorIngresos = 0;
            int contadorIngresos = 0;
            bool checkNumero;

            do
            {
                Console.WriteLine("Ingrese un numero entero: ");
                numeroIngresado = Console.ReadLine();
                checkNumero = int.TryParse(numeroIngresado, out numeroIterando);
                if (checkNumero)
                {
                    acumuladorIngresos += (float)numeroIterando;

                    if (numeroIterando > maxNum)
                    {
                        maxNum = numeroIterando;
                    }
                    if (numeroIterando < minNum)
                    {
                        minNum = numeroIterando;
                    }

                    contadorIngresos++;
                }
                else
                {
                    Console.WriteLine("Ingreso incorrecto, solo numeros enteros.");
                }

            } while (contadorIngresos < 5);

            acumuladorIngresos = acumuladorIngresos / contadorIngresos;

            Console.WriteLine("El numero maximo es: " + maxNum + " , el minimo es: " + minNum + " y  el promedio es: " + acumuladorIngresos);
        }
    }
}
