using System;

namespace ClasesYObjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Las propiedades son metodos que se utilizan para acceder a los atributos de una clase,
            //pero se utilizan como si fueran atributos

            Sale sale = new Sale(10,DateTime.Now);
            sale.Total = -10;
            Console.WriteLine(sale.Total);
        }
    }

    class Sale
    {
        private int total;
        DateTime fecha;

        public int Total
        {
            get { 
                return total; 
            }
            set { 
                if(value < 0)
                {
                    total = 0;
                }
                else
                {
                    total = value;
                }
            }
        }

        public Sale(int total, DateTime fecha)
        {
            this.total = total;
            this.fecha = fecha;
        }
    }
}