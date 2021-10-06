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
        private string codigo;
        private string localidad;
        private string num;
        #endregion

        #region Propiedades
        /// <summary>
        /// Solo lectura = Devuelve el numero de destino
        /// </summary>
        public string NumDestino
        {
            get
            {
                return $"+{codigo} ({localidad}) {num}";
            }
        }
        /// <summary>
        /// Solo lectura = devuelve el tipo de localidad.
        /// </summary>
        public TipoLocalidad Tipo
        {
            get
            {
                return IdentificarLocalidad();
            }
        }
        /// <summary>
        /// Lectura/Escritura = Para establecer la duracion de una llamada.
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
        /// <summary>
        /// Propiedad lectura escritura
        /// </summary>
        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        /// <summary>
        /// Propiedad lectura escritura
        /// </summary>
        public string Localidad
        {
            get
            {
                return localidad;
            }
            set
            {
                localidad = value;
            }
        }

        /// <summary>
        /// Propiedad lectura escritura
        /// </summary>
        public string Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
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
            return base.GetHashCode() + NumDestino.GetHashCode();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Sobreescribe el metodo y calcula el costo de una llamada segun su duracion y el valor del minuto
        /// </summary>
        /// <returns></returns>
        protected override float CalcularCosto()
        {
            return (Duracion * (int)Tipo) / 100;
        }
        /// <summary>
        /// Determina si el numero es local, Provincial o internacional.
        /// </summary>
        /// <returns>Tipo de llamada</returns>
        private TipoLocalidad IdentificarLocalidad()
        {
            if (codigo != "54")
            {
                return TipoLocalidad.Internacional;
            }
            else
            {
                if (localidad == "011" || localidad == "11")
                {
                    return TipoLocalidad.Local;
                }
                else
                {
                    return TipoLocalidad.LargaDistancia;
                }
            }
        }
        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo de llamada: {Tipo}\n");
            sb.AppendLine($"Numero: +{codigo} ({localidad}) {num}\n");
            return sb.ToString();
        }
        #endregion
    }

    //public class ValidadorLlamada : AbstractValidator<ClienteTelefono>
    //{
    //    /// <summary>
    //    /// Valida que los números ingresados.
    //    /// </summary>
    //    public ValidadorLlamada()
    //    {
    //        RuleFor(x => x.CodigoPais).NotEmpty().MaximumLength(4).Matches("^[0-9]*$").WithMessage("El código no es válido");
    //        RuleFor(x => x.PrefijoLocalidad).NotEmpty().MinimumLength(2).MaximumLength(5).Matches("^[0-9]*$").WithMessage("El no es válido");
    //        RuleFor(x => x.Numero).NotEmpty().MinimumLength(6).MaximumLength(8).Matches("^[0-9]*$").WithMessage("El número no es válido");
    //    }
    //}
}
