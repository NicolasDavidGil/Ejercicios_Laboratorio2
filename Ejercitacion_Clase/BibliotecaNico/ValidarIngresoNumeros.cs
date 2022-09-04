using System;

namespace BibliotecaNico
{
    public class ValidarIngresoNumeros
    {

        public static int PedirNumeroEntero(string mensaje)
        {
            string ingreso;
            int numeroIngresado = 0;
            bool validacionSalida = false;

            do
            {
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
                if (ValidarNumero(ingreso))
                {
                    numeroIngresado = int.Parse(ingreso);
                    validacionSalida = true;
                }
            } while (validacionSalida == false);

            return numeroIngresado;
        }

        public static int PedirNumeroEnteroEnRango(string mensaje, string mensajeError, int maximo, int minimo)
        {
            int numero;
            bool validacionSalida = false;

            do
            {
                numero = PedirNumeroEntero(mensaje);

                if (ValidadorMinMax.Validar(numero, maximo, minimo))
                {               
                    validacionSalida = true;
                }else
                {
                    Console.WriteLine("\n" + mensajeError + "\n");  
                }

            } while(validacionSalida == false);
            
            return numero;
        }

        public static float PedirNumeroFlotante(string mensaje)
        {
            string ingreso;
            float numeroIngresado = 0;      
            bool validacionSalida = false;

            do 
            {
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
                if(ValidarNumero(ingreso))
                {                    
                    numeroIngresado = float.Parse(ingreso);
                    validacionSalida = true;
                }
            }while(validacionSalida == false);

            return numeroIngresado;

        }

        public static float PedirNumeroFlotanteEnRango(string mensaje, string mensajeError, int maximo, int minimo)
        {
            float numero;
            bool validacionSalida = false;

            do
            {
                numero = PedirNumeroFlotante(mensaje);

                if (ValidadorMinMax.Validar(numero, maximo, minimo))
                {
                    validacionSalida = true;
                }
                else
                {
                    Console.WriteLine("\n" + mensajeError + "\n");
                }

            } while (validacionSalida == false);

            return numero;
        }


        private static bool ValidarNumero(string ingresoAValidar)
        {
            bool validacion;
            float numero;

            if (float.TryParse(ingresoAValidar, out numero))
            {
                validacion = true;
            }
            else
            {
                validacion=false;
            }

            return validacion;
        }
































    }
}
