using System;
using static Entidades.Enumerados;

namespace Entidades
{
    public class Cliente
    {
        #region Atributos
        protected Random random;
        private int dni;
        private string nombre;
        private string apellido;
        private int edad;
        protected string equipo;
        protected Periferico periferico;
        protected Hardware hardware;
        protected Software software;
        protected Juego juego;
        protected Tipo tipo;
        protected Marcas marca;
        #endregion

        #region Constructores
        /// <summary>
        /// Sobrecarga de constructor vacio.
        /// </summary>
        private Cliente()
        {
            random = new Random();
        }
        /// <summary>
        /// Constructor para los datos de los clientes.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        public Cliente(int dni, string nombre, string apellido, int edad) : this()
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
            this.periferico = (Periferico)random.Next(0, 3);
            this.hardware = (Hardware)random.Next(0, 3);
            this.software = (Software)random.Next(0, 4);
            this.juego = (Juego)random.Next(0, 6);
            this.tipo = (Tipo)random.Next(0, 2);
            this.marca = (Marcas)random.Next(0, 2);
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
        #endregion
    }
}
