using System;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        #region Atributos
        private int dni;
        private string nombre;
        private string apellido;
        private short edad;
        private Servicio servicio;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Cliente
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="servicio"></param>
        public Cliente(int dni, string nombre, string apellido, short edad, Servicio servicio)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.servicio = servicio;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de Servicio.
        /// </summary>
        public Servicio Servicio
        {
            get
            {
                return servicio;
            }
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Operador + para agregar un cliente a un servicio(Telefono/Computadora).
        /// </summary>
        /// <param name="c"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Cliente operator +(Cliente c, Servicio s)
        {
            if (s is ClienteTelefono)
            {
                c.servicio = (ClienteTelefono)s;
            }
            else
            {
                c.servicio = (ClienteComputadora)s;

            }
            return c;
        }
        /// <summary>
        /// Operador == (Igual) para comparar el DNI del cliente.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1 is not null && c2 is not null)
            {
                return c1.dni == c2.dni;
            }
            return false;
        }
        /// <summary>
        /// Operador != (distinto) para la comparacion del DNI de cliente si son diferentes.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrescribe el metodo Equals().
        /// Requerible para el operador == (igual).
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Cliente c = obj as Cliente;
            return c != null && this == c;
        }
        /// <summary>
        /// Sobrecarga del metodo GetHashCode().
        /// Requerible para el operado != (distinto).
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// Imprime los datos del cliente.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" Nombre: {nombre} - Apellido: {apellido} ");
            sb.AppendLine($"- DNI: {dni} ");
            sb.AppendLine($"- Edad: {edad} años\n");
            return sb.ToString();
        }
        #endregion
    }
}
