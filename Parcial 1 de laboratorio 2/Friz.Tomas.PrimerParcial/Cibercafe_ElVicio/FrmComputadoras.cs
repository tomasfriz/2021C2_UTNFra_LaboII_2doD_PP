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
    public partial class FrmComputadoras : Form
    {
        #region Atributos
        protected Cliente cliente;
        protected ClienteComputadora computadora;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor de FrmComputadoras.
        /// </summary>
        public FrmComputadoras()
        {
            InitializeComponent();
            cliente = Usuario.Clientes.Peek();
            computadora = (ClienteComputadora)cliente.Servicio;
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
        /// Sirve para conectar al cliente a una computadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (rbtLimitado.Checked == true && numTiempoLimite.Value % 30 != 0)
            {
                MessageBox.Show("La duración limitada debe limitarse en bloques de media hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbtIlimitado.Checked == true)
                {
                    computadora.Tipo = TipoCompu.Libre;
                }
                else
                {
                    computadora.Duracion = (int)numTiempoLimite.Value;
                    computadora.Tipo = TipoCompu.Limitado;
                }

                foreach (Equipo equipo in Usuario.Lista)
                {
                    if (equipo.Id == (string)cmbComputadoras.SelectedItem)
                    {
                        if (Usuario.AgregarServicio(equipo, computadora))
                        {
                            this.Close();
                            Usuario.Clientes.Dequeue();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Se encarga de cargar los datos del cliente, las especificaciones del mismo y las computadoras que coinciden con las especificaciones del cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmComputadoras_Load(object sender, EventArgs e)
        {
            lblDatos.Text = cliente.ToString();
            rctEspecificaciones.Text = computadora.MostrarEspecificaciones();
            rbtIlimitado.Checked = true;
            ListarComputadorasDisponibles();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra las computadoras disponibles que cumplen con los requerimientos del cliente.
        /// </summary>
        private void ListarComputadorasDisponibles()
        {
            List<string> computadorasDisponibles = new List<string>();

            foreach (Equipo e in Usuario.Lista)
            {
                if (e is Computadora)
                {
                    if (e.Estado == Estado.Disponible)
                    {
                        if (Usuario.RevisarRequisitos((ClienteComputadora)(cliente.Servicio), (Computadora)e))
                        {
                            computadorasDisponibles.Add(e.Id);
                        }
                    }
                }
            }
            if (computadorasDisponibles.Count > 0)
            {
                cmbComputadoras.DataSource = computadorasDisponibles;

            }
            else
            {                
                btnConectar.Enabled = false;
                btnConectar.BackColor = Color.DarkGray;
                cmbComputadoras.SelectedIndex = 0;
                cmbComputadoras.Items.Add("No hay computadoras disponibles");
            }
        }
        #endregion

        #region Metodos del form
        /// <summary>
        /// Se encarga de poner invisible el numTiempoLimite cuando el check esta marcado en tiempo ilimitado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtIlimitado_CheckedChanged(object sender, EventArgs e)
        {
            numTiempoLimite.Visible = false;
        }
        /// <summary>
        /// Se encarga de poner visible el numTiempoLimite cuando el check esta marcado en tiempo limitado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtLimitado_CheckedChanged(object sender, EventArgs e)
        {
            numTiempoLimite.Visible = true;
        }
        #endregion
    }
}
