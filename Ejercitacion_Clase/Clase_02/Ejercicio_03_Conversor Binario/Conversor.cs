using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            int iteracion = numeroEntero;            
            string numeroBinario = "";
            StringBuilder numeroBinarioFinal = new StringBuilder();

            do
            {               
                if(iteracion %2 == 0)
                {
                    numeroBinario += "0";                    
                    iteracion /= 2;
                }
                else
                {
                    numeroBinario += "1";                    
                    iteracion /= 2;
                }
            } while (iteracion > 0);

            for(int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                numeroBinarioFinal.Append(numeroBinario[i]);
            }
            return numeroBinarioFinal.ToString();
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string arrayBinario;            
            int numero;
            int potencia;
            int numeroDecimal = 0;

            arrayBinario = numeroEntero.ToString();
            potencia = arrayBinario.Length - 1;

            for(int i = 0; i < arrayBinario.Length; i++)
            {
                numero = int.Parse(arrayBinario[i].ToString());
                if(numero == 1)
                {
                    numeroDecimal += (int)Math.Pow(2, potencia);
                }
                potencia--;
            }

            return numeroDecimal;
        }
    }
}
