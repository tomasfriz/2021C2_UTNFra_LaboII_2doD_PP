using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora
    {
        private Software software;
        private Periferico periferico;
        private Juego juego;
        private Hardware hardware;
        private string estado;
        private double costo;

        private string[] id = new string[10]
        {
            "C01", "C02", "C03", "C04", "C05",
            "C06", "C07", "C08", "C09", "C10"
        };

        public Computadora()
        {
        }

        public Computadora(Software software, Periferico periferico, Juego juego, Hardware hardware)
        {
            this.software = software;
            this.periferico = periferico;
            this.juego = juego;
            this.hardware = hardware;
        }

        public Computadora(Software software, Periferico periferico, Juego juego, Hardware hardware, string estado) : this(software, periferico, juego, hardware)
        {
            this.estado = estado;
        }

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
    }
}
