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
    public partial class FrmEspecificaciones : Form
    {
        public FrmEspecificaciones()
        {
            InitializeComponent();
        }

        private void FrmEspecificaciones_Load(object sender, EventArgs e)
        {
            rtbEspecificaciones.Text = Mostrar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ibtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+ El boton 'Ayuda' te ayudara a saber el funcionamiento de los botones.\n" +
               "+ El boton 'Cerrar' cierra la ventana actual.\n" +
               "+ Podras ver la lista de las especificaciones de las computadoras en el cuadro blanco del centro\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Muestra las especificaciones de las computadoras.
        /// </summary>
        /// <returns>Imprime la lista de computadoras</returns>
        private static string Mostrar()
        {
            StringBuilder sb = new();
            List<Equipo> e = new();
            foreach (Equipo equipo in Usuario.Lista)
            {
                if (equipo is Computadora)
                {
                    e.Add(equipo);
                }
            }
            foreach (Equipo equipo in e)
            {
                sb.AppendLine($"------------------------------------------------------------------");
                sb.AppendLine($"{equipo}\n");
                sb.AppendLine($"------------------------------------------------------------------");
            }
            return sb.ToString();
        }
    }
}
