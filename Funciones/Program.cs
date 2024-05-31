using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            int numero2 = 20;

            int resultado = numero1 + numero2;

            Mostrar();
            Sumar(numero1, numero2);

            int resultadoMultiplicacion = Multiplicar(numero1, numero2);

            Console.WriteLine("El resultado de la multiplicacion: " + resultadoMultiplicacion);
        }

        static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
            
        static void Sumar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            Console.WriteLine("El resultado: " + resultado);
        }

        static void Mostrar()
        {
            Console.WriteLine("Hola soy un texto");
        }

    }
}