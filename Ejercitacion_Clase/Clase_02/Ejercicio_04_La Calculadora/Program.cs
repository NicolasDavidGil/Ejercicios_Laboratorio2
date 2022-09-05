using System;
using BibliotecaNico;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

                Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

                Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

                Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

                Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

                El usuario decidirá cuándo finalizar el programa.
            */
            float numeroUno;
            float numeroDos;
            float resultado;
            char respuesta;
            char operacion;

            Console.WriteLine("BIENVENIDOS");

            do
            {

                numeroUno = ValidarIngresoNumeros.PedirNumeroFlotante("Ingrese el primer numero: ");
                operacion = Calculadora.PedirOperacion("(* / - +)");
                numeroDos = ValidarIngresoNumeros.PedirNumeroFlotante("Ingrese el segundo numero: ");

                resultado = Calculadora.Calcular(numeroUno, numeroDos, operacion);

                if (operacion == '/' && numeroDos == 0)  
                {
                    Console.WriteLine("\n");    
                }
                else
                {
                    Console.WriteLine("\n" + numeroUno + " " + operacion + " " + numeroDos + " es igual a: " + resultado);
                }

                respuesta = ValidarIngresoString.PedirIngresoChar("S - Salir \nCualquier ingreso distinto continuar.");

            }while(respuesta != 'S');





        }
    }
}
