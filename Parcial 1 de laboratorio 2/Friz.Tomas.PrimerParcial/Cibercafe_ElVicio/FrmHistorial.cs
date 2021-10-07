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
        #region Constructor
        /// <summary>
        /// Constructor de FrmHistorial.
        /// </summary>
        public FrmHistorial()
        {
            InitializeComponent();
        }
        #endregion

        #region Botones
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
            MessageBox.Show("+ El boton 'Ayuda' te ayudara a saber el funcionamiento de los botones.\n" +
                "+ El boton 'Cerrar' cierra la ventana actual.\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Muestra la lista de computadoras ordenadas por minutos de uso de forma descendente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListCompu_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Muestra la lista de cabinas ordenadas por minutos de uso de forma descendente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListCabin_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Muestra las ganancias totales y clasificadas por servicio (teléfono/computadora).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGanancias_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Muestra las horas totales y la recaudación por tipo de llamada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecaudacion_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Muestra el software más pedido por los clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSoftware_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Muestra el periférico más pedido por los clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeriferico_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Muestra el juego más pedido por los clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJuego_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
