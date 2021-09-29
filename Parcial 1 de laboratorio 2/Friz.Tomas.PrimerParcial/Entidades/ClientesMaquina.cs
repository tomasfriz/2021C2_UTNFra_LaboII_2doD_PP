using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public class ClientesMaquina : Cliente
    {
        #region Constructor
        public ClientesMaquina(int dni, string nombre, string apellido, int edad, string equipo) : base(dni, nombre, apellido, edad)
        {
            this.equipo = equipo;
            this.periferico = (Periferico)random.Next(0, 4);
            this.hardware = (Hardware)random.Next(0, 4);
            this.software = (Software)random.Next(0, 5);
            this.juego = (Juego)random.Next(0, 7);
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
        public Periferico Periferico
        {
            get
            {
                return periferico;
            }
        }
        public Hardware Hardware
        {
            get
            {
                return hardware;
            }
        }
        public Software Software
        {
            get
            {
                return software;
            }
        }
        public Juego Juego
        {
            get
            {
                return juego;
            }
        }
        #endregion

        #region Operadores
        public override bool Equals(object obj)
        {
            return obj is ClientesMaquina maquina &&
                   dni == maquina.dni &&
                   periferico == maquina.periferico &&
                   hardware == maquina.hardware &&
                   software == maquina.software &&
                   juego == maquina.juego;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(dni, periferico, hardware, software, juego);
        }

        public static bool operator ==(ClientesMaquina left, ClientesMaquina right)
        {
            return EqualityComparer<ClientesMaquina>.Default.Equals(left, right);
        }

        public static bool operator !=(ClientesMaquina left, ClientesMaquina right)
        {
            return !(left == right);
        }
        #endregion
    }
}
