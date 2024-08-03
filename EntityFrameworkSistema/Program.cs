using BD;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkSistema
{
    class Programa
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<AutosDbContext> db = new DbContextOptionsBuilder<AutosDbContext>();

            db.UseSqlServer("Server=ANGEL; Database=AutosDB; User=montes; Password=a; TrustServerCertificate=True;");

            bool repetir = true;
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
                        Agregar(db);
                        break;
                    case 3:
                        Editar(db);
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

        public static void Agregar(DbContextOptionsBuilder<AutosDbContext> conexion)
        {
            Console.Clear();
            Console.WriteLine("------ Agregar Nuevo Auto -------");
            Console.WriteLine("Escribe Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el Año: ");
            int anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el Id del Modelo: ");
            int modelo = int.Parse(Console.ReadLine());


            using (AutosDbContext context = new AutosDbContext(conexion.Options))
            {
                Auto auto = new Auto();
                auto.Precio = precio;
                auto.Anio = anio;
                auto.ModeloId = modelo;
                context.Add(auto);
                context.SaveChanges();
            }
        }

        public static void Editar(DbContextOptionsBuilder<AutosDbContext> conexion)
        {
            Console.Clear();
            Mostrar(conexion);
            Console.WriteLine("------ Editar Auto -------");
            Console.WriteLine("Elige el id del Auto a editar");
            int id = int.Parse(Console.ReadLine());

            using (AutosDbContext context = new AutosDbContext(conexion.Options))
            {
                Auto autoEdit = context.Autos.Find(id);
                if(autoEdit != null)
                {
                    Console.WriteLine("Escribe el Precio: ");
                    decimal precio = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Escribe el Año: ");
                    int anio = int.Parse(Console.ReadLine());

                    autoEdit.Precio = precio;
                    autoEdit.Anio = anio;
                    context.Entry(autoEdit).State = EntityState.Modified;
                    context.SaveChanges();
                }  
                else
                {
                    Console.WriteLine("Ingresar Id de Auto");
                }
            }
        }
    }
}