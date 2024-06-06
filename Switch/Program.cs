using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 1;

            switch (opcion)
            {
                   case 1:
                    Console.WriteLine("Opcion 1");
                    break;
                case 2:
                    Console.WriteLine("Opcion 2");
                    break;
                case 3:
                    Console.WriteLine("Opcion 3");
                    break;
                case < 0:
                case > 3:
                    Console.WriteLine("Opcion no valida");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}