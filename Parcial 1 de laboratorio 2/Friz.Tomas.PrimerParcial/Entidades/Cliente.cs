using System;

namespace Entidades
{
    public class Cliente
    {
        #region Atributos
        private int dni;
        private string nombre;
        private string apellido;
        private int edad;
        private string equipo;
        private Periferico periferico;
        private Hardware hardware;
        private Software software;
        private Juego juego;
        private Tipo tipo;
        private Marcas marca;
        #endregion

        #region Constructores
        /// <summary>
        /// Sobrecarga de constructor vacio.
        /// </summary>
        public Cliente()
        {
        }
        /// <summary>
        /// Constructor para los datos de los clientes.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        public Cliente(int dni, string nombre, string apellido, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        /// <summary>
        /// Constructor para sobrecargar y asignar los equipos.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="equipo"></param>
        public Cliente(int dni, string nombre, string apellido, int edad, string equipo) : this(dni, nombre, apellido, edad)
        {
            this.equipo = equipo;
        }
        /// <summary>
        /// Constructor para sobrecargar y asignar los datos de las computadoras a los clientes.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="equipo"></param>
        /// <param name="periferico"></param>
        /// <param name="hardware"></param>
        /// <param name="software"></param>
        /// <param name="juego"></param>
        public Cliente(int dni, string nombre, string apellido, int edad, string equipo, Periferico periferico, Hardware hardware, Software software, Juego juego) : this(dni, nombre, apellido, edad, equipo)
        {
            this.periferico = periferico;
            this.hardware = hardware;
            this.software = software;
            this.juego = juego;
        }
        /// <summary>
        /// Constructor para sobrecargar y asignar los datos de los telefonos a los clientes.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="equipo"></param>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
        public Cliente(int dni, string nombre, string apellido, int edad, string equipo,Tipo tipo, Marcas marca) : this(dni, nombre, apellido, edad, equipo)
        {
            this.tipo = tipo;
            this.marca = marca;
        }
        #endregion

        #region Encapsulamiento
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public string Nombre 
        { 
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido 
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public int Edad 
        {
            get 
            { 
                return edad; 
            }
            set 
            { 
                edad = value; 
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
        #endregion
    }
}
