using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int>()
            {
                1,2,3,4
            };

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            var list = new List<Persona>()
            {
                new Persona() {Nombre = "Luis",Ciudad = "Mexico" },
                new Persona() {Nombre = "Carlos", Ciudad = "Mexico" }
            };

            Ver(list);
            list.RemoveAt(0);
            Ver(list);
        }

        static void Ver(List<Persona> list)
        {
            Console.WriteLine("---- Personas -----");
            foreach (var persona in list)
            {
                Console.WriteLine($"Nombre: {persona.Nombre} Ciudad: {persona.Ciudad}");
            }
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
    }
}