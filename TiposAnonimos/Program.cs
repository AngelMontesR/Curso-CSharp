using System;

namespace TiposAnonimos
{
    class Empezar
    {
        static void Main(string[] args)
        {

            //Objeto anonimo , solo se puede leer , no se puede modificar
            var angel = new { 
                Name = "Angel",
                Ciudad = "Mexico"
            };

            Console.WriteLine(angel.Name);
            Console.WriteLine(angel.Ciudad);

            var gente = new[]
            {
                new {Nombre = "Juan"},
                new {Nombre = "Pepe"}
            };

            foreach (var item in gente)
            {
                Console.WriteLine($"Nombre: {item.Nombre}");
            }
        }
    }
}