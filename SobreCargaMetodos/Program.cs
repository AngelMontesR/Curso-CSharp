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

            int[] numeros = new int[] {1,2,10};

            Console.WriteLine(operaciones.Sumar(numeros));

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

            public int Sumar(int[] numeros)
            {
                int resultado = 0;
                int contador = 0;

                while (contador < numeros.Length)
                {    
                    resultado = resultado + numeros[contador];
                    contador++;
                }

               return resultado;
            }

        }
    }

 }