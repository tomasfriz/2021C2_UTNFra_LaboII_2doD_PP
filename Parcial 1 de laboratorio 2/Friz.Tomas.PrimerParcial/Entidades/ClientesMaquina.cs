using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public class ClientesMaquina : Cliente
    {
        public ClientesMaquina(int dni, string nombre, string apellido, int edad, string equipo) : base(dni, nombre, apellido, edad)
        {
            this.equipo = equipo;
            this.periferico = (Periferico)random.Next(0, 3);
            this.hardware = (Hardware)random.Next(0, 3);
            this.software = (Software)random.Next(0, 4);
            this.juego = (Juego)random.Next(0, 6);
        }
    }
}
