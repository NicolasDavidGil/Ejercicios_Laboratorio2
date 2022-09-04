using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNico
{
    public class ValidarIngresoString
    {
        public static string PedirIngresoString(string mensaje)
        {
            string ingresoUsuario;
            bool validacionLetra;

            do
            {
                Console.WriteLine(mensaje);
                ingresoUsuario = Console.ReadLine();

                validacionLetra = ValidarLetra(ingresoUsuario); 

                if(validacionLetra == false)
                {
                    Console.WriteLine("\nError, ingreso incorrecto.");
                }
            } while (validacionLetra == false);

            return ingresoUsuario;  
        }

        public static string PedirIngresoStringConNumeros(string mensaje)
        {
            string ingresoUsuario;
            bool validacionLetra;

            do
            {
                Console.WriteLine(mensaje);
                ingresoUsuario = Console.ReadLine();

                validacionLetra = ValidarNumeroYLetra(ingresoUsuario);

                if (validacionLetra == false)
                {
                    Console.WriteLine("\nError, ingreso incorrecto.");
                }
            } while (validacionLetra == false);

            return ingresoUsuario;
        }

        public static char PedirIngresoChar(string mensaje)
        {
            string ingresoUsuarioStr;
            char ingresoUsuario = ' ';
            bool isValidacionLetra = false;

            do
            {
                Console.WriteLine(mensaje);
                ingresoUsuarioStr = Console.ReadLine();
                ingresoUsuarioStr = ingresoUsuarioStr.ToUpper();

                if(ValidarLetra(ingresoUsuarioStr))
                {
                    char.TryParse(ingresoUsuarioStr, out ingresoUsuario);
                    isValidacionLetra = true;
                }
                else
                {
                    Console.WriteLine("\n Error, ingreso inválido, solo se admiten letras.");
                }
            } while (isValidacionLetra == false);

           
            return ingresoUsuario;
        }

        private static bool ValidarLetra(string cadena)
        {
            bool validacionLetra = true;    

            for (int i = 0; i < cadena.Length; i++)
            {
                if (!char.IsLetter(cadena[i]))
                {
                    validacionLetra = false;
                    break;
                }
            }

            return validacionLetra;
        }

        private static bool ValidarNumeroYLetra(string cadena)
        {
            bool validacionLetra = true;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (!char.IsLetter(cadena[i]) || !char.IsDigit(cadena[i]))
                {
                    validacionLetra = false;
                    break;
                }
            }
            return validacionLetra;
        }

    }
}
