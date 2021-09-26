using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Telefono
    {
        #region Atributos
        private Tipo tipo;
        private Marcas marca;
        private string estado;
        private double costo;
        #endregion

        #region Indexador
        /// <summary>
        /// Sirve para indexar las id o identificadores de cada telefono.
        /// </summary>
        private string[] id = new string[5]
        {
            "T01", "T02", "T03", "T04", "T05"
        };
        #endregion

        #region Constructores
        /// <summary>
        /// Sobrecarga de constructor vacio.
        /// </summary>
        public Telefono()
        {
        }
        /// <summary>
        /// Constructor para los datos de los telefonos.
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
        public Telefono(Tipo tipo, Marcas marca)
        {
            this.tipo = tipo;
            this.marca = marca;
        }
        /// <summary>
        /// Constructor para sobrecargar y asignar los estados de los telefonos.
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
        /// <param name="estado"></param>
        public Telefono(Tipo tipo, Marcas marca, string estado) : this(tipo, marca)
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
            set
            {
                id[index] = value;
            }
        }
        public Tipo Tipo 
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
        public Marcas Marca 
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
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
