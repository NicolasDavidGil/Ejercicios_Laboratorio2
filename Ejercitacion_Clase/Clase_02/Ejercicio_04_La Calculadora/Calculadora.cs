using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Calculadora
    {
        public static float Calcular(float operandoUno, float operandoDos, char operacion)
        {
            float resultado = 0;

            switch(operacion)
            {
                case '+':
                    resultado = operandoDos + operandoUno;
                    break;
                case '-':
                    resultado = operandoUno - operandoDos;
                    break;
                case '*':
                    resultado = operandoUno * operandoDos;
                    break;
                case '/':
                    if(Validar(operandoDos))
                    {
                        resultado = operandoUno / operandoDos;
                    }
                    else
                    {
                        Console.WriteLine("\nError!! No se puede dividir por cero.");
                        resultado = operandoUno;                        
                    }
                    break;
            }
            return resultado;
        }


        private static bool Validar(float numero)
        {
            if(numero != 0)
            {
                return true;
            }
            return false;
        }

        public static char PedirOperacion(string mensaje)
        {
            char operacion;

            Console.WriteLine(mensaje);
            char.TryParse(Console.ReadLine(), out operacion);

            while(operacion != '+' && operacion != '-' && operacion != '/' && operacion != '*')
            {
                Console.WriteLine("Error, operando invalido" + mensaje);
                char.TryParse(Console.ReadLine(), out operacion);
            }

            return operacion;
        }
    }
}
