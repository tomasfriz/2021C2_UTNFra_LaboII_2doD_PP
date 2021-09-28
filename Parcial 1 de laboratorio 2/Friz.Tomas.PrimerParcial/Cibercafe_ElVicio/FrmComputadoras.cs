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
            //List<Computadora> clienteMaquina = new List<Computadora>();
            Computadora[] computadoras = new Computadora[10];
            computadoras[0] = new Computadora("",Software.ares, Periferico.auriculares, Juego.CounterStrike, Hardware.procesador,"Disponible");
            computadoras[1] = new Computadora("",Software.icq, Periferico.cámara, Juego.AgeOfEmpiresII, Hardware.placaDeVideo, "Disponible");
            computadoras[2] = new Computadora("",Software.messenger, Periferico.micrófono, Juego.DiabloII, Hardware.ram, "Disponible");
            computadoras[3] = new Computadora("",Software.office, Periferico.auriculares, Juego.LineageII, Hardware.placaDeVideo, "Disponible");
            computadoras[4] = new Computadora("",Software.ares, Periferico.cámara, Juego.MuOnline, Hardware.procesador, "Disponible");
            computadoras[5] = new Computadora("",Software.icq, Periferico.micrófono, Juego.WarcraftIII, Hardware.ram, "Disponible");
            computadoras[6] = new Computadora("",Software.messenger, Periferico.auriculares, Juego.AgeOfEmpiresII, Hardware.procesador, "Disponible");
            computadoras[7] = new Computadora("",Software.office, Periferico.cámara, Juego.CounterStrike, Hardware.placaDeVideo, "Disponible");
            computadoras[8] = new Computadora("",Software.ares, Periferico.micrófono, Juego.DiabloII, Hardware.ram, "Disponible");
            computadoras[9] = new Computadora("",Software.icq, Periferico.auriculares, Juego.LineageII, Hardware.procesador, "Disponible");

            dgvCompu.DataSource = computadoras;
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

        }
    }
}
