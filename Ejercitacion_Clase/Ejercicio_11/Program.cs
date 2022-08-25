using System;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

                Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

                El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
             */
            string respuestaIteracion;
            string ingresoUsuario;
            int numeroIngresado;
            int acumuladorIngresos = 0;
            int contadorIngresos = 1;

            Console.WriteLine("Bienvenido" + Environment.NewLine);

            do
            {
                Console.WriteLine("Ingrese numero " + contadorIngresos + ": ");
                ingresoUsuario = Console.ReadLine();
                if(Validador(ingresoUsuario))
                {
                    numeroIngresado = Convert.ToInt32(ingresoUsuario);  
                    contadorIngresos++;
                    acumuladorIngresos += numeroIngresado;
                }else
                {
                    Console.WriteLine(Environment.NewLine + "Ingreso incorrecto, solo numeros enteros." + Environment.NewLine);
                }

                Console.WriteLine("Desea ingresar otro numero?" + Environment.NewLine + "S para repetir." + Environment.NewLine + "Cualquier otro ingreso para salir");
                respuestaIteracion = Console.ReadLine();
                respuestaIteracion = respuestaIteracion.ToUpper();

            } while (respuestaIteracion == "S");

            contadorIngresos -= 1;

            Console.WriteLine("Se han realizado un total de " + contadorIngresos + " ingresos.");
            Console.WriteLine("La suma total de los ingresos realizados es: " + acumuladorIngresos);
        }

        static bool Validador(string cadena)
        {
            bool retorno;
            int numero;

            if(int.TryParse(cadena, out numero))
            {
                return true;
            }
            else
            {
                retorno = false;    
            }
            return retorno;
        }

        static bool ValidarRespuesta(string cadena)
        {
            bool retorno;

            if(cadena == "S")
            {
                retorno = true;
            }
            else
            {
                retorno =false;
            }

            return retorno;
        }
    }
}
