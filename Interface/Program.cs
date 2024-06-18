using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark[] tiburon = new Shark[]
            {
                new Shark("Tiburon Martillo", 50),
                new Shark("Tiburon Blanco", 60),
                new Shark("Tiburon Ballena", 40)
            };

            mostrarPescado(tiburon);
            animal(tiburon);
           
            Sirena sirena= new Sirena(30);
            Console.WriteLine(sirena.nadar());
        }
        
        public static void mostrarPescado(Shark[] Shark)
        {
            Console.WriteLine("Mostrar Peces");
            int i = 0;
            while (i < Shark.Length)
            {
                Console.WriteLine(Shark[i].nadar());
                i++;
            }
        }

        public static void animal(Animal[] animal)
        {
            Console.WriteLine("Estos son animales");
            int i = 0;
            while (i < animal.Length)
            {
                Console.WriteLine(animal[i].nombre);
                i++;
            }
        }


    }

    public class Sirena: Pescado
    {
        public int velocidad { get; set; }

        public Sirena(int velocidad)
        {
            this.velocidad = velocidad;
        }

        public string nadar()
        {
           return $"La sirena esta nadando {velocidad} km/hr";
        }
    }

    public class Shark: Animal, Pescado
    {
        public string nombre { get; set; }
        public int velocidad { get; set; }

        public Shark(string nombre,int velocidad)
        {
            this.nombre = nombre;
            this.velocidad = velocidad;
        }

        public string nadar()
        {
            return $"El tiburon {nombre} esta nadando a {velocidad} km/hr";
        }
    }

    public interface Animal
    {
        public string nombre { get; set; }
    }

    public interface Pescado
    {
        public int velocidad { get; set; }
        public string nadar();
    }
}