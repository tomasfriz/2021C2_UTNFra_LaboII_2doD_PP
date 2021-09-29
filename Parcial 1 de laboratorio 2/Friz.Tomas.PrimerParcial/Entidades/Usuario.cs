using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario : Cliente
    {
        #region Constructor
        protected Usuario(int dni, string nombre, string apellido, int edad) : base(dni, nombre, apellido, edad)
        {

        }
        #endregion

        #region Operadores
        public override bool Equals(object obj)
        {
            return obj is Usuario usuario &&
                   dni == usuario.dni &&
                   periferico == usuario.periferico &&
                   hardware == usuario.hardware &&
                   software == usuario.software &&
                   juego == usuario.juego &&
                   tipo == usuario.tipo &&
                   marca == usuario.marca;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(dni, periferico, hardware, software, juego, tipo, marca);
        }

        public static bool operator ==(Usuario left, Usuario right)
        {
            return EqualityComparer<Usuario>.Default.Equals(left, right);
        }

        public static bool operator !=(Usuario left, Usuario right)
        {
            return !(left == right);
        }
        #endregion
    }
}
