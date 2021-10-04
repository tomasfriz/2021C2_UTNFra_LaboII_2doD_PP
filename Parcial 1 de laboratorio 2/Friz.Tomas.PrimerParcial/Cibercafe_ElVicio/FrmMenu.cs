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
        #region Constructor
        /// <summary>
        /// Coloca el nombre del usuario en la barra superior del form y tambien la hora actual.
        /// </summary>
        public FrmMenu()
        {
            InitializeComponent();
            lblUsuario.Text = "Tomás Agustín Friz";
            lblFecha.Text = DateTime.Now.ToShortDateString();
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
                "-El boton 'Mostrar Maquina' te permitira asignar una maquina al cliente y tambien detener el uso de la misma.\n" +
                "-El boton 'Mostrar Cabina' te permitira asignar una cabina al cliente y tambien detener el uso de la misma.\n" +
                "-El boton 'Estadisticas Historicas' te permitira ver el historial", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
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
        /// Sirve tanto para asignar las maquinas de los clientes como para que el usuario vea un registro de las maquinas en uso o disponibles.
        /// Tambien sirve para desconectar al cliente de la maquina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsigMaquina_Click(object sender, EventArgs e)
        {
            if (Usuario.Clientes.Count > 0)
            {
                Cliente c = Usuario.Clientes.Peek();
                FrmComputadoras frmComputadoras = new FrmComputadoras(c);
                frmComputadoras.Show();
            }
        }
        /// <summary>
        /// Sirve tanto para asignar las cabinas de los clientes como para que el usuario vea un registro de las cabinas en uso o disponibles.
        /// Tambien sirve para desconectar al cliente de la cabina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsigCabina_Click(object sender, EventArgs e)
        {
            FrmTelefonos frmTelefonos = new FrmTelefonos();
            frmTelefonos.Show();
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
            new Cliente(41918909, "Tomás", "Sánchez", 22, new ClienteComputadora(new List<Software>(){Software.ares},new List<Periferico>(){Periferico.cámara},new List<Juego>(){Juego.DiabloII})),
            new Cliente(34067132, "Mauricio", "Prieto", 35, new ClienteTelefono(54, 11, 48230912)),
            new Cliente(31456980, "Gustavo", "Doria", 53, new ClienteComputadora(new List<Software>(){Software.messenger},new List<Periferico>(){Periferico.micrófono},new List<Juego>(){Juego.CounterStrike})),
            new Cliente(36897132, "Belén", "Trinidad", 16, new ClienteTelefono(1, 378, 92740204)),
            new Cliente(27643934, "Brisa", "Quinteros", 48, new ClienteComputadora(new List<Software>(){Software.icq},new List<Periferico>(){Periferico.auriculares},new List<Juego>(){Juego.WarcraftIII})),
            new Cliente(19934027, "Pedro", "Macri", 61, new ClienteTelefono(54, 91, 62091837))};
            foreach (Cliente cliente in lista)
            {
                Usuario.AgregarCliente(cliente);
            }
            ActualizarClientes();
        }
        #endregion

        #region Metodos del Form
        /// <summary>
        /// Actualiza los clientes.
        /// Una vez que se le asignaron un equipo al cliente desaparecera de la lista de espera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_Activated(object sender, EventArgs e)
        {
            ActualizarClientes();
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
        #endregion
    }
}
