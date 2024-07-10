using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Start()
    {
        public static void Main(string[] args)
        {
            List<Cerveza> cervezas = new List<Cerveza>()
            {
                new Cerveza()
                {
                    Nombre =  "Clara",
                    Marca = "Corona"
                },
                new Cerveza()
                {
                    Nombre = "Oscura",
                    Marca = "Victoria"
                },
                new Cerveza()
                {
                    Nombre = "Angelito",
                    Marca = "XX"
                }
            };

            foreach (var item in cervezas)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("---------------------");

            //Select - Selecciona ciertos elementos de la lista
            var beersName = from listaCerveza in cervezas
                            select new
                            {
                                Nombre = listaCerveza.Nombre,
                                Marca = listaCerveza.Marca,
                                LongitudNombre = listaCerveza.Nombre.Length
                            };

            foreach (var item in beersName)
            {
                Console.WriteLine($"{item.Nombre} {item.LongitudNombre}");
            }


            //Filtrado - Filtra informacion de una lista como una tipo consulta
            Console.WriteLine("---------------------");
            var cervezaCorona = from listaCerveza in cervezas
                                where listaCerveza.Marca == "Victoria"
                                || listaCerveza.Marca == "Corona"
                                select listaCerveza;

            foreach (var corona in cervezaCorona)
            {
                Console.WriteLine(corona);
            }


            //Ordenar - informacion de una lista como una tipo consult
            Console.WriteLine("---------------------");
            var ordenaCerveza = from listaCerveza in cervezas
                                orderby listaCerveza.Marca descending
                                select listaCerveza;

            foreach (var item in ordenaCerveza)
            {
                Console.WriteLine(item);
            }


        }
    }

    public class Cerveza
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre} Marca: {Marca}";
        }
    }

}