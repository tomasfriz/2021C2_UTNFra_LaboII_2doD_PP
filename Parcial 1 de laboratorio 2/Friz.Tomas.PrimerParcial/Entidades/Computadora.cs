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
        private Juego juegos;
        private Hardware hardware;
        private double costo;

        private string[] id = new string[10]
        {
            "C01", "C02", "C03", "C04", "C05",
            "C06", "C07", "C08", "C09", "C10"
        };

        public Computadora(Software software, Periferico periferico, Juego juegos, Hardware hardware, double costo)
        {
            this.software = software;
            this.periferico = periferico;
            this.juegos = juegos;
            this.hardware = hardware;
            this.costo = costo;
        }

        public string this[int index]
        {
            get
            {
                return id[index];
            }
            set
            {
                id[index] = value;
            }
        }

        public Software Software { get => software; set => software = value; }
        public Periferico Periferico { get => periferico; set => periferico = value; }
        public Juego Juegos { get => juegos; set => juegos = value; }
        public Hardware Hardware { get => hardware; set => hardware = value; }
        public double Costo { get => costo; set => costo = value; }
    }
}
