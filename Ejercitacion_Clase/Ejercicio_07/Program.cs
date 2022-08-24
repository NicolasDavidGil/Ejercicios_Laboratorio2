using System;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) 
             *  y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
                Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
                hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
                Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y 
                el total a cobrar neto de todos los empleados ingresados.
             */

            Empleado empleado1 = new Empleado();
            string respuestaSalida;
            int contador = 0;
            float gastoMensualEmpleados = 0;
            float gastoNetoMensual;

            Console.WriteLine("Bienvido!");

            do
            {                
                Console.WriteLine(Environment.NewLine + "Ingrese nombre de empleado: ");
                empleado1.nombreEmpleado = Console.ReadLine();

                Console.WriteLine(Environment.NewLine + "Ingrese el valor de la hora: ");
                empleado1.valorHoraEmpleado = float.Parse(Console.ReadLine());

                Console.WriteLine(Environment.NewLine + "Ingrese la antiguedad en años del empleado: ");
                empleado1.antiguedadEmpleado = int.Parse(Console.ReadLine());
               

                Console.WriteLine(Environment.NewLine + "Ingrese la cantidad de horas trabajadas en el mes: ");
                empleado1.cantidadHorasTrabajadas = int.Parse(Console.ReadLine());

                empleado1.totalHorasMes = empleado1.cantidadHorasTrabajadas * empleado1.valorHoraEmpleado;
                empleado1.valorAntiguedadMes = empleado1.antiguedadEmpleado * 150;
                empleado1.montoBrutoMes = empleado1.totalHorasMes + empleado1.valorAntiguedadMes;
                empleado1.montoNetoMes = empleado1.montoBrutoMes - (empleado1.montoBrutoMes * 13 / 100);

                Console.WriteLine(Environment.NewLine + "***************************************************************************");
                Console.WriteLine("Nombre empleado: " + empleado1.nombreEmpleado);
                Console.WriteLine("Antiguedad empleados: " + empleado1.antiguedadEmpleado + " años.");
                Console.WriteLine("Valor hora: " + empleado1.valorHoraEmpleado);
                Console.WriteLine("Total mensual en bruto: $" + empleado1.montoBrutoMes);
                Console.WriteLine("Total mensual neto a cobrar: $" + empleado1.montoNetoMes);
                Console.WriteLine("**************************************************************************************" + Environment.NewLine);

                contador++;
                gastoMensualEmpleados += empleado1.montoBrutoMes;

                Console.WriteLine(Environment.NewLine + "Desea ingresar otro empleado? (si - no): ");
                respuestaSalida = Console.ReadLine();
                while(respuestaSalida != "si" && respuestaSalida != "no")
                {
                    Console.WriteLine("Error, elija solo si o no: ");
                    respuestaSalida = Console.ReadLine();
                }

            } while (respuestaSalida == "si");

            gastoNetoMensual = gastoMensualEmpleados - (gastoMensualEmpleados * 13 / 100);

            Console.WriteLine(Environment.NewLine + "Se completo el ingreso de empleados.");
            Console.WriteLine("Se ingreso un total de " + contador + " empleados.");
            Console.WriteLine("El gasto total bruto en empleados es: " + gastoMensualEmpleados);
            Console.WriteLine("El gasto total neto es de: " + gastoNetoMensual);
        }
    }
}
