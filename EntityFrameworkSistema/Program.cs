using System;
using BD;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityFrameworkSistema
{
    class Programa
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<AutosDbContext> db = new DbContextOptionsBuilder<AutosDbContext>();

            db.UseSqlServer("Server=ANGEL; Database=AutosDB; User=montes; Password=a; TrustServerCertificate=True;");
          
            bool repetir = false;
            int opcion = 0;
            do
            {

                Console.WriteLine("----------- Elige la opción ------------");
                Menu();
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Mostrar(db);
                        break;
                    case 2:
                       
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

        public static void Menu()
        {
            Console.WriteLine("\n ------------- Menu ------------");
            Console.WriteLine("1 Mostrar");
            Console.WriteLine("2 Agregar");
            Console.WriteLine("3 Editar");
            Console.WriteLine("4 Eliminar");
            Console.WriteLine("5 Salir");
        }

        public static void Mostrar(DbContextOptionsBuilder<AutosDbContext> conexion)
        {
            Console.Clear();
            Console.WriteLine("Carros en la BD");

            using (AutosDbContext context = new AutosDbContext(conexion.Options))
            {
                List<Auto> autos = (from aut in context.Autos
                                    //where aut.ModeloId == 1
                                    orderby aut.Precio descending
                                    select aut).Include(aut => aut.Modelo).ToList();

                foreach (Auto auto in autos)
                {
                    Console.WriteLine($"Auto {auto.Modelo.Nombre} Precio: {auto.Precio}");
                }
            }
        }
    }
}