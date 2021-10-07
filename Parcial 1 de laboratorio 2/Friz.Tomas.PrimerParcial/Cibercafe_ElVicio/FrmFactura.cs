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
    public partial class FrmFactura : Form
    {
        #region Atributos
        private Servicio factura;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor de Frmfactura
        /// </summary>
        public FrmFactura()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="servicio"></param>
        public FrmFactura(Servicio s): this()
        {
            factura = s;
        }
        #endregion

        #region Botones
        /// <summary>
        /// Sirve para pagar el uso de los equipos mas si pidio un aperitivo (incluye IVA integrado).
        /// Cierra la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPagar_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Sirve para orientar al usuario a saber que hace cada boton de la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+ El boton 'Ayuda' te ayudara a saber el funcionamiento de los botones.\n" +
                "+ El boton 'Pagar' sirve para pagar el servicio y si compraste un aperitivo y cierra la ventana actual.\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Sirve para imprimir la duracion, el costo general, y el costo con IVA del servicio que solicito el cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFactura_Load(object sender, EventArgs e)
        {
            lblDuracion.Text = $"Duracion: {factura.Duracion} minutos";
            lblCosto.Text = $"Costo: ${factura.Costo}";
            lblIVA.Text = $"Costo con IVA: ${factura.AgregarIVA()}";
        }
        #endregion
    }
}
