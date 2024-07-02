using System;
using System.IO;

namespace Excepciones
{
    class Ejecutar
    {
        static void Main(string[] args)
        {
            try
            {
                string contenidoURL = File.ReadAllText(@"C:\Users\Bioxor\x\pato.txt");
                Console.WriteLine(contenidoURL);

                throw new Exception("Ocurrio algo raro");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("No existe el archivo");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Sirve para cerrar excepciones, se ejecuta siempre, aunque no haya exceptions
                Console.WriteLine("Aqui me ejecuto pase lo que pase");
            }
            Console.WriteLine("Se sigue ejecutando");
        }
    }
}