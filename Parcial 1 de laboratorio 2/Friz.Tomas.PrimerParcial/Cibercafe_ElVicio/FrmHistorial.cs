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
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Sirve para orientar al usuario a saber que hace cada boton de la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+ El boton 'Ayuda' te ayudara a saber el funcionamiento de los botones.\n" +
                "+ El boton 'Cerrar' cierra la ventana actual.\n" +
                "+ En el cuadro blanco del lado derecho se mostraran la informacion de los botones.\n" +
                "+ En el primer boton del lado superior ordenara de forma decendente y por minutos de uso las computadoras.\n" +
                "+ En el segundo boton ordenara de forma decendente y por minutos de uso los telefonos.\n" +
                "+ En el tercer boton mostraran las ganancias totales y tambien segun su servicio.\n" +
                "+ En el cuarto boton mostraran las horas totales y tambien la recaudacion por tipo de llamadas.\n" +
                "+ En el quinto boton mostrara el software mas pedido por los clientes.\n" +
                "+ En el sexto boton mostrara el periferico mas pedido por los clientes.\n" +
                "+ En el septimo boton mostrara el juego mas pedido por los clientes.\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Muestra la lista de computadoras ordenadas por minutos de uso de forma descendente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnListCompu_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = Usuario.OrdenamientoDecendenteTiempo(TipoEquipo.Computadora);
        }
        /// <summary>
        /// Muestra la lista de cabinas ordenadas por minutos de uso de forma descendente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnListCabin_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = Usuario.OrdenamientoDecendenteTiempo(TipoEquipo.Cabina);
        }
        /// <summary>
        /// Muestra las ganancias totales y clasificadas por servicio (teléfono/computadora).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGanancias_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = Usuario.CalcularGanancias();
        }
        /// <summary>
        /// Muestra las horas totales y la recaudación por tipo de llamada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRecaudacion_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = "Falta terminar";
        }
        /// <summary>
        /// Muestra el software más pedido por los clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSoftware_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = "Falta terminar";
        }
        /// <summary>
        /// Muestra el periférico más pedido por los clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPeriferico_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = "Falta terminar";
        }
        /// <summary>
        /// Muestra el juego más pedido por los clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnJuego_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = "Falta terminar";
        }
        #endregion
    }
}
