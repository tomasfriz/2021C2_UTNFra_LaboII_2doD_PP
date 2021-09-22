using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Telefono
    {
        private Tipo tipo;
        private Marcas marca;
        private double costo;

        private string[] id = new string[5]
        {
            "T01", "T02", "T03", "T04", "T05"
        };

        public Telefono(Tipo tipo, Marcas marca, double costo)
        {
            this.tipo = tipo;
            this.marca = marca;
            this.costo = costo;
        }

        public string this[int index]
        {
            get
            {
                return id[index];
            }
            set
            {
                id[index] = value;
            }
        }
        public Tipo Tipo 
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
        public Marcas Marca 
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }
        public double Costo 
        {
            get
            {
                return costo;
            }
            set
            {
                costo = value;
            }
        }
    }
}
