using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public sealed class ClienteComputadora : Servicio
    {
        #region Atributos
        
        private List<Software> software;
        private List<Periferico> perifericos;
        private List<Juego> juegos;
        private TipoCompu tipo;
        private const float costo = 0.5F;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado de especificacion para crear listas.
        /// </summary>
        private ClienteComputadora()
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
        public ClienteComputadora(List<Software> software,List<Periferico> periferico,List<Juego> juego): this()
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
        /// Propiedad lectura-escritura tipo sesion
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
            //if (Duracion % 30 > 0)
            //{
            //    double d = Duracion / 30;
            //    return (float)Math.Ceiling(d) * costo;
            //}
            //return (Duracion / 30) * costo;

            return (float)Math.Ceiling(Duracion / 30F) * costo;
        }
        /// <summary>
        /// Muestra las especificaciones de la computadora.
        /// </summary>
        /// <returns></returns>
        public string MostrarEspecificaciones()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Software: ");
            foreach (Software software in software)
            {
                sb.AppendLine($"{software}\n");
            }
            sb.AppendLine($"Periferico: ");
            foreach (Periferico periferico in perifericos)
            {
                sb.AppendLine($"{periferico}\n");
            }
            sb.AppendLine($"Juego: ");
            foreach (Juego juego in juegos)
            {
                sb.AppendLine($"{juego}\n");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// Muestra los detalles de la computadora que pidio el cliente.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {tipo}\n");
            if (tipo != TipoCompu.Libre)
            {
                sb.AppendLine($"Minutos Establecidos: {Duracion}\n");
            }
            sb.AppendLine(MostrarEspecificaciones());
            return sb.ToString();
        }
        #endregion
    }
}
