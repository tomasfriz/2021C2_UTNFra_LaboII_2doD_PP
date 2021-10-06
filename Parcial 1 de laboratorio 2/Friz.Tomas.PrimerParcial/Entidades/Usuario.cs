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
        /// Propiedad solo lectura de lista.
        /// </summary>
        public static List<Equipo> Lista
        {
            get
            {
                return equipos;
            }
        }
        /// <summary>
        /// Propiedad solo lectura de equipo disponibles.
        /// </summary>
        public static List<Equipo> equipoDisponible
        {
            get
            {
                return RevisarEquipos();
            }
        }
        /// <summary>
        /// Propiedad solo lectura de clientes.
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
        /// Agrega un cliente a la lista, si ya no se encuentra en la misma 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>true: si se agrega, false: sino se pudo agregar o ya estaba en la lista</returns>
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
        /// Agrega un equipo al cibercafe. 
        /// </summary>
        /// <param name="equipo"></param>
        /// <returns>True: si se pudo cargar y false si ya existia el equipo con ese id</returns>
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
        /// Agrega un servicio a un determinado equipo.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="s"></param>
        /// <returns>true si sale todo bien</returns>
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
        /// Finaliza un servicio, establece su duracion en minutos y libera el equipo
        /// </summary>
        /// <param name="e"></param>
        /// <returns>true si sale todo bien, false si algo sale mal o el equipo estaba disponible</returns>
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
        /// Revisa que los requisitos solicitado enten disponibles en la compu.
        /// </summary>
        /// <param name="cc"></param>
        /// <param name="c"></param>
        /// <returns>True: si se cumplen los requisitos / False: si no se cumplen los requisitos</returns>
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
        /// Revisa los equipos disponibles.
        /// </summary>
        /// <returns>Devuelve una lista de los equipos disponibles</returns>
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
        /// Calcula los minutos entre una hora dada y la hora actual
        /// Un segundo de la vida real será equivalente a un minuto en el cibercafe.
        /// </summary>
        /// <param name="horaInicio"></param>
        /// <returns>Diferencia en minutos</returns>
        private static int CalcularMinutos(DateTime inicio)
        {
            TimeSpan t = DateTime.Now - inicio;
            return (int)t.TotalSeconds;
        }
        /// <summary>
        /// Muestra puestos ordenados de forma descendente por minutos de uso, según el tipo pasado por parámetro
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns>string con la lista de puestos ordenado por minutos de uso en forma descendente</returns>
        public static string OrdenamientoDecendenteTiempo(TipoEquipo tipo)
        {
            StringBuilder sb = new StringBuilder();
            List<Equipo> e = new List<Equipo>();

            foreach (Equipo p in Lista)
            {
                if (tipo == TipoEquipo.Cabina && p is Telefono)
                {
                    e.Add(p);
                }
                else if (tipo == TipoEquipo.Computadora && p is Computadora)
                {
                    e.Add(p);
                }
            }
            e.Sort(CompararEquipos);

            foreach (Equipo p in e)
            {
                sb.AppendLine($"{p}\n");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Compara dos equipos segun sus minutos.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>1 si p1 es mayor o igual a p2, 0 si es menor, -1 si ha ocurrido algun error</returns>
        public static int CompararEquipos(Equipo p1, Equipo p2)
        {
            int retorno = -1;
            if (p1 is not null && p2 is not null)
            {
                if (p1.Minutos >= p2.Minutos)
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
        /// Calcula las ganancias totales y clasificadas por servicio.
        /// </summary>
        /// <returns>Cadena con la informacion de ganancias</returns>
        public static string CalcularGanancias()
        {
            StringBuilder sb = new StringBuilder();
            float gananciasComputadora = 0;
            float gananciasTelefono = 0;
            foreach (Equipo p in Lista)
            {
                if (p.Lista.Count > 0)
                {
                    foreach (Servicio s in p.Lista)
                    {
                        if (s is ClienteComputadora)
                        {
                            gananciasComputadora += s.Costo;
                        }
                        else
                        {
                            gananciasTelefono += s.Costo;
                        }
                    }
                }
            }
            sb.AppendLine($"GANANCIAS TOTALES: ${(gananciasComputadora + gananciasTelefono):N2}\n");
            sb.AppendLine($"GANANCIAS DE COMPUTADORA / TELEFONOS\n");
            sb.AppendLine($"Ganancias por computadoras: ${gananciasComputadora:N2}\n");
            sb.AppendLine($"Ganancias por telefonos: ${gananciasTelefono:N2}\n");
            return sb.ToString();
        }
        #endregion
    }
}
