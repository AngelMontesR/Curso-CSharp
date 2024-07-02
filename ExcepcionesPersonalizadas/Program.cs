using System;


namespace ExcepcionesPersonalizadas
{
    class Ejecutar
    {
        static void Main(string[] args)
        {
            try
            {
                Cerveza cerveza = new Cerveza()
                {
                    Nombre = "Blanca",
                    Marca = "Angel"
                };

                Console.WriteLine(cerveza);
            }
            catch (ExceptionCerveza ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    } 

    class ExceptionCerveza : Exception
    {
        public ExceptionCerveza():base("La Cerveza no tiene nombre o marca.")
        {

        }
    }

    class Cerveza
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public override string ToString()
        {
            if (Nombre == null || Marca == null)
            {
                throw new ExceptionCerveza();
            }
            return $"Cerveza: {Nombre} Marca: {Marca}";
        }
    }
}