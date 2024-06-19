using System;

namespace Generics
{
    class Program
    {

        //Generics es una forma de hacer que una clase o metodo pueda trabajar con cualquier tipo de dato
        static void Main(String[] args)
        {
            MiLista<int> lista = new MiLista<int>(3);
            lista.Agregar(1);
            lista.Agregar(2);
            Console.WriteLine(lista.MostrarElementos());

            MiLista<string> lista2 = new MiLista<string>(10);
            lista2.Agregar("Hola");
            lista2.Agregar("Mundo");
            Console.WriteLine(lista2.MostrarElementos());


        }
    }

    public class MiLista<T>
    {
        private T[] _elementos;
        private int _contador = 0;

            
        public MiLista(int capacidad)
        {
            _elementos = new T[capacidad];
        }

        public void Agregar(T Elemento)
        {
          if(_contador < _elementos.Length)
          {
              _elementos[_contador] = Elemento;
              _contador++;
          }
          else
          {
              Console.WriteLine("No hay espacio suficiente");
          }
        }

        public T ObtenerValor(int contador)
        {
            if(contador <= _elementos.Length && contador >=0)
            {
                return _elementos[contador];
            }
          
            return default(T);
        }

        public string MostrarElementos()
        {
            int i = 0;
            string resultado = "";
            while (i < _elementos.Length)
            {
                if(_elementos[i] != null)
                resultado += _elementos[i].ToString() + " ";
                i++;
            }
            return resultado;
        }
    }

 }