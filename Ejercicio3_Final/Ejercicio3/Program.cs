using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

            Validar que el dato ingresado por el usuario sea un número.

            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

            Si ingresa "salir", cerrar la consola.

            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola. 
             */

            string ingresoDelUsuario;
            int numeroIngresado;
            string opcionSalida;


            Console.WriteLine("Bienvenido!"); 
            do
            {
                Console.WriteLine("Ingrese un numero para operar: ");
                ingresoDelUsuario = Console.ReadLine();

                if(int.TryParse(ingresoDelUsuario, out numeroIngresado))
                {
                    Console.WriteLine("Numero ingresado: " + numeroIngresado);
                    Console.WriteLine("Imprimiendo numeros primos: ");
                    for(int i = 1; i < numeroIngresado; i++)
                    {
                        if(EsPrimo(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Desea repetir con otro numero: ");
                    opcionSalida = Console.ReadLine();
                    while(opcionSalida != "si" && opcionSalida != "no")
                    {
                        Console.WriteLine("Error ingresar (si) para continuar o (no) para salir: ");
                        opcionSalida = Console.ReadLine();
                    }
                    if(opcionSalida == "no")
                    {
                        ingresoDelUsuario = "salir";
                    }                 
                }
                else if(!int.TryParse(ingresoDelUsuario, out numeroIngresado))
                {
                    Console.WriteLine("Ingreso incorrecto!");
                }
            } while (ingresoDelUsuario != "salir");

            Console.WriteLine("Saliendo del programa.");
            System.Environment.Exit(0);
        }

        static bool EsPrimo(int numero)
        {
            for(int i = 2; i < numero; i++)
            {
                if(numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
