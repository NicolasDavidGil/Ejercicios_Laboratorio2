using System;
using BibliotecaNico;

namespace Ejercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

                Pedir por consola la fecha de nacimiento de una persona (día, mes y año) 
                y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

                Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
             */

            

            FechaNacimiento fechaNacimiento = new FechaNacimiento();            

            DateTime dateTime = DateTime.Now;                       

            Console.WriteLine("Bienvenido!\n Ingresemos su fecha de nacimiento.\n");
            
            fechaNacimiento.diaNacimiento = ValidarIngresoNumeros.PedirNumeroEnteroEnRango("\nIngrese el día de su nacimiento: ", "Error, día no válido.", 1, 31);
            fechaNacimiento.mesNacimiento = ValidarIngresoNumeros.PedirNumeroEnteroEnRango("\nIngrese el mes de su nacimiento: ", "Error, mes no válido.", 1, 12);
            fechaNacimiento.añoNacimiento = ValidarIngresoNumeros.PedirNumeroEnteroEnRango("\nIngrese el año de su nacimiento: ", "Error, año no válido.", -10000, 2022);

            DateTime nacimiento = new DateTime(fechaNacimiento.añoNacimiento, fechaNacimiento.mesNacimiento, fechaNacimiento.diaNacimiento);                                                                

            Console.WriteLine("Usted a vivido un total de: " + (dateTime - nacimiento).Days + " días.");


            
        }
    }
}
