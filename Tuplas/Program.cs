using System;

namespace Tuplas
{
    class Empezar
    {
        static void Main(string[] args)
        {
            //Es una lista de variables de distinto tipo, si se puede editar sus valores

            (int id, string nombre) producto = (1, "Sudadera");
            Console.WriteLine($"Nombre: {producto.nombre} Id: {producto.id}");

            producto.nombre = "Pantalon";
            Console.WriteLine($"Nombre: {producto.nombre} Id: {producto.id}");

            //Se puede acceder por medio de los items
            var persona = (1, "Angel");
            Console.WriteLine($"Persona: {persona.Item2} Id:{persona.Item1}");

            //Se debe cumplir con la misma estructura para todos
            var muchaGente = new[]
            {
                (1,"Juan"),
                (2,"Pedro")
            };

            foreach (var gentilla in muchaGente)
            {
                Console.WriteLine($"Gente: {gentilla.Item2} Numero: {gentilla.Item1}");
            }

            //Duplas con indice
            (int id, string nombre)[] valores = new[]
            {
                (1,"Jose"),
                (2,"Luis")
            };

            foreach (var valor in valores)
            {
                Console.WriteLine($"Nombre: {valor.nombre} ID: {valor.id}");
            }

            Console.WriteLine($"Coordenadas {getCoordenadas().lat} {getCoordenadas().lon} Ciudad: {getCoordenadas().name}");

            //Ignorando valores
            var (_, longitud, _) = getCoordenadas();
            Console.WriteLine($"Logitud: {longitud}");
        }

        //Sirve para poder retornar varios valores
        //tipo de acceso , return , dupla , nombre de funcion , parametros
        public static (float lat, float lon,string name) getCoordenadas()
        {
            return (1, 2, "CDMX");
        }

    }

}