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

namespace Cibercafe_ElVicio
{
    public partial class FrmMenu : Form
    {
        /// <summary>
        /// Se encarga de hardcodear los datos de los clientes.
        /// </summary>
        public FrmMenu()
        {
            InitializeComponent();
            lblUsuario.Text = "Tomás Agustín Friz";
            lblFecha.Text = DateTime.Now.ToShortDateString();

            Cliente[] clientes = new Cliente[5];
            clientes[0] = new Cliente(41918909, "Tomás", "Friz", 22, "Computadora", Periferico.cámara, Hardware.procesador, Software.messenger, Juego.DiabloII);
            clientes[1] = new Cliente(31456980, "Gustavo", "Doria", 53, "Computadora", Periferico.micrófono, Hardware.ram, Software.office, Juego.CounterStrike);
            clientes[2] = new Cliente(36897132, "Belén", "Trinidad", 16, "Telefono", Tipo.Disco,Marcas.Siemens);
            clientes[3] = new Cliente(34067132, "Mauricio", "Prieto", 35, "Computadora", Periferico.auriculares, Hardware.ram, Software.ares, Juego.WarcraftIII);
            clientes[4] = new Cliente(27643934, "Brisa", "Catania", 76, "Telefono", Tipo.Teclado, Marcas.Panasonic);

            dgvEspera.DataSource = clientes;
        }

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
            if (MessageBox.Show("¿Está Seguro que Desea Salir, cerraras todas las ventanas abiertas?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                "-El datagridview te mostrara lo clientes en espera a tener una computadora o telefono y desapareceran de la lista si ya fueron atendidos.\n" +
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
            FrmComputadoras frmComputadoras = new FrmComputadoras();
            frmComputadoras.Show();
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

    }
}
