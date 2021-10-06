using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static Entidades.Enumerados;

namespace Cibercafe_ElVicio
{
    public partial class FrmMenu : Form
    {
        private Random random;

        #region Constructor
        /// <summary>
        /// Coloca el nombre del usuario en la barra superior del form y tambien la inicio actual.
        /// </summary>
        public FrmMenu()
        {
            InitializeComponent();
            lblUsuario.Text = "Tomás Agustín Friz";
            lblFecha.Text = DateTime.Now.ToShortDateString();
            random = new Random();

        }
        #endregion

        #region Botones
        /// <summary>
        /// Sirve para cerrar la aplicacion.
        /// Antes pregunta si desea cerrar la aplicacion porque se cerraran tambien todas las ventanas emergentes.
        /// SI, cerrara la aplicacion y todas las ventanas abiertas.
        /// NO, volvera a la aplicacion y se anulara el cerrado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir, cerraras todas las ventanas abiertas?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Sirve para orientar al usuario a saber que hace cada boton de la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-El boton 'Ayuda' te ayudara a saber el funcionamiento de los botones.\n" +
                "-El boton 'Cerrar' te preguntara si deseas cerrar. 'SI' cerrara la aplicacion, incluyendo las ventanas abiertas. 'NO' regresaras al menu principal.\n" +
                "-El boton 'Asignar Equipo' te permitira asignar un equipo al cliente y tambien detener el uso de la misma.\n" +
                "-El boton 'Mostrar Equipo' te permitira ver los equipo y sus especificaciones y tambien detener el uso de la misma.\n" +
                "-El boton 'Estadisticas Historicas' te permitira ver el historial", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Sirve tanto para asignar los equipos de los clientes como para que el usuario vea un registro de las maquinas en uso o disponibles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsigEquipo_Click(object sender, EventArgs e)
        {
            if (Usuario.Clientes.Count > 0)
            {
                Cliente c = Usuario.Clientes.Peek();
                if (c.Servicio is ClienteComputadora)
                {
                    FrmComputadoras frmComputadoras = new FrmComputadoras();
                    frmComputadoras.Show();
                }
                else
                {
                    FrmTelefonos frmTelefonos = new FrmTelefonos();
                    frmTelefonos.Show();
                }
            }
        }
        /// <summary>
        /// Sirve para desconectar al cliente del equipo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarEquipo_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Sirve para ver las estadisticas historicas relacionadas con los clientes y el uso de las maquinas y cabinas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial();
            frmHistorial.Show();
        }
        /// <summary>
        /// Se encarga de hardcodear los datos de los clientes y saludar al usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡BIENVENIDO USUARIO!");

