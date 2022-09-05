using System;
using BibliotecaNico;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

                El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

                public string ConvertirDecimalABinario(int numeroEntero) {}

                El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

                public int ConvertirBinarioADecimal(int numeroEntero) {}
             */
            int ingresoMenu;
            //string ingresoNumero = "";
            int numeroIngreso;
            string respuesta;

            Console.WriteLine("BIENVENIDO!");
            Console.WriteLine("Ingrese 1 para convertir un numero decimal a binario");
            Console.WriteLine("Ingrese 2 para convertir un numero de binario a decimal");            
            ingresoMenu = ValidarIngresoNumeros.PedirNumeroEnteroEnRango("Ingrese una opcion: ", "Ingreso incorrecto", 1, 2);

            if (ingresoMenu == 1)
            {
                numeroIngreso = ValidarIngresoNumeros.PedirNumeroEnteroEnRango("\nIngrese el numero decimal que desea convertir:", "Numero Incorrecto, solo numeros positivos", 1, int.MaxValue);
                respuesta = Conversor.ConvertirDecimalABinario(numeroIngreso);

                Console.WriteLine("El numero decimal: " + numeroIngreso);
                Console.WriteLine("Es en binario: " + respuesta);
            }
            else
            {
                numeroIngreso = ValidarIngresoNumeros.PedirNumeroEnteroEnRango("\n Ingres el numero binario que desea convertir: ", "Error", 1, int.MaxValue);
                numeroIngreso = Conversor.ConvertirBinarioADecimal(numeroIngreso);

                Console.WriteLine("Su numero binario en decimal es: " + numeroIngreso);
            }
        }

     

    }
}
