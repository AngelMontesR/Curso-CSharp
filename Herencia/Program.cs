using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("Pepe", 30,"Enfermero");
            Console.WriteLine(doctor.getData());

            Dev dev = new Dev("Juan", 30, "C#");
            Console.WriteLine(dev.getData());

        }
    }

    class Persona
    {
        private string _nombre;
        private int _edad;

        public Persona(string nombre, int edad)
        {
            this._nombre = nombre;
            this._edad = edad;
        }

        public string getInformacion()
        {
            return "Nombre: " + _nombre + " Edad: " + _edad;
        }
    }

    class Doctor : Persona
    {

        private string _especialidad;
       public Doctor(string nombre, int edad,string especialidad) : base(nombre, edad)
       {
            this._especialidad = especialidad;
       }

       public string getData()
       {
            return getInformacion() + " Especialidad: " + _especialidad;
       }
    }


    class Dev : Persona
    {

        private string _lenguaje;
        public Dev(string nombre, int edad, string lenguaje) : base(nombre, edad)
        {
            this._lenguaje = lenguaje;
        }

        public string getData()
        {
            return getInformacion() + " lenguaje: " + _lenguaje;
        }
    }
}