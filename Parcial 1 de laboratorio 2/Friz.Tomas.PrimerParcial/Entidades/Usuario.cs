using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;

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
        /// Constructor estatico de la clase Usuario.
        /// </summary>
        static Usuario()
        {
            equipos = new List<Equipo>();
            clientes = new Queue<Cliente>();
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad solo lectura de lista de equipo.
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
                return RevisarEquiposDisponibles();
            }
        }
        /// <summary>
        /// Propiedad solo lectura de lista de clientes.
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
        /// Revisa que los requisitos solicitado esten disponibles en la compu, pasada por parametro.
        /// </summary>
        /// <param name="especificaciones"></param>
        /// <param name="computadora"></param>
        /// <returns>True: si todo se cumple, False: si algo no se cumple</returns>
        public static bool RevisarRequisitos(ClienteComputadora especificaciones, Computadora computadora)
        {
            foreach (Software software in especificaciones.Software)
            {
                if (computadora != software)
                {
                    return false;
                }
            }
            foreach (Juego juego in especificaciones.Juego)
            {
                if (computadora != juego)
                {
                    return false;
                }
            }
            foreach (Periferico periferico in especificaciones.Periferico)
            {
                if (computadora != periferico)
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
        private static List<Equipo> RevisarEquiposDisponibles()
        {
            List<Equipo> EquipoDisponible = new List<Equipo>();
            foreach (Equipo e in Lista)
            {
                if (e.Disponible == Equipo.eEstado.Disponible)
                {
                    EquipoDisponible.Add(e);
                }
            }
            return EquipoDisponible;
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
        /// <param name="equipo"></param>
        /// <param name="servicio"></param>
        /// <returns>true si sale todo bien</returns>
        public static bool AgregarServicio(Equipo equipo, Servicio servicio)
        {
            if (equipo.Disponible == Equipo.eEstado.Disponible)
            {
                equipo.Lista.Add(servicio);
                return true;
            }
            return false;
        }
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
        #endregion
    }
}
