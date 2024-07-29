using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class Autos
    {
        public int idAuto { get; set; }
        public int idModelo { get; set; }
        public decimal precio { get; set; }
        public int anio { get; set; }
        public Autos(int idAuto, int idModelo, decimal precio,int anio) 
        {
            this.idAuto = idAuto;
            this.idModelo = idModelo;
            this.precio = precio;
            this.anio = anio;
        }

        public Autos(int idModelo, decimal precio, int anio)
        {
            this.idModelo = idModelo;
            this.precio = precio;
            this.anio = anio;
        }

    }
}
