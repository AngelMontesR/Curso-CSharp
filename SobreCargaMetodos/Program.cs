using System;

namespace SobreCargaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //La SobreCarga de metodos es cuando se tienen dos metodos con el mismo nombre pero con diferente cantidad de parametros

            Operaciones operaciones = new Operaciones();
            Console.WriteLine(operaciones.Sumar(1,2,3));

        }

        class Operaciones
        {
            public int Sumar(int a, int b)
            {
                return a + b;
            }

            public int Sumar(int a, int b, int c)
            {
                return a + b + c;
            }

        }
    }

 }