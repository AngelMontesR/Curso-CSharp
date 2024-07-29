using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BaseDatos
{
    class BaseDatos
    {
        static void Main(string[] args)
        {
            try
            {
                AutosDB autoDB = new AutosDB("ANGEL", "AutosDB", "angel", "a");

                bool repetir = true;
                int opcion = 0;

                do
                {
                    Menu();
                    Console.WriteLine("----------- Elige la opción ------------");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Show(autoDB);
                            break;
                        case 2:
                            Add(autoDB);
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            repetir = false;
                            break;
                    }
                } while (repetir);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Sin conexión"+ex.Message);
            }
        }

        public static void Show(AutosDB autosDB)
        {
            Console.Clear();
            Console.WriteLine("------ Registros de la BD -------");
            List<Autos> autos = autosDB.ObtenerTodos();

            foreach (Autos o in autos)
            {
                Console.WriteLine(o.anio);
            }
        }

        public static void Add(AutosDB autosDB)
        {
            Console.Clear();
            Console.WriteLine("------ Agregar Nuevo Auto -------");
            Console.WriteLine("Escribe Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el Año: ");
            int anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el Id del Modelo: ");
            int modelo = int.Parse(Console.ReadLine());

            Autos autos = new Autos(modelo, precio, anio);
            autosDB.Agregar(autos);
        }

        public static void Menu()
        {
            Console.WriteLine("\n ------------- Menu ------------");
            Console.WriteLine("1 Mostrar");
            Console.WriteLine("2 Agregar");
            Console.WriteLine("3 Editar");
            Console.WriteLine("4 Eliminar");
            Console.WriteLine("5 Salir");
        }
    }
}