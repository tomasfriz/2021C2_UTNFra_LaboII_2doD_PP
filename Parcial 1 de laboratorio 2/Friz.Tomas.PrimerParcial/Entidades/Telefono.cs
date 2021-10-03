using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public sealed class Telefono : Equipo
    {
        #region Atributos
        private TipoTecla tipoTecla;
        private string marca;
        private List<CostoTelefono> listaCosto;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase telefono
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipoTecla"></param>
        /// <param name="marca"></param>
        public Telefono(string id, TipoTecla tipoTecla, string marca): base(id)
        {
            this.id = id;
            this.tipoTecla = tipoTecla;
            this.marca = marca;
            this.tipo = TipoEquipo.Cabina;
            this.listaCosto = new List<CostoTelefono>();
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// 
        /// </summary>
        public int Minutos
        {
            get
            {
                return CalcularMinutos();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public TipoTecla TipoTecla
        {
            get
            {
                return tipoTecla;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrescribe el metodo abstracto CalcularMinutos()
        /// </summary>
        /// <returns>Minutos de uso</returns>
        protected override int CalcularMinutos()
        {
            int total = 0;
            foreach (CostoTelefono costo in listaCosto)
            {
                total += costo.Duracion;
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
            sb.AppendLine($"Cabina: {id}\n");
            sb.AppendLine($"Tipo de tecla: {tipoTecla}\n");
            sb.AppendLine($"Marca: {marca}\n");
            sb.AppendLine($"Costo de uso: {Minutos}\n");
            return sb.ToString();
        }
        #endregion
    }
}
