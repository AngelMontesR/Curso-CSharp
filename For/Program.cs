using System;

namespace For
{
    class For
    {
        static void Main(string[] args)
        {
            string[] amigos = new string[3] {
                "Juan",
                "Pedro",
                "Pablo"
            };
                
            bool corre = true;
            for (int i = 0; i < amigos.Length && corre; i++)
            {
                Console.WriteLine(amigos[i]);
            }
        }
    }
}