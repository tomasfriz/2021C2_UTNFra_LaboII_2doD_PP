using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public sealed class CostoComputadora : Servicio
    {
        #region Atributos
        private const float costo = 0.5F;
        private List<Software> software;
        private List<Periferico> perifericos;
        private List<Juego> juegos;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado de especificacion para crear listas.
        /// </summary>
        private CostoComputadora()
        {
            software = new List<Software>();
            perifericos = new List<Periferico>();
            juegos = new List<Juego>();
        }
        /// <summary>
        /// Constructor de la clase Especificacion
        /// </summary>
        /// <param name="software"></param>
        /// <param name="periferico"></param>
        /// <param name="juego"></param>
        public CostoComputadora(List<Software> software,List<Periferico> periferico,List<Juego> juego): this()
        {
            this.software = software;
            this.perifericos = periferico;
            this.juegos = juego;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Lectura-escrritura Duracion
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
        /// Propiedad de solo letura Software
        /// </summary>
        public List<Software> Software
        {
            get
            {
                return software;
            }
        }
        /// <summary>
        /// Propiedad de solo letura Periferico
        /// </summary>
        public List<Periferico> Periferico
        {
            get
            {
                return perifericos;
            }
        }
        /// <summary>
        /// Propiedad de solo letura Juego
        /// </summary>
        public List<Juego> Juego
        {
            get
            {
                return juegos;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreescribe el metodo y calcula el costo de un equipo(computadora o telefono) segun su duracion y el costo
        /// </summary>
        /// <returns></returns>
        protected override float CalcularCosto()
        {
            if (Duracion % 30 > 0)
            {
                double d = Duracion / 30;
                return (float)Math.Ceiling(d) * costo;
            }
            return (Duracion / 30) * costo;
        }
        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Software: ");
            foreach (Software software in software)
            {
                sb.AppendLine($"- {software} \n");
            }
            sb.AppendLine($"Periferico: ");
            foreach (Periferico periferico in perifericos)
            {
                sb.AppendLine($"- {periferico} \n");
            }
            sb.AppendLine($"Juegos requeridos: ");
            foreach (Juego juego in juegos)
            {
                sb.AppendLine($"- {juego} \n");
            }
            return sb.ToString();
        }
        #endregion
    }
}
