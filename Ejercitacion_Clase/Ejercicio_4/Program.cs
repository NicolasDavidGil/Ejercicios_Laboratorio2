using System;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

                El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

                Escribir una aplicación que encuentre los 4 primeros números perfectos.
             */

            Console.WriteLine("Bienvenido");
            Console.WriteLine("Vamos a buscar los primeros 4 numeros perfectos.");
            Console.WriteLine("Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos, excluido el mismo, que son divisores del número.");
            Console.WriteLine("Empecemos...");


            int numeroParaAnalizar = 6; //Se de antemano que es el primer numero perfecto
            int sumaDeDivisores = 0;
            int contador = 0;

            do
            {
                for (int j = 1; j < numeroParaAnalizar; j++)
                {
                    if (numeroParaAnalizar % j == 0)
                    {
                        sumaDeDivisores += j;
                    }
                }
                if (sumaDeDivisores == numeroParaAnalizar)
                {
                    Console.WriteLine($"Numero perfecto {contador + 1}: {numeroParaAnalizar}");
                    contador++;
                }
                sumaDeDivisores = 0;
                numeroParaAnalizar++;
            } while (contador < 4);
        }
    }
}
