using System;
using BD;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkSistema
{
    class Programa
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<AutosDbContext> db = new DbContextOptionsBuilder<AutosDbContext>();

            db.UseSqlServer("Server=ANGEL; Database=AutosDB; User=montes; Password=a; TrustServerCertificate=True;");

            using(AutosDbContext context = new AutosDbContext(db.Options))
            {
                var autos = context.Autos.ToList();

                foreach (var item in autos)
                {
                    Console.WriteLine(item.Anio);
                }
            }
        }
    }
}