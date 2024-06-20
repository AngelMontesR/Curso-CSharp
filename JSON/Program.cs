using System;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerveza cerveza = new Cerveza
            {
                Marca = "Corona",
                Tipo = "Clara",
                Grados = 4.5
            };

            //La diagonal invertida se usa para escapar las comillas dobles
            string json = "["+
                    "{"+
                        "\"Marca\":\"Corona\","+
                        "\"Tipo\":\"Clara\","+
                        "\"Grados\":1.2"+
                    "}"+
                    "{"+
                        "\"Marca\":\"Modelo\","+
                        "\"Tipo\":\"Negra\","+
                        "\"Grados\":1.4"+
                    "}"+
                "]";

            Console.WriteLine(json);
        }
    }

    class Cerveza
    {
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public double Grados { get; set; }
    }
}