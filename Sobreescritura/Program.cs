using System;

namespace Sobreescritura
{
    class Program
    {
        static void Main(string[] args)
        {
            //La Sobreescritura de metodos es cuando se tienen dos metodos con el mismo nombre y la misma cantidad de parametros pero en diferentes clases
            
            B b = new B();
            b.Metodo();

            Venta venta = new Venta(3);
            venta.Agregar(10);
            venta.Agregar(20);
            venta.Agregar(30);
            Console.WriteLine(venta.Total());

            VentaImpuesto ventaImpuesto = new VentaImpuesto(3,1.16m);
            ventaImpuesto.Agregar(10);
            ventaImpuesto.Agregar(20);
            ventaImpuesto.Agregar(30);
            Console.WriteLine(ventaImpuesto.Total());
        }
    }

    public class A
    {
        public virtual void Metodo()
        {
            Console.WriteLine("Metodo de la clase A");
        }
    }

    public class B : A
    {
       public override void Metodo()
       {
            Console.WriteLine("Metodo de la clase B");
            base.Metodo();

       }
    }


    public class Venta
    {
        private decimal[] _amounts;
        private int _n;
        private int _end;

        public Venta(int n)
        {
            _amounts = new decimal[n];
            this._n = n;
            _end = 0;
        }

        public void Agregar(decimal amount)
        {
            if (_end < _n)
            {
                _amounts[_end] = amount;
                _end++;
            }
        }

        public virtual decimal Total()
        {
            decimal total = 0;
            int i = 0;
            while (i < _amounts.Length)
            {
                total += _amounts[i];
                i++;
            }

            return total;
        }


    }

    public class VentaImpuesto : Venta
    {

        private decimal _tax;
        //La base se utiliza para llamar el constructor de la clase base - padre (Venta) 
        public VentaImpuesto(int n,decimal tax): base(n)
        {
            this._tax = tax;
        }

        public override decimal Total()
        {
            return base.Total() * _tax;
        }

    }


}