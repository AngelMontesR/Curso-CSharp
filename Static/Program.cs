using System;

namespace Static
{
    class Program
    {
        //La palabra clave static se utiliza para declarar un miembro estatico, lo que significa que pertenece a la clase en lugar de a una instancia de la clase
        static void Main(string[] args)
        {
            Persona persona = new Persona()
            {
                Nombre = "Juan",
                Edad = 30
            };

            Persona persona2 = new Persona()
            {
                Nombre = "Luis",
                Edad = 30
            };

            Console.WriteLine(Persona.Contador());
        }
    }


    //Al crear una clase estatica, todos los miembros de la clase deben ser estaticos
    public static class  A
    {
        public static void Algo()
        {

        }
    }

    //Solo se pueden crear clases estaticas , propiedades estaticas y metodos estaticos, parametros no se pueden declarar como estaticos
    public class Persona
    {
        public string Nombre { get; set; }
        public  int Edad { get; set; }

        public static int Count = 0;

        public Persona()
        {
            Count++;
        }


        //El constructor estatico se ejecuta una sola vez cuando se crea la primera instancia de la clase
        //Se puede concatenar cadenas de texto con el signo + o con el signo $ y colocando la variable entre llaves
        public static string Contador()
        {
            return $"El contador es: {Count}";
        }
    }
}