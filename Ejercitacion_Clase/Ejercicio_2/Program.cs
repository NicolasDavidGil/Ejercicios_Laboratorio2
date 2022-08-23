using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            //Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

            string numeroIngresado;
            float numeroParaOperar;
            float numeroCuadrado;
            float numeroCubo;
            bool validacionSalida = false;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresado = Console.ReadLine();

                if (float.TryParse(numeroIngresado, out numeroParaOperar))
                {
                    Console.WriteLine("Numero correcto. Iniciando operaciones...");

                    numeroCuadrado = numeroParaOperar * numeroParaOperar;
                    numeroCubo = numeroCuadrado * numeroParaOperar;

                    Console.WriteLine("Numero ingresado: " + numeroParaOperar);
                    Console.WriteLine("Cuadrado del numero: " + numeroCuadrado);
                    Console.WriteLine("Cubo del numero: " + numeroCubo);

                    validacionSalida = true;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            } while (validacionSalida == false);
        }
    }
}
