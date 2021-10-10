﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//HECHO POR TOMAS AGUSTIN FRIZ
namespace Entidades
{
    //HECHO POR TOMAS AGUSTIN FRIZ
    public sealed class ClienteComputadora : Servicio
    {
        //HECHO POR TOMAS AGUSTIN FRIZ
        #region Atributos
        private readonly List<Software> software;
        private readonly List<Periferico> perifericos;
        private readonly List<Juego> juegos;
        private TipoCompu tipo;
        private const float costo = 0.5F;
        #endregion
        //HECHO POR TOMAS AGUSTIN FRIZ
        #region Constructores
        /// <summary>
        /// Constructor de especificaciones para crear listas.
        /// </summary>
        private ClienteComputadora()
        {
            software = new List<Software>();
            perifericos = new List<Periferico>();
            juegos = new List<Juego>();
        }
        /// <summary>
        /// Constructor de la clase Especificacion para cargar las listas.
        /// </summary>
        /// <param name="software"></param>
        /// <param name="periferico"></param>
        /// <param name="juego"></param>
        public ClienteComputadora(List<Software> software,List<Periferico> periferico,List<Juego> juego): this()
        {
            this.software = software;
            this.perifericos = periferico;
            this.juegos = juego;
        }
        #endregion
        //HECHO POR TOMAS AGUSTIN FRIZ
        #region Propiedades
        /// <summary>
        /// Propiedad de Duracion.
        /// </summary>
        public override int Duracion
        {
            get
            {
                return duracion;
            }
            set
            {
                this.duracion = value;
            }
        }
        /// <summary>
        /// Propiedad del Enumerado de TipoCompu de Tipo.
        /// </summary>
        public TipoCompu Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        /// <summary>
        /// Propiedad del Enumerado de Software de Software.
        /// </summary>
        public List<Software> Software
        {
            get
            {
                return software;
            }
        }
        /// <summary>
        /// Propiedad del Enumerado de Periferico de Perifericos.
        /// </summary>
        public List<Periferico> Periferico
        {
            get
            {
                return perifericos;
            }
        }
        /// <summary>
        /// Propiedad del Enumerado de Juego de Juegos
        /// </summary>
        public List<Juego> Juego
        {
            get
            {
                return juegos;
            }
        }
        #endregion
        //HECHO POR TOMAS AGUSTIN FRIZ
        #region Metodos
        /// <summary>
        /// Sobreescribe el metodo CalcularCosto() y calcula el costo de un equipo(computadora o telefono) segun su duracion y el costo del mismo.
        /// </summary>
        /// <returns></returns>
        protected override float CalcularCosto()
        {
            return (float)Math.Ceiling(Duracion / 30F) * costo;
        }
        /// <summary>
        /// Muestra las especificaciones de la computadora.
        /// </summary>
        /// <returns></returns>
        public string MostrarEspecificaciones()
        {
            StringBuilder sb = new();
            sb.AppendLine($"\nSOFTWARE: ");
            foreach (Software software in software)
            {
                sb.AppendLine($"{software}");
            }
            sb.AppendLine($"\nPERIFERICOS: ");
            foreach (Periferico periferico in perifericos)
            {
                sb.AppendLine($"{periferico}");
            }
            sb.AppendLine($"\nJUEGOS: ");
            foreach (Juego juego in juegos)
            {
                sb.AppendLine($"{juego}");
            }
            return sb.ToString();
        }
        #endregion
    }
}
