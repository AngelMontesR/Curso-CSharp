using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Iteración " + i);
                i++;
            }

            int j = 0;
            while (j < 10)
            {
                if (j == 5)
                    break;

                Console.WriteLine("Iteración " + j);
                j++;
            }

            string[] amigos = new string[4];
            amigos[0] = "Juan";
            amigos[1] = "Pedro";
            amigos[2] = "Pablo";
            amigos[3] = "Carlos";

            int k = 0;
            while (k < amigos.Length)
            {
                Console.WriteLine(amigos[k]);
                k++;
            }

            bool corre = false;
            do
            {
                Console.WriteLine("Ejemplo");
            } while (corre);
        }
    }
}