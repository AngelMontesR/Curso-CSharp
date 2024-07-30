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
                            Editar(autoDB);
                            break;
                        case 4:
                            Eliminar(autoDB);
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
                Console.WriteLine($"Id Auto {o.idAuto} Id Modelo {o.idModelo} Precio {o.precio} Año {o.anio}");
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

        public static void Editar(AutosDB autosDB)
        {
            Console.Clear();
            Show(autosDB);
            Console.WriteLine("------ Editar Auto -------");
            Console.WriteLine("Elige el id del Auto a editar");
            int id = int.Parse(Console.ReadLine());
            Autos auto = autosDB.ObtenerAuto(id);
            if (auto != null)
            {
                Console.WriteLine("Escribe el Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Escribe el Año: ");
                int anio = int.Parse(Console.ReadLine());

                auto.precio = precio;
                auto.anio = anio;
                auto.idAuto = id;
                autosDB.Editar(auto);
            }
            else
            {
                Console.WriteLine("Ingresar Id de Auto");
            }
        }

        public static void Eliminar(AutosDB autosDB)
        {
            Console.Clear();
            Show(autosDB);
            Console.WriteLine("------ Eliminar Auto -------");
            Console.WriteLine("Elige el id del Auto a eliminar");
            int id = int.Parse(Console.ReadLine());
            autosDB.Eliminar(id);
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