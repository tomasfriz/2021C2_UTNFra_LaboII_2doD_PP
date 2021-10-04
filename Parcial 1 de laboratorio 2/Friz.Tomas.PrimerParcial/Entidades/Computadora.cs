using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public sealed class Computadora: Equipo
    {
        #region Atributos
        private List<Software> software;
        private List<Periferico> perifericos;
        private List<Juego> juegos;
        private Dictionary<string, string> hardware;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de Computadora para los componentes
        /// </summary>
        private Computadora(string id): base(id)
        {
            software = new List<Software>();
            perifericos = new List<Periferico>();
            juegos = new List<Juego>();
            hardware = new Dictionary<string, string>();
        }
        /// <summary>
        /// Constructor de Computadora en general
        /// </summary>
        /// <param name="id"></param>
        /// <param name="software"></param>
        /// <param name="perifericos"></param>
        /// <param name="juegos"></param>
        /// <param name="hardware"></param>
        public Computadora(string id, List<Software> software,List<Periferico> perifericos, List<Juego> juegos,Dictionary<string, string> hardware): this(id)
        {
            this.id = id;
            this.tipo = TipoEquipo.Computadora;
            this.software = software;
            this.perifericos = perifericos;
            this.juegos = juegos;
            this.hardware = hardware;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Solo lectura
        /// </summary>
        public int Minutos
        {
            get
            {
                return CalcularMinutos();
            }
        }
        /// <summary>
        /// Solo lectura
        /// </summary>
        public List<Software> Software
        {
            get
            {
                return software;
            }
        }
        /// <summary>
        /// Solo lectura
        /// </summary>
        public List<Periferico> Perifericos
        {
            get
            {
                return perifericos;
            }
        }
        /// <summary>
        /// Solo lectura
        /// </summary>
        public List<Juego> Juegos
        {
            get
            {
                return juegos;
            }
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Revisa que el software este instalado en la compu.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool operator ==(Computadora c, Software s)
        {
            bool estado = false;
            if (c.Software.Count > 0)
            {
                foreach (Software software in c.Software)
                {
                    if (software == s)
                    {
                        estado = true;
                        break;
                    }
                }
            }
            return estado;
        }
        /// <summary>
        /// Revisa que el software no este instalado en la compu.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool operator !=(Computadora c, Software s)
        {
            return !(c == s);
        }
        /// <summary>
        /// Revisa que el periferico este disponible en la compu.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Computadora c, Periferico p)
        {
            bool estado = false;
            if (c.Perifericos.Count > 0)
            {
                foreach (Periferico periferico in c.Perifericos)
                {
                    if (periferico == p)
                    {
                        estado = true;
                        break;
                    }
                }
            }
            return estado;
        }
        /// <summary>
        /// Revisa que el periferico no este disponible en la compu.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Computadora c, Periferico p)
        {
            return !(c == p);
        }
        /// <summary>
        /// Revisa que el juego este instalado en la compu.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator ==(Computadora c, Juego j)
        {
            bool estado = false;
            if (c.Juegos.Count > 0)
            {
                foreach (Juego juego in c.Juegos)
                {
                    if (juego == j)
                    {
                        estado = true;
                        break;
                    }
                }
            }
            return estado;
        }
        /// <summary>
        /// Revisa que el juego no este instalado en la compu.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator !=(Computadora c, Juego j)
        {
            return !(c == j);
        }
        /// <summary>
        /// Sobrescribe el metodo Equals()
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Computadora c = obj as Computadora;
            return c != null && this == c;
        }
        /// <summary>
        /// Sobrecarga del metodo GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (software,perifericos,juegos,hardware).GetHashCode();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrescribe el metodo abstracto CalcularMinutos()
        /// </summary>
        /// <returns>MinutosTotal</returns>
        protected override int CalcularMinutos()
        {
            int total = 0;
            if (Lista.Count > 0)
            {
                foreach (ClienteComputadora costo in Lista)
                {
                    total += costo.Duracion;
                }
            }
            return total;
        }
        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Computadora: {id}\n");
            sb.AppendLine($"Software: ");
            foreach (Software software in software)
            {
                sb.AppendLine($"- {software}\n");
            }
            sb.AppendLine($"Perifericos: ");
            foreach (Periferico periferico in perifericos)
            {
                sb.AppendLine($"- {periferico}\n");
            }
            sb.AppendLine($"Juegos: ");
            foreach (Juego juego in juegos)
            {
                sb.AppendLine($"- {juego}\n");
            }
            sb.AppendLine($"Hardware: ");
            foreach (KeyValuePair<string, string> e in hardware)
            {
                sb.AppendLine($"- {e.Key}: {e.Value}\n");
            }
            sb.AppendLine($"Costo de uso: {Minutos}");
            return sb.ToString();
        }
        #endregion
    }
}
