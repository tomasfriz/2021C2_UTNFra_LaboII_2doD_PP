using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enumerados
    {
        #region Enumerado
        /// <summary>
        /// Enumera los tipos de Software.
        /// </summary>
        public enum Software
        {
            office,
            messenger,
            icq,
            ares
        }
        /// <summary>
        /// Enumera los tipos de hardware.
        /// </summary>
        public enum Hardware
        {
            procesador,
            ram,
            placaDeVideo
        }
        /// <summary>
        /// Enumera los tipos de perifericos.
        /// </summary>
        public enum Periferico
        {
            cámara,
            auriculares,
            micrófono
        }
        /// <summary>
        /// Enumera los tipos de juegos.
        /// </summary>
        public enum Juego
        {
            CounterStrike,
            DiabloII,
            MuOnline,
            LineageII,
            WarcraftIII,
            AgeOfEmpiresII
        }
        /// <summary>
        /// Enumera los tipos de diferentes teclados de telefonos.
        /// </summary>
        public enum TipoTecla
        {
            Disco,
            Teclado
        }
        /// <summary>
        /// Enumera los tipos de Marcas.
        /// </summary>
        public enum Marcas
        {
            Panasonic,
            Siemens
        }
        public enum TipoEquipo 
        { 
            Cabina, 
            Computadora 
        }
        public enum Estado 
        { 
            Disponible,
            En_Uso
        }
        #endregion
    }
}
