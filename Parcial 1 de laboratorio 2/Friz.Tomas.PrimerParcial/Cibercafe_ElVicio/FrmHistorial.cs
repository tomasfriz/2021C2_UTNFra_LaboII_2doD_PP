using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cibercafe_ElVicio
{
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sirve para cerrar la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
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

        private void btnListCompu_Click(object sender, EventArgs e)
        {

        }

        private void btnListCabin_Click(object sender, EventArgs e)
        {

        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {

        }

        private void btnRecaudacion_Click(object sender, EventArgs e)
        {

        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {

        }

        private void btnPeriferico_Click(object sender, EventArgs e)
        {

        }

        private void btnJuego_Click(object sender, EventArgs e)
        {

        }
    }
}
