using System;
using System.Collections.Generic;
using System.Linq;

namespace JOIN
{
    class start
    {
        public static void Main(string[]args)
        {
            var cerveza = new List<Cerveza>()
            {
                new Cerveza()
                {
                    nombre = "Corona",
                    pais = "Mexico"
                },
                new Cerveza()
                {
                    nombre = "Modelo",
                    pais = "Francia"
                }
            };

            var pais = new List<Pais>()
            {
                new Pais()
                {
                    nombre = "Francia",
                    continente = "Europa"
                },
                new Pais()
                {
                    nombre = "Mexico",
                    continente = "America"
                }
            };

            var cervezasContinente = from cervezas in cerveza
                                     join paises in pais
                                     on cervezas.pais equals paises.nombre
                                     select new
                                     {
                                         NombreCerveza = cervezas.nombre,
                                         NombrePais = paises.nombre,
                                         NombreContinente = paises.continente,
                                     };

            foreach (var item in cervezasContinente)
            {
                Console.WriteLine($"Nombre Cerveza: {item.NombreCerveza} Pais: {item.NombrePais} Continente: {item.NombreContinente}");
            }
        }
    }

    class Cerveza
    {
        public string nombre {  get; set; }
        public string pais {  get; set; }
    }

    class Pais
    {
        public string nombre { get; set; }
        public string continente { get; set; }
    }
}