            List<Cliente> lista = new List<Cliente>()
            {
                //Periferico p = (Periferico)random.Next(0,4):
            new Cliente(41918909, "Tomás", "Sánchez", 22, new ClienteComputadora(new List<Software>(){(Software)random.Next(0,4)},new List<Periferico>(){(Periferico)random.Next(0,3)},new List<Juego>(){(Juego)random.Next(0,6)})),
            //new Cliente(34067132, "Mauricio", "Prieto", 35, new ClienteTelefono()),
            new Cliente(31456980, "Gustavo", "Doria", 53, new ClienteComputadora(new List<Software>(){(Software)random.Next(0,4)},new List<Periferico>(){(Periferico)random.Next(0,3)},new List<Juego>(){(Juego)random.Next(0,6)})),
            //new Cliente(36897132, "Belén", "Trinidad", 16, new ClienteTelefono()),
            new Cliente(27643934, "Brisa", "Quinteros", 48, new ClienteComputadora(new List<Software>(){(Software)random.Next(0,4)},new List<Periferico>(){(Periferico)random.Next(0,3)},new List<Juego>(){(Juego)random.Next(0,6)})),
            //new Cliente(19934027, "Pedro", "Macri", 61, new ClienteTelefono())
            };
            foreach (Cliente cliente in lista)
            {
                Usuario.AgregarCliente(cliente);
            }
            ActualizarClientes();
            List<Equipo> listaComputadora = new List<Equipo>()
            {
                new Computadora("C01", new List<Software>(){Software.ares,Software.messenger}, new List<Periferico>() {Periferico.auriculares}, new List<Juego>() {Juego.CounterStrike},new Dictionary<string, string> {{"RAM", "4GB"}, {"Procesador","Intel Pentium 4"}, {"Placa de video","486 DLC"}}),
                new Computadora("C02", new List<Software>(){Software.icq,Software.office}, new List<Periferico>() {Periferico.cámara}, new List<Juego>() {Juego.AgeOfEmpiresII}, new Dictionary<string, string> {{"RAM", "2GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video","Geforce 4"}}),
                new Computadora("C03", new List<Software>(){Software.messenger,Software.icq}, new List<Periferico>() {Periferico.micrófono}, new List<Juego>() {Juego.CounterStrike}, new Dictionary<string, string> {{"RAM","4GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video","9600GT"}}),
                new Computadora("C04", new List<Software>(){Software.office,Software.messenger}, new List<Periferico>() {Periferico.auriculares}, new List<Juego>() {Juego.DiabloII}, new Dictionary<string, string> {{"RAM","2GB"}, {"Procesador", "Intel Pentium"}, {"Placa de video","486 DLC"}}),
                new Computadora("C05", new List<Software>(){Software.ares,Software.icq}, new List<Periferico>() {Periferico.cámara}, new List<Juego>() {Juego.LineageII}, new Dictionary<string, string> {{"RAM","1GB"}, {"Procesador","Intel 4004"}, {"Placa de video","9600GT"}}),
                new Computadora("C06", new List<Software>(){Software.icq,Software.messenger}, new List<Periferico>() {Periferico.micrófono}, new List<Juego>() {Juego.WarcraftIII}, new Dictionary<string, string> {{"RAM","4GB"}, {"Procesador","Intel Pentium 4"}, {"Placa de video","486 DLC"}}),
                new Computadora("C07", new List<Software>(){Software.messenger,Software.office}, new List<Periferico>() {Periferico.auriculares}, new List<Juego>() {Juego.MuOnline}, new Dictionary<string, string> {{"RAM","2GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video","Geforce 4"}}),
                new Computadora("C08", new List<Software>(){Software.office,Software.ares}, new List<Periferico>() {Periferico.cámara}, new List<Juego>() {Juego.CounterStrike}, new Dictionary<string, string> {{"RAM","4GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video","9600GT"}}),
                new Computadora("C09", new List<Software>(){Software.ares,Software.office}, new List<Periferico>() {Periferico.micrófono}, new List<Juego>() {Juego.DiabloII}, new Dictionary<string, string> {{"RAM","2GB"}, {"Procesador","Intel Pentium"}, {"Placa de video","486 DLC"}}),
                new Computadora("C10", new List<Software>(){Software.icq,Software.ares}, new List<Periferico>() {Periferico.auriculares}, new List<Juego>() {Juego.WarcraftIII}, new Dictionary<string, string> {{"RAM","1GB"}, {"Procesador","Intel 4004"}, {"Placa de video","9600GT"}}),
            };
            foreach (Equipo p in listaComputadora)
            {
                Usuario.AgregarEquipo(p);
            }
            List<Equipo> listaTelefonos = new List<Equipo>()
            {
                new Telefono("T01", TipoTecla.Disco, "Telefonica"),
                new Telefono("T02", TipoTecla.Teclado, "Panasonic"),
                new Telefono("T03", TipoTecla.Disco, "Elgin"),
                new Telefono("T04", TipoTecla.Teclado, "Siemens"),
                new Telefono("T05", TipoTecla.Disco, "Panasonic")
            };
            foreach (Equipo p in listaTelefonos)
            {
                Usuario.AgregarEquipo(p);
            }
        }
        #endregion

        #region Metodos del Form
        /// <summary>
        /// Sirve para confirmar el cerrado del programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCibercafe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Seguro de querer salir?", "Saliendo.....", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = msj == DialogResult.No;
        }
        /// <summary>
        /// Actualiza los clientes.
        /// Una vez que se le asignaron un equipo al cliente desaparecera de la lista de espera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_Activated(object sender, EventArgs e)
        {
            ActualizarClientes();
            ActualizarComputadoras();
            ActualizarTelefonos();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Actualiza la lista de clientes en espera.
        /// En otras palabras, saca a los clientes de la lista que ya fueron asignados a un equipo en particular.
        /// </summary>
        private void ActualizarClientes()
        {
            listCliente.Items.Clear();
            foreach (Cliente cliente in Usuario.Clientes)
            {
                listCliente.Items.Add(cliente.ToString());
            }
        }
        /// <summary>
        /// Actualiza listado computadoras asignandole el color lime (verde) si esta libre y el color crimson (rojo) si esta en uso.
        /// </summary>
        private void ActualizarComputadoras()
        {
            for (int i = 0; i < gpbComputadoras.Controls.Count; i++)
            {
                if (gpbComputadoras.Controls[i] is Label)
                {
                    foreach (Equipo e in Usuario.Lista)
                    {
                        if (gpbComputadoras.Controls[i].Text == e.Id)
                        {
                            if (e.Estado == Estado.Disponible)
                            {
                                gpbComputadoras.Controls[i].BackColor = Color.Lime;
                            }
                            else
                            {
                                gpbComputadoras.Controls[i].BackColor = Color.Crimson;
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Actualiza listado telefonos asignandole el color lime (verde) si esta libre y el color crimson (rojo) si esta en uso.
        /// </summary>
        private void ActualizarTelefonos()
        {
            for (int i = 0; i < gpbTelefonos.Controls.Count; i++)
            {
                if (gpbTelefonos.Controls[i] is Label)
                {
                    foreach (Equipo e in Usuario.Lista)
                    {
                        if (gpbTelefonos.Controls[i].Text == e.Id)
                        {
                            if (e.Estado == Estado.Disponible)
                            {
                                gpbTelefonos.Controls[i].BackColor = Color.Lime;
                            }
                            else
                            {
                                gpbTelefonos.Controls[i].BackColor = Color.Crimson;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        private void lblComputadoras_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefonos_Click(object sender, EventArgs e)
        {

        }
    }
}
