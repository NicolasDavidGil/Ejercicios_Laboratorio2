using System;
using BibliotecaNico;

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

                public double CalcularAreaCuadrado(double longitudLado) {}

                public double CalcularAreaTriangulo(double base, double altura) {}

                public double CalcularAreaCirculo(double radio) {}

                El ingreso de los datos como la visualización se deberán realizar desde el método Main()
             */
            float ingresoUsuario;
            double retorno;
            char respuestaSalida;
            
            Console.WriteLine("      BIENVENIDO!");

            do
            {
                Console.WriteLine("1 - Para calcular area de un circulo.");
                Console.WriteLine("2 - Para calcular area de un Cuadradro");
                Console.WriteLine("2 - Para calcular area de un triangulo");
                ingresoUsuario = ValidarIngresoNumeros.PedirNumeroEnteroEnRango("Ingrese una opcion: ", "Error numero no valido", 1, 3);

                switch(ingresoUsuario)
                {
                    case 1:
                        float radio;                        
                        radio = ValidarIngresoNumeros.PedirNumeroFlotanteEnRango("Ingrese el radio del circulo: ", "Numero no valido", 1, int.MaxValue);
                        retorno = CalculadoraDeArea.CalcularAreaCirculo(radio);
                        Console.WriteLine("\nEl area del circulo es: " + retorno + "\n");
                        break;
                    case 2:
                        float lado;
                        lado = ValidarIngresoNumeros.PedirNumeroFlotanteEnRango("Ingrese el lado del cuadrado", "Ingreso no valido", 1, int.MaxValue);
                        retorno = CalculadoraDeArea.CalcularAreaCuadrado(lado);
                        Console.WriteLine("\nEl area del cuadrado es: " + retorno + "\n");
                        break;
                    case 3:
                        float baseTriangulo;
                        float alturaTriangulo;
                        baseTriangulo = ValidarIngresoNumeros.PedirNumeroFlotanteEnRango("Ingrese la base del triangulo:", "Ingreso no valido", 1, int.MaxValue);
                        alturaTriangulo = ValidarIngresoNumeros.PedirNumeroFlotanteEnRango("Ingrese la altura del triangulo:", "Ingreso no valido", 1, int.MaxValue);
                        retorno = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                        Console.WriteLine("\nEl area del triangulo es: " + retorno + "\n");
                        break;
                }

                respuestaSalida = ValidarIngresoString.PedirIngresoChar("\n S - Salir \nCualquier otro ingreso para reiniciar");

            }while(respuestaSalida != 'S');


        }
    }
}
