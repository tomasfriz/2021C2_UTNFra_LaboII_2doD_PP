using Entidades;
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
    public partial class FrmEspecificaionClientes : Form
    {
        public FrmEspecificaionClientes()
        {
            InitializeComponent();

            Cliente[] clientes = new Cliente[5];
            clientes[0] = new Cliente(41918909, "Tomás", "Friz", 22, "Computadora", Periferico.cámara, Hardware.procesador,Software.messenger,Juego.DiabloII);
            clientes[1] = new Cliente(31456980, "Gustavo", "Doria", 53, "Computadora", Periferico.micrófono, Hardware.ram, Software.office, Juego.CounterStrike);
            clientes[2] = new Cliente(36897132, "Belén", "Trinidad", 16, "Telefono");
            clientes[3] = new Cliente(34067132, "Mauricio", "Prieto", 35, "Computadora", Periferico.auriculares, Hardware.ram, Software.ares, Juego.WarcraftIII);
            clientes[4] = new Cliente(27643934, "Brisa", "Catania", 76, "Telefono");

            dgvMostrar.DataSource = clientes;
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
