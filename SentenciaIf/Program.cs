using System;

namespace SentenciaIf
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tienesHambre = true;
            bool tienesDinero = true;

            if (tienesHambre && tienesDinero && EstaAbiertoRestaurante("Loches pepe", 9))
            {
                Console.WriteLine("Come");
            }
            else
            {
                Console.WriteLine("No comas");
            }
        }

        static bool EstaAbiertoRestaurante(string nombre,int hora = 0)
        {
            if(nombre == "Loches pepe" && hora > 8 && hora < 23)
            {
                return true;
            }
            else if(nombre == "Restaurant 24 horas")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}