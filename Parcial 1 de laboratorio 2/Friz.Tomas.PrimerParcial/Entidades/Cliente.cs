using System;
using static Entidades.Enumerados;

namespace Entidades
{
    public class Cliente
    {
        #region Atributos
        protected Random random;
        protected int dni;
        protected string nombre;
        protected string apellido;
        protected int edad;
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
        }
        #endregion


    }
}
