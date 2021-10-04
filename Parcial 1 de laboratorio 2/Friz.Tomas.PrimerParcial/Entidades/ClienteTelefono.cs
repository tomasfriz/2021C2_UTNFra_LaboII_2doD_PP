using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

namespace Entidades
{
    public sealed class ClienteTelefono : Servicio
    {
        #region Atributos
        private int codigo;
        private int localidad;
        private int numero;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Llamada
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="localidad">loca</param>
        /// <param name="numero"></param>
        public ClienteTelefono(int codigo, int localidad, int numero)
        {
            this.codigo = codigo;
            this.localidad = localidad;
            this.numero = numero;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Solo lectura = Devuelve el numero de destino
        /// </summary>
        public string NumDestino
        {
            get
            {
                return $"+{codigo} ({localidad}) {numero}";
            }
        }
        /// <summary>
        /// Solo lectura = retorna el tipo de llamada
        /// </summary>
        public TipoLlamada Tipo
        {
            get
            {
                return IdentificarLlamada();
            }
        }
        /// <summary>
        /// Solo lectura = Devuelve el costo de la llamada
        /// </summary>
        public float Costo
        {
            get
            {
                return CalcularCosto();
            }
        }
        /// <summary>
        /// Lectura/Escritura = Para establecer la duracion de una llamada una vez finalizada 
        /// </summary>
        public override int Duracion
        {
            get
            {
                return duracion;
            }
            set
            {
                this.duracion = value;
            }
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(ClienteTelefono c1, ClienteTelefono c2)
        {
            if (c1 is not null && c2 is not null)
            {
                return c1.GetHashCode() == c2.GetHashCode();
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(ClienteTelefono c1, ClienteTelefono c2)
        {
            return !(c1 == c2);
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrescribe el metodo Equals()
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            ClienteTelefono c = obj as ClienteTelefono;
            return c != null && this == c;
        }
        /// <summary>
        /// Sobrecarga del metodo GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            string t = $"{codigo}{localidad}{numero}";
            return t.GetHashCode() + Duracion.GetHashCode();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Analiza el número de la llamada a fin de determinar si es local, larga distancia o internacional
        /// </summary>
        /// <returns>Tipo de llamada</returns>
        private TipoLlamada IdentificarLlamada()
        {
            if (codigo != 54)
            {
                return TipoLlamada.Internacional;
            }
            else
            {
                if (localidad == 11)
                {
                    return TipoLlamada.Local;
                }
                else
                {
                    return TipoLlamada.LargaDistancia;
                }
            }
        }
        /// <summary>
        /// Sobreescribe el metodo y calcula el costo de una llamada segun su duracion y el valor del minuto
        /// </summary>
        /// <returns></returns>
        protected override float CalcularCosto()
        {
            return (Duracion * (int)Tipo) / 100;
        }
        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo llamada: {Tipo}\n");
            sb.AppendLine($"Numero: +{codigo} ({localidad}) {numero}\n");
            return sb.ToString();
        }
        #endregion
    }
}
