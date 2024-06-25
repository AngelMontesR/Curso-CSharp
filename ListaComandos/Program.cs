using System;
using System.Collections.Generic;

namespace ListaComandos
{
    class Ejecutar
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                1,2,3,5
            };

            Show(numeros);

            //Insert sirve para insertar algun registro en la posición deseada
            numeros.Insert(0,6);
            Show(numeros);

            //Revisar si nuestra lista contiene con algun elemento a buscar
            if (numeros.Contains(22))
            {
                Console.WriteLine("Existe");
            }
            else
            {
                Console.WriteLine("No Existe");
            }

            //IndexOf, para obtener la posicion del elemento a buscar
            int posicion = numeros.IndexOf(20);
            Console.WriteLine($"Posicion: {posicion}");

            //Sort Para ordenar elementos,esta propiedad es mutable , es decir afecta al mismo objeto
            numeros.Sort();
            Show(numeros);

            //Inmutable
            string name = "Angel";
            name = name.ToUpper();
            Console.WriteLine(name);

            //Add Range, Agrega una lista del mismo tipo
            var listaDos = new List<int>()
            {
                900,500,32000
            };
            numeros.AddRange(listaDos);

            Show(numeros);
        }


        public static void Show(List<int> numeros)
        {
            Console.WriteLine("-------- Numeros ----------");
            foreach (var numero in numeros){
                Console.WriteLine($"Numero: {numero}");
            }
        }

    }


}