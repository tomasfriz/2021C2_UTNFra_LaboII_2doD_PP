using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public class Computadora
    {
        #region Atributos
        private string id;
        private Software software;
        private Periferico periferico;
        private Juego juego;
        private Hardware hardware;
        private string estado;
        private double costo;
        #endregion

        #region Constructores
        /// <summary>
        /// Sobrecarga de constructor vacio.
        /// </summary>
        public Computadora()
        {
        }
        /// <summary>
        /// Constructor para los datos de las computadoras.
        /// </summary>
        /// <param name="software"></param>
        /// <param name="periferico"></param>
        /// <param name="juego"></param>
        /// <param name="hardware"></param>
        public Computadora(Software software, Periferico periferico, Juego juego, Hardware hardware)
        {
            this.software = software;
            this.periferico = periferico;
            this.juego = juego;
            this.hardware = hardware;
        }
        /// <summary>
        /// Constructor para sobrecargar y asignar los estados de las computadoras.
        /// </summary>
        /// <param name="software"></param>
        /// <param name="periferico"></param>
        /// <param name="juego"></param>
        /// <param name="hardware"></param>
        /// <param name="estado"></param>
        public Computadora(string id,Software software, Periferico periferico, Juego juego, Hardware hardware, string estado) : this(software, periferico, juego, hardware)
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
        }
        public Periferico Periferico
        {
            get
            {
                return periferico;
            }
        }
        public Hardware Hardware
        {
            get
            {
                return hardware;
            }
        }
        public Software Software
        {
            get
            {
                return software;
            }
        }
        public Juego Juego
        {
            get
            {
                return juego;
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
