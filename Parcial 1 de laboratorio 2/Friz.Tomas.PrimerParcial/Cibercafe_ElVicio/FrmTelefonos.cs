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
        public FrmTelefonos()
        {
            InitializeComponent();
            Telefono[] telefonos = new Telefono[5];
            telefonos[0] = new Telefono(Tipo.Disco, Marcas.Siemens, "Disponible");
            telefonos[1] = new Telefono(Tipo.Teclado, Marcas.Panasonic, "Disponible");
            telefonos[2] = new Telefono(Tipo.Disco, Marcas.Siemens, "Disponible");
            telefonos[3] = new Telefono(Tipo.Teclado, Marcas.Panasonic, "Disponible");
            telefonos[4] = new Telefono(Tipo.Disco, Marcas.Siemens, "Disponible");

            dgvTelef.DataSource = telefonos;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-El boton 'Ayuda' te ayudara a saber el funcionamiento de los botones.\n" +
                "-El boton 'Cerrar' cierra la ventana actual.\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
