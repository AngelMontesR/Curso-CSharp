using System;

namespace Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] amigos = new string[3];

            amigos[0] = "Juan";
            amigos[1] = "Pedro";
            amigos[2] = "Pablo";

            string[] amigos2 = new string[3] {
                "Juan", 
                "Pedro", 
                null
            };

            Console.WriteLine(amigos[0]);
            Console.WriteLine(amigos[1]);
            Console.WriteLine(amigos[2]);

            Console.WriteLine(amigos2[0]);
            Console.WriteLine(amigos2[1]);
            Console.WriteLine(amigos2[2]);

            amigos2[2] = "Pablo";

            Console.WriteLine(amigos2[2]);
        }
    }
}