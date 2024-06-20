using System;
using System.Text.Json;

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

            //Serializar un objeto a JSON , es decir convertir un objeto a un string en formato JSON
            string json2 = JsonSerializer.Serialize(cerveza);

            Console.WriteLine(json2);

            //Deserializar un JSON a un objeto, es decir convertir un string en formato JSON a un objeto,Dinamic es un tipo de dato que puede ser cualquier tipo de dato
            Cerveza cervecilla = JsonSerializer.Deserialize<Cerveza>(json2);

            Console.WriteLine(cervecilla);
        }
    }

    class Cerveza
    {
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public double Grados { get; set; }
    }
}