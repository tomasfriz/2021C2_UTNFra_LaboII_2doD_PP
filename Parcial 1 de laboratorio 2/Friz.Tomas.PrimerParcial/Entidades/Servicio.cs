using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Servicio
    {
        #region Atributos
        protected int duracion;
        protected DateTime inicio;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de duracion
        /// </summary>
        abstract public int Duracion 
        { 
            get; 

            set; 
        }
        /// <summary>
        /// Devuelve el costo del servicio
        /// </summary>
        public float Costo
        {
            get
            {
                return CalcularCosto();
            }
        }
        /// <summary>
        /// Establece el inicio del tiempo.
        /// </summary>
        public DateTime Inicio
        {
            get
            {
                return inicio;
            }
            set
            {
                inicio = value;
            }
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator ==(Servicio s1, Servicio s2)
        {
            //if (s1 is not null && s2 is not null)
            //{
            //    return s1.GetHashCode() == s2.GetHashCode();
            //}
            //return false;

            return (s1 is not null && s2 is not null) && s1.GetHashCode() == s2.GetHashCode();
        }
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator !=(Servicio s1, Servicio s2)
        {
            return !(s1 == s2);
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrescribe el metodo Equals()
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Servicio s = obj as Servicio;
            return s != null && this == s;
        }
        /// <summary>
        /// Sobrecarga del metodo GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (Inicio,GetType(),Duracion).GetHashCode();
        }
        #endregion

        #region Metodos 
        /// <summary>
        /// Calcula el costo del servicio
        /// </summary>
        /// <returns></returns>
        abstract protected float CalcularCosto();
        /// <summary>
        /// Le agrega un 21% en concepto de IVA al costo del servicio.
        /// </summary>
        /// <returns></returns>
        public float AgregarIVA()
        {
            return Costo * 1.21F;
        }
        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //return $"{id}";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {GetType()}");
            sb.AppendLine($"Tiempo de inicio: {Inicio}");
            sb.AppendLine($"Duración: {Duracion} minutos");
            return sb.ToString();
        }
        #endregion
    }
}
