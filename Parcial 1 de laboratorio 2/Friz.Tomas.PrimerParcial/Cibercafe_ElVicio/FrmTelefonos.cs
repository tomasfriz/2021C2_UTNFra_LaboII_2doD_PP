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
        #region Atributos
        private ClienteTelefono clienteTelefono;
        private Cliente cliente;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor de FrmTelefonos.
        /// </summary>
        public FrmTelefonos()
        {
            InitializeComponent();
            clienteTelefono = (ClienteTelefono)cliente.Servicio; //posible excepcion no controlada.
            cliente = Usuario.Clientes.Peek();
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
            MessageBox.Show("+ El boton 'Ayuda' te ayudara a saber el funcionamiento de los botones.\n" +
                "+ El boton 'Cerrar' cierra la ventana actual.\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Sirve para agregar un cliente a un telefono.
        /// Posibilidad de marcar numero telefonico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            clienteTelefono.Codigo = txtCodigo.Text;
            clienteTelefono.Localidad = txtLocalidad.Text;
            clienteTelefono.Num = txtNumero.Text;
            ValidadorNuget validar = new ValidadorNuget();
            if (!(validar.Validate(clienteTelefono)).IsValid)
            {
                StringBuilder sb = new();
                foreach (var error in validar.Validate(clienteTelefono).Errors)
                {
                    sb.AppendLine($"+ {error.ErrorMessage}");
                }
                MessageBox.Show(sb.ToString(),"Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Equipo equipo in Usuario.EquipoDisponible)
                {
                    if (equipo.Id == (string)cmbTelefonos.SelectedItem)
                    {
                        if (Usuario.AgregarServicio(equipo,clienteTelefono))
                        {
                            Usuario.Clientes.Dequeue();
                        }
                    }
                }
                Close();
            }
        }
        /// <summary>
        /// Se encarga de cargar los datos de los telefonos y comparan si estan disponibles.
        /// Si no hay telefonos disponibles se bloquara el boton de llamar y se oscurecera a un color DarkGray (gris oscuro).
        /// </summary>
        private void FrmTelefonos_Load(object sender, EventArgs e)
        {
            List<string> telefono = new();
            foreach (Equipo equipo in Usuario.EquipoDisponible)
            {
                if (equipo is Telefono)
                {
                    if (equipo.Estado == Estado.Disponible)
                    {
                        telefono.Add(equipo.Id);
                    }
                }
            }
            if (telefono.Count > 0)
            {
                cmbTelefonos.DataSource = telefono;
            }
            else
            {
                btnLlamar.Enabled = false;
                btnLlamar.BackColor = Color.DarkGray;
                cmbTelefonos.Items.Add("No hay telefonos disponibles.");
            }
        }
        #endregion
    }
}
