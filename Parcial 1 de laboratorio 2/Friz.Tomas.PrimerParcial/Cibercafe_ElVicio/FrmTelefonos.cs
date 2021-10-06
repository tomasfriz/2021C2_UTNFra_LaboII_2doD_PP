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
    public partial class FrmTelefonos : Form
    {
        #region Constructor
        /// <summary>
        /// Costructor de frmTelefonos
        /// </summary>
        public FrmTelefonos()
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
        /// <summary>
        /// Sirve para agregar un cliente a un telefono.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLlamar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Se encarga de hardcodear los datos de los telefonos.
        /// </summary>
        private void FrmTelefonos_Load(object sender, EventArgs e)
        {
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
    }
}
