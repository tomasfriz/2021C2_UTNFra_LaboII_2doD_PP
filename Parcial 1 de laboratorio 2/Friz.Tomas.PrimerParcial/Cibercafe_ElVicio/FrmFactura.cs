﻿using System;
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
    public partial class FrmFactura : Form
    {
        #region Constructor
        /// <summary>
        /// Constructor de Frmfactura
        /// </summary>
        public FrmFactura()
        {
            InitializeComponent();
        }
        #endregion

        #region Botones
        /// <summary>
        /// Sirve para pagar el uso de los equipos mas si pidio un aperitivo (incluye IVA integrado).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPagar_Click(object sender, EventArgs e)
        {

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
        /// Sirve para cerrar la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


    }
}
