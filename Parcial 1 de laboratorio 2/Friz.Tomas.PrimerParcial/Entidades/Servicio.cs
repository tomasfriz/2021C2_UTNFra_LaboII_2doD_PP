using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public abstract class Servicio
    {
        #region Atributos
        protected string id;
        protected Estado estado;
        protected TipoEquipo tipo;
        protected int duracion;
        protected List<Servicio> lista;
        #endregion

        #region Constructores
        protected Servicio()
        {
        }
        protected Servicio(string id)
        {
            this.id = id;
            this.lista = new List<Servicio>();
            this.estado = Estado.Disponible;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Solo lectura.
        /// </summary>
        public string Id
        {
            get
            {
                return id;
            }
        }
        /// <summary>
        /// Propiedad solo lectura del tipo de puesto
        /// </summary>
        public TipoEquipo TipoEquipo
        {
            get
            {
                return tipo;
            }
        }
        /// <summary>
        /// Propiedad solo lectura del estado
        /// </summary>
        public Estado Estado
        {
            get
            {
                return estado;
            }
            set
            {
                this.estado = value;
            }
        }
        /// <summary>
        /// Propiedad lectura-escritura
        /// </summary>
        abstract public int Duracion
        { 
            get; set; 
        }
        /// <summary>
        /// Solo lectura
        /// </summary>
        public List<Servicio> Lista
        {
            get
            {
                return lista;
            }
        }
        #endregion

        #region Metodos 
        /// <summary>
        /// Calcula los minutos de uso del servicio
        /// </summary>
        /// <returns>Minutos de uso</returns>
        protected abstract int CalcularMinUso();
        /// <summary>
        /// Calcula el costo de un servicio
        /// </summary>
        /// <returns></returns>
        abstract protected float CalcularCosto();
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Servicio s1, Servicio s2)
        {
            return s1 is not null && s2 is not null && s1.id == s2.id;
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
        /// <summary>
        /// Sobrescribe el metodo Equals()
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Servicio servicio = obj as Servicio;
            return servicio != null && this == servicio;
        }
        /// <summary>
        /// Sobrecarga del metodo GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{id}";
        }
        #endregion
    }
}
