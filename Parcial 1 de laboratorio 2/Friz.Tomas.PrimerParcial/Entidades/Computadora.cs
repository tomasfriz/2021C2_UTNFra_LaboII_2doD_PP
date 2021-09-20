using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora
    {
        private string id;
        private Software software;
        private Periferico periferico;
        private Juego juegos;
        private Hardware hardware;
        private double costo;

        public Computadora(string id, Software software, Periferico periferico, Juego juegos, Hardware hardware, double costo)
        {
            this.id = id;
            this.software = software;
            this.periferico = periferico;
            this.juegos = juegos;
            this.hardware = hardware;
            this.costo = costo;
        }

        public string Id { get => id; set => id = value; }
        public Software Software { get => software; set => software = value; }
        public Periferico Periferico { get => periferico; set => periferico = value; }
        public Juego Juegos { get => juegos; set => juegos = value; }
        public Hardware Hardware { get => hardware; set => hardware = value; }
        public double Costo { get => costo; set => costo = value; }
    }
}
