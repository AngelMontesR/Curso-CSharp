using System;

namespace TipoDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroInt = 10; // Es un numero que no tiene decimales
            double numeroDouble = 20; // Es un numero que tiene decimales
            char letra = 'B'; // Es un caracter, se debe hacer con comillas simples por que es un solo caracter si no se hace con comillas dobles se considera un string
            string palabra = "Hola"; // Es una cadena de caracteres, se debe hacer con comillas dobles
            bool esVerdadero = true; // Es un valor booleano, solo puede ser verdadero o falso


            Console.WriteLine("numeroInt: " + numeroInt);
            Console.WriteLine("numeroDouble: " + numeroDouble);
            Console.WriteLine("Letra: " + letra);
            Console.WriteLine("Palabra: " + palabra);
            Console.WriteLine("Es verdadero: " + esVerdadero);
        }
    }
}