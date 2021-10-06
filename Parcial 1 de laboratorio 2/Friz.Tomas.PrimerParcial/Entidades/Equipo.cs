﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        #region Atributos
        protected string id;
        protected Estado estado;
        protected TipoEquipo tipo;
        protected List<Servicio> lista;
        #endregion

        #region Constructores
        protected Equipo(string id)
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
        /// Devuelve los
        /// </summary>
        public int Minutos
        {
            get
            {
                return CalcularMinutos();
            }
        }
        /// <summary>
        /// Propiedad solo lectura de disponible
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
        /// Propiedad solo lectura del tipo
        /// </summary>
        public TipoEquipo Tipo
        {
            get
            {
                return tipo;
            }
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

        #region Operadores
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo t1,Equipo t2)
        {
            if (t1 is not null && t2 is not null)
            {
                return t1.id == t2.id;
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator !=(Equipo t1, Equipo t2)
        {
            return !(t1 == t2);
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrescribe el metodo Equals()
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Equipo t = obj as Equipo;
            return t != null && this == t;
        }
        /// <summary>
        /// Sobrecarga del metodo GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        #endregion

        #region Metodos 
        /// <summary>
        /// Calcula los minutos de uso del equipo mas la duracion del mismo.
        /// </summary>
        /// <returns>Minutos de uso</returns>
        protected int CalcularMinutos()
        {
            int total = 0;
            foreach (Servicio s in lista)
            {
                total += s.Duracion;
            }
            return total;
        }
        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {tipo} - Id: {id}\n");
            sb.AppendLine($"Estado: {estado}\n");
            sb.AppendLine($"Minutos: {Minutos}\n");
            return sb.ToString();
        }
        #endregion
    }
}
