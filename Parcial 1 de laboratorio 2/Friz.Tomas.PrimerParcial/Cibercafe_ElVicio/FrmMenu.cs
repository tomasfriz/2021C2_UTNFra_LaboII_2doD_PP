using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Cibercafe_ElVicio
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            lblUsuario.Text = "Tomás Agustín Friz";
            lblFecha.Text = DateTime.Now.ToShortDateString();
            
            Cliente[] clientes = new Cliente[5];

            clientes[0] = new Cliente();
            clientes[0].Dni = 41918909;
            clientes[0].Nombre = "Tomás";
            clientes[0].Apellido = "Friz";
            clientes[0].Edad = 22;
            clientes[0].Equipo = "Computadora";

            clientes[1] = new Cliente();
            clientes[1].Dni = 31456980;
            clientes[1].Nombre = "Gustavo";
            clientes[1].Apellido = "Doria";
            clientes[1].Edad = 53;
            clientes[1].Equipo = "Computadora";

            clientes[2] = new Cliente();
            clientes[2].Dni = 36897132;
            clientes[2].Nombre = "Belén";
            clientes[2].Apellido = "Trinidad";
            clientes[2].Edad = 16;
            clientes[2].Equipo = "Telefono";

            clientes[3] = new Cliente();
            clientes[3].Dni = 34067132;
            clientes[3].Nombre = "Mauricio";
            clientes[3].Apellido = "Prieto";
            clientes[3].Edad = 35;
            clientes[3].Equipo = "Computadora";

            clientes[4] = new Cliente();
            clientes[4].Dni = 27643934;
            clientes[4].Nombre = "Brisa";
            clientes[4].Apellido = "Catania";
            clientes[4].Edad = 76;
            clientes[4].Equipo = "Telefono";

            dgvEspera.DataSource = clientes;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está Seguro que Desea Salir, cerraras todas las ventanas abiertas?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-El boton 'Ayuda' te ayudara a saber el funcionamiento de los botones.\n" +
                "-El boton 'Cerrar' te preguntara si deseas cerrar. 'SI' cerrara la aplicacion, incluyendo las ventanas abiertas. 'NO' regresaras al menu principal.\n" +
                "-El datagridview te mostrara lo clientes en espera a tener una computadora o telefono y desapareceran de la lista si ya fueron atendidos.\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCibercafe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Seguro de querer salir?", "Saliendo.....", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = msj == DialogResult.No;
        }

        private void dgvEspera_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvEspera.Rows[e.RowIndex].DataBoundItem != null) && (dgvEspera.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = VincularPropiedad(dgvEspera.Rows[e.RowIndex].DataBoundItem, dgvEspera.Columns[e.ColumnIndex].DataPropertyName);
            }    
        }

        private string VincularPropiedad(object propiedad, string nomPropiedad)
        {
            string retValue;

            retValue = "";

            if (nomPropiedad.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = nomPropiedad.Substring(0, nomPropiedad.IndexOf("."));
                arrayProperties = propiedad.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = VincularPropiedad(propertyInfo.GetValue(propiedad, null), nomPropiedad.Substring(nomPropiedad.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = propiedad.GetType();
                propertyInfo = propertyType.GetProperty(nomPropiedad);
                retValue = propertyInfo.GetValue(propiedad, null).ToString();
            }

            return retValue;
        }
    }
}
