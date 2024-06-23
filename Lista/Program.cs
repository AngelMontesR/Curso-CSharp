using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(String[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);

            Console.WriteLine("Numeros 1: "+numbers.Count);

            List<int> numbers2 = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            Console.WriteLine(numbers2.Count);

            numbers.Clear();

            Console.WriteLine("Numeros 1: " + numbers.Count);

            List<string> ciudades = new List<string>()
            {
                "CDMX", "Guadalajara", "Monterrey"
            };

            ciudades.Add("Puebla");

            Console.WriteLine("Ciudades: "+ ciudades.Count);
        }
    }
}