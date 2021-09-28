using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario : Cliente
    {
        //Aun no esta terminada esta clase.
        protected Usuario(int dni, string nombre, string apellido, int edad) : base(dni, nombre, apellido, edad)
        {

        }

    }
}
