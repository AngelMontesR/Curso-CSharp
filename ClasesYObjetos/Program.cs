using System;

namespace ClasesYObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
           Sale sale = new Sale(10,DateTime.Now);
           Console.WriteLine(sale.GetInfo());
        }
    }

    class Sale
    {
        int total;
        DateTime fecha;

        public Sale(int total,DateTime fecha)
        {
            this.total = total;
            this.fecha = fecha;
        }

        public string GetInfo()
        {
            return "Total: " + total + " Fecha: " + fecha.ToLongTimeString();
        }
        
       public void Show()
       {
           Console.WriteLine("Hola soy una venta ");
       }
    }
}