using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora
    {
        #region Atributos
        private Software software;
        private Periferico periferico;
        private Juego juego;
        private Hardware hardware;
        private string estado;
        private double costo;
        #endregion

        #region Indexador
        /// <summary>
        /// Sirve para indexar las id o identificadores de cada computadora.
        /// </summary>
        private string[] id = new string[10]
        {
            "C01", "C02", "C03", "C04", "C05",
            "C06", "C07", "C08", "C09", "C10"
        };
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
        public Computadora(Software software, Periferico periferico, Juego juego, Hardware hardware, string estado) : this(software, periferico, juego, hardware)
        {
            this.estado = estado;
        }
        #endregion

        #region Encapsulamiento
        public string this[int index]
        {
            get
            {
                return id[index];
            }
        }
        public Periferico Periferico
        {
            get
            {
                return periferico;
            }
            set
            {
                periferico = value;
            }
        }
        public Hardware Hardware
        {
            get
            {
                return hardware;
            }
            set
            {
                hardware = value;
            }
        }
        public Software Software
        {
            get
            {
                return software;
            }
            set
            {
                software = value;
            }
        }
        public Juego Juego
        {
            get
            {
                return juego;
            }
            set
            {
                juego = value;
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
