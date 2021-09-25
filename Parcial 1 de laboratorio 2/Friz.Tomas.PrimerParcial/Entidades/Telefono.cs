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
        private string estado;
        private double costo;

        private string[] id = new string[5]
        {
            "T01", "T02", "T03", "T04", "T05"
        };

        public Telefono()
        {
        }

        public Telefono(Tipo tipo, Marcas marca)
        {
            this.tipo = tipo;
            this.marca = marca;
        }

        public Telefono(Tipo tipo, Marcas marca, string estado) : this(tipo, marca)
        {
            this.estado = estado;
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

        public string Estado 
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }        
        }
    }
}
