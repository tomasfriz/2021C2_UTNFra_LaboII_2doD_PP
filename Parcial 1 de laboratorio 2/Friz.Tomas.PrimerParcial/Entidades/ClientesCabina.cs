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
        #region Constructores
        public ClientesCabina(int dni, string nombre, string apellido, int edad, string equipo) : base(dni, nombre, apellido, edad)
        {
            this.equipo = equipo;
            this.tipo = (Tipo)random.Next(0, 3);
            this.marca = (Marcas)random.Next(0, 3);
        }
        #endregion

        #region Encapsulamiento
        public int Dni
        {
            get
            {
                return dni;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
        }
        public string Equipo
        {
            get
            {
                return equipo;
            }
            set
            {
                equipo = value;
            }
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
        #endregion

        #region Operadores
        public override bool Equals(object obj)
        {
            return obj is ClientesCabina cabina &&
                   dni == cabina.dni &&
                   tipo == cabina.tipo &&
                   marca == cabina.marca;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(dni, tipo, marca);
        }

        public static bool operator ==(ClientesCabina left, ClientesCabina right)
        {
            return EqualityComparer<ClientesCabina>.Default.Equals(left, right);
        }

        public static bool operator !=(ClientesCabina left, ClientesCabina right)
        {
            return !(left == right);
        }
        #endregion
    }
}
