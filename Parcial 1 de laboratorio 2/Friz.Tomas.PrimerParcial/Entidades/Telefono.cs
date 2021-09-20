using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Telefono
    {
        private string id;
        private Tipo tipo;
        private Marcas marca;
        private double costo;

        public Telefono(string id, Tipo tipo, Marcas marca, double costo)
        {
            this.id = id;
            this.tipo = tipo;
            this.marca = marca;
            this.costo = costo;
        }

        public string Id { get => id; set => id = value; }
        public Tipo Tipo { get => tipo; set => tipo = value; }
        public Marcas Marca { get => marca; set => marca = value; }
        public double Costo { get => costo; set => costo = value; }
    }
}
