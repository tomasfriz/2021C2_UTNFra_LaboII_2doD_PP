using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public class ClientesCabina: Cliente
    {
        public ClientesCabina(int dni, string nombre, string apellido, int edad, string equipo) : base(dni, nombre, apellido, edad)
        {
            this.equipo = equipo;
            this.tipo = (Tipo)random.Next(0, 2);
            this.marca = (Marcas)random.Next(0, 2);
        }

        public Tipo Tipo
        {
            get
            {
                return tipo;
            }
        }
        public Marcas Marca
        {
            get
            {
                return marca;
            }
        }
    }
}
