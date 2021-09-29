﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public class Telefono
    {
        #region Atributos
        private string id;
        private Tipo tipo;
        private Marcas marca;
        private string estado;
        private double costo;
        #endregion

        #region Constructores
        /// <summary>
        /// Sobrecarga de constructor vacio.
        /// </summary>
        public Telefono()
        {
        }
        /// <summary>
        /// Constructor para los datos de los telefonos.
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
        public Telefono(Tipo tipo, Marcas marca)
        {
            this.tipo = tipo;
            this.marca = marca;
        }
        /// <summary>
        /// Constructor para sobrecargar y asignar los estados de los telefonos.
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
        /// <param name="estado"></param>
        public Telefono(string id,Tipo tipo, Marcas marca, string estado) : this(tipo, marca)
        {
            this.id = id;
            this.estado = estado;            
        }
        #endregion

        #region Encapsulamiento
        public string Id 
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
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
        public string Estado 
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }        
        }

        
        #endregion
    }
}
