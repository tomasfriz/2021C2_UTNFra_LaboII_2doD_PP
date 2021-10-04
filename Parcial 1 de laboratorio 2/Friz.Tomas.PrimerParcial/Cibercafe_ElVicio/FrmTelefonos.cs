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
    public partial class FrmTelefonos : Form
    {
        /// <summary>
        /// Se encarga de hardcodear los datos de las computadoras.
        /// </summary>
        public FrmTelefonos()
        {
            InitializeComponent();
            //List<Telefono> clienteTelefono = new List<Telefono>();
            //clienteTelefono.Add(new Telefono("T01", Servicio.Disco, Marcas.Siemens, "disponible"));
            //clienteTelefono.Add(new Telefono("T02", Servicio.Teclado, Marcas.Panasonic, "disponible"));
            //clienteTelefono.Add(new Telefono("T03", Servicio.Disco, Marcas.Siemens, "disponible"));
            //clienteTelefono.Add(new Telefono("T04", Servicio.Teclado, Marcas.Panasonic, "disponible"));
            //clienteTelefono.Add(new Telefono("T05", Servicio.Disco, Marcas.Siemens, "disponible"));
            //dgvTelef.DataSource = clienteTelefono;
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

        private void btnLlamar_Click(object sender, EventArgs e)
        {

        }

        private void btnColgar_Click(object sender, EventArgs e)
        {

        }

        private void listCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
