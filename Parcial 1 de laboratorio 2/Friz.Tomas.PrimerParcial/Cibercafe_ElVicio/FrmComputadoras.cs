using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static Entidades.Enumerados;

namespace Cibercafe_ElVicio
{
    public partial class FrmComputadoras : Form
    {
        /// <summary>
        /// Se encarga de hardcodear los datos de las computadoras.
        /// </summary>
        public FrmComputadoras()
        {
            InitializeComponent();

            List<Computadora> clienteMaquina = new List<Computadora>();
            clienteMaquina.Add(new Computadora("C01", Software.ares, Periferico.auriculares, Juego.CounterStrike, Hardware.procesador, "Disponible"));
            clienteMaquina.Add(new Computadora("C02", Software.icq, Periferico.cámara, Juego.AgeOfEmpiresII, Hardware.placaDeVideo, "Disponible"));
            clienteMaquina.Add(new Computadora("C03", Software.messenger, Periferico.micrófono, Juego.DiabloII, Hardware.ram, "Disponible"));
            clienteMaquina.Add(new Computadora("C04", Software.office, Periferico.auriculares, Juego.LineageII, Hardware.placaDeVideo, "Disponible"));
            clienteMaquina.Add(new Computadora("C05", Software.ares, Periferico.cámara, Juego.MuOnline, Hardware.procesador, "Disponible"));
            clienteMaquina.Add(new Computadora("C06", Software.icq, Periferico.micrófono, Juego.WarcraftIII, Hardware.ram, "Disponible"));
            clienteMaquina.Add(new Computadora("C07", Software.messenger, Periferico.auriculares, Juego.AgeOfEmpiresII, Hardware.procesador, "Disponible"));
            clienteMaquina.Add(new Computadora("C08", Software.office, Periferico.cámara, Juego.CounterStrike, Hardware.placaDeVideo, "Disponible"));
            clienteMaquina.Add(new Computadora("C09", Software.ares, Periferico.micrófono, Juego.DiabloII, Hardware.ram, "Disponible"));
            clienteMaquina.Add(new Computadora("C10", Software.icq, Periferico.auriculares, Juego.LineageII, Hardware.procesador, "Disponible"));
            dgvClientes.DataSource = clienteMaquina;
        }
        /// <summary>
        /// Sirve para cerrar la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Sirve para orientar al usuario a saber que hace cada boton de la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-El boton 'Ayuda' te ayudara a saber el funcionamiento de los botones.\n" +
                "-El boton 'Cerrar' cierra la ventana actual.\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Computadora computadoraSeleccionado = (Computadora)dgvClientes.CurrentRow.DataBoundItem;
            //Cliente clienteSelecionado = (Cliente)dgvMaquina.CurrentRow.DataBoundItem;
            //if (computadoraSeleccionado.Equals(Cliente))
            //{

            //}
        }

        private void FrmComputadoras_Load(object sender, EventArgs e)
        {
            List<ClientesMaquina> clientesMaquinas = new List<ClientesMaquina>();
            clientesMaquinas.Add(new ClientesMaquina(41918909));
            clientesMaquinas.Add(new ClientesMaquina(31456980));
            clientesMaquinas.Add(new ClientesMaquina(34067132));
            clientesMaquinas.Add(new ClientesMaquina(36897132));
            clientesMaquinas.Add(new ClientesMaquina(27643934));
            dgvClientes.DataSource = clientesMaquinas;

            List<Computadora> computadoras = new List<Computadora>();
            computadoras.Add(new Computadora("C01", Software.ares, Periferico.auriculares, Juego.CounterStrike, Hardware.procesador, "Disponible"));
            computadoras.Add(new Computadora("C02", Software.icq, Periferico.cámara, Juego.AgeOfEmpiresII, Hardware.placaDeVideo, "Disponible"));
            computadoras.Add(new Computadora("C03", Software.messenger, Periferico.micrófono, Juego.DiabloII, Hardware.ram, "Disponible"));
            computadoras.Add(new Computadora("C04", Software.office, Periferico.auriculares, Juego.LineageII, Hardware.placaDeVideo, "Disponible"));
            computadoras.Add(new Computadora("C05", Software.ares, Periferico.cámara, Juego.MuOnline, Hardware.procesador, "Disponible"));
            computadoras.Add(new Computadora("C06", Software.icq, Periferico.micrófono, Juego.WarcraftIII, Hardware.ram, "Disponible"));
            computadoras.Add(new Computadora("C07", Software.messenger, Periferico.auriculares, Juego.AgeOfEmpiresII, Hardware.procesador, "Disponible"));
            computadoras.Add(new Computadora("C08", Software.office, Periferico.cámara, Juego.CounterStrike, Hardware.placaDeVideo, "Disponible"));
            computadoras.Add(new Computadora("C09", Software.ares, Periferico.micrófono, Juego.DiabloII, Hardware.ram, "Disponible"));
            computadoras.Add(new Computadora("C10", Software.icq, Periferico.auriculares, Juego.LineageII, Hardware.procesador, "Disponible"));
            dgvCompu.DataSource = computadoras;
        }
    }
}
