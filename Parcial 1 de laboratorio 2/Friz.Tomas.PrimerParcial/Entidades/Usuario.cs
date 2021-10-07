using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Usuario
    {
        #region Atributo
        private static List<Equipo> equipos;
        private static Queue<Cliente> clientes;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Usuario.
        /// </summary>
        static Usuario()
        {
            equipos = new List<Equipo>();
            clientes = new Queue<Cliente>();
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de la lista de Equipo de lista.
        /// </summary>
        public static List<Equipo> Lista
        {
            get
            {
                return equipos;
            }
        }
        /// <summary>
        /// Propiedad de la lista de Equipo de equipo disponibles, devuelve el estado del equipo.
        /// </summary>
        public static List<Equipo> equipoDisponible
        {
            get
            {
                return RevisarEquipos();
            }
        }
        /// <summary>
        /// Propiedad del Queue de Cliente de clientes.
        /// </summary>
        public static Queue<Cliente> Clientes
        {
            get
            {
                return clientes;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Agrega un cliente a la lista de clientes, si ya no se encuentra en la misma. 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>true si se agrego a la lista y false sino se pudo agregar a la lista o ya estaba en la lista</returns>
        public static bool AgregarCliente(Cliente cliente)
        {
            foreach (Cliente c in Clientes)
            {
                if (c == cliente)
                {
                    return false;
                }
            }
            Clientes.Enqueue(cliente);
            return true;
        }
        /// <summary>
        /// Agrega un equipo a la lista de equipo, si ya no se encuentra en la misma. 
        /// </summary>
        /// <param name="equipo"></param>
        /// <returns>True si se agrego a la lista y false si ya existia el equipo en la lista</returns>
        public static bool AgregarEquipo(Equipo equipo)
        {
            foreach (Equipo e in Lista)
            {
                if (e == equipo)
                {
                    return false;
                }
            }
            equipos.Add(equipo);
            return true;
        }
        /// <summary>
        /// Agrega un servicio a un determinado equipo(computadora/telefono).
        /// </summary>
        /// <param name="e"></param>
        /// <param name="s"></param>
        /// <returns>true si se pudo agregar el servicio y false si no se pudo agregar el servicio</returns>
        public static bool AgregarServicio(Equipo e, Servicio s)
        {
            if (e.Estado == Estado.Disponible)
            {
                e.Estado = Estado.En_Uso;
                s.Inicio = DateTime.Now;
                e.Lista.Add(s);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Finaliza un servicio, establece su duracion en minutos y libera el equipo.
        /// </summary>
        /// <param name="e"></param>
        /// <returns>true si se pudo finalizar el servicio y false si no se pudo finalizar o el equipo estaba disponible</returns>
        public static bool FinalizarServicio(Equipo e)
        {
            if (e.Estado == Estado.En_Uso)
            {
                if (e.Lista.Count > 0)
                {
                    Servicio s = e.Lista.Last();
                    if (s is ClienteTelefono || (s is ClienteComputadora && ((ClienteComputadora)s).Tipo == TipoCompu.Libre))
                    {
                        s.Duracion = CalcularMinutos(s.Inicio);
                    }
                    e.Estado = Estado.Disponible;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Revisa que los requisitos solicitado por el cliente esten disponibles en la computadora.
        /// </summary>
        /// <param name="cc"></param>
        /// <param name="c"></param>
        /// <returns>True si se cumplen los requisitos del cliente con respecto a la computadora y false si no se cumplen los requisitos del cliente con respecto a la computadora.</returns>
        public static bool RevisarRequisitos(ClienteComputadora cc, Computadora c)
        {
            foreach (Software software in cc.Software)
            {
                if (c != software)
                {
                    return false;
                }
            }
            foreach (Juego juego in cc.Juego)
            {
                if (c != juego)
                {
                    return false;
                }
            }
            foreach (Periferico periferico in cc.Periferico)
            {
                if (c != periferico)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Revisa los equipos disponibles, es decir que esten libres para su uso.
        /// </summary>
        /// <returns>Devuelve una lista de los equipos que puede usar el cliente</returns>
        private static List<Equipo> RevisarEquipos()
        {
            List<Equipo> EquipoDisponible = new List<Equipo>();
            foreach (Equipo e in Lista)
            {
                if (e.Estado == Estado.Disponible)
                {
                    EquipoDisponible.Add(e);
                }
            }
            return EquipoDisponible;
        }
        /// <summary>
        /// Calcula los minutos entre una hora dada y la hora actual, para sacar la duracion en que estuvo el cliente en el equipo.
        /// Un segundo de la vida real será equivalente a un minuto en el cibercafe.
        /// </summary>
        /// <param name="inicio"></param>
        /// <returns>Devuelve la diferencia en minutos entre la hora de inicio con la hora actual.</returns>
        private static int CalcularMinutos(DateTime inicio)
        {
            TimeSpan t = DateTime.Now - inicio;
            return (int)t.TotalSeconds;
        }
        /// <summary>
        /// Muestra los equipos ordenados de forma descendente con el criterio de minutos de uso.
        /// </summary>
        /// <param name="t"></param>
        /// <returns>Imprime la lista de equipos ordenados por minutos de uso en forma descendente</returns>
        public static string OrdenamientoDecendenteTiempo(TipoEquipo t)
        {
            StringBuilder sb = new StringBuilder();
            List<Equipo> e = new List<Equipo>();
            foreach (Equipo equipo in Lista)
            {
                if (t == TipoEquipo.Cabina && equipo is Telefono)
                {
                    e.Add(equipo);
                }
                else if (t == TipoEquipo.Computadora && equipo is Computadora)
                {
                    e.Add(equipo);
                }
            }
            e.Sort(CompararEquipos);
            foreach (Equipo equipo in e)
            {
                sb.AppendLine($"{equipo}\n");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Compara dos equipos segun sus minutos de uso.
        /// Esta funcion se usa para el ordanamiento descendente de equipos segun el tiempo de uso.
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns>1 si e1 es mayor o igual a e2, 0 si e1 es menor a e2 y -1 si ha ocurrido algun error</returns>
        public static int CompararEquipos(Equipo e1, Equipo e2)
        {
            int retorno = -1;
            if (e1 is not null && e2 is not null)
            {
                if (e1.Minutos >= e2.Minutos)
                {
                    retorno = 1;
                }
                else
                {
                    retorno = 0;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Calcula las ganancias totales y las clasifica por servicio (Computadora/telefono).
        /// </summary>
        /// <returns>Devuelve la informacion de las ganancias totales, de las ganancias del servicio de computadoras y de las ganancias del servicio de telefonos</returns>
        public static string CalcularGanancias()
        {
            StringBuilder sb = new StringBuilder();
            float gananciasComputadoras = 0;
            float gananciasTelefonos = 0;
            foreach (Equipo e in Lista)
            {
                if (e.Lista.Count > 0)
                {
                    foreach (Servicio s in e.Lista)
                    {
                        if (s is ClienteComputadora)
                        {
                            gananciasComputadoras += s.Costo;
                        }
                        else
                        {
                            gananciasTelefonos += s.Costo;
                        }
                    }
                }
            }
            sb.AppendLine($"GANANCIAS TOTALES: ${(gananciasComputadoras + gananciasTelefonos): N2}\n");
            sb.AppendLine($"GANANCIAS DE COMPUTADORAS\n");
            sb.AppendLine($"Ganancias por computadoras: ${gananciasComputadoras: N2}\n");
            sb.AppendLine($"GANANCIAS DE TELEFONOS\n");
            sb.AppendLine($"Ganancias por telefonos: ${gananciasTelefonos: N2}\n");
            return sb.ToString();
        }
        #endregion
    }
}
