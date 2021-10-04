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
    public partial class FrmComputadoras : Form
    {
        #region Atributos
        protected Cliente cliente;
        #endregion

        #region Constructor
        public FrmComputadoras()
        {
            InitializeComponent();
        }

        public FrmComputadoras(Cliente cliente)
        {
            this.cliente = cliente;
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesconectar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConectar_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Se encarga de hardcodear los datos de las computadoras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmComputadoras_Load(object sender, EventArgs e)
        {
            List<Equipo> listaComputadora = new List<Equipo>()
            {
                new Computadora("C01", new List<Software>(){Software.ares}, new List<Periferico>() {Periferico.auriculares}, new List<Juego>() {Juego.CounterStrike},new Dictionary<string, string> {{"RAM", "4GB"}, {"Procesador","Intel Pentium 4"}, {"Placa de video","486 DLC"}}),
                new Computadora("C02", new List<Software>(){Software.icq}, new List<Periferico>() {Periferico.cámara}, new List<Juego>() {Juego.AgeOfEmpiresII}, new Dictionary<string, string> {{"RAM", "2GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video","Geforce 4"}}),
                new Computadora("C03", new List<Software>(){Software.messenger}, new List<Periferico>() {Periferico.micrófono}, new List<Juego>() {Juego.CounterStrike}, new Dictionary<string, string> {{"RAM","4GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video","9600GT"}}),
                new Computadora("C04", new List<Software>(){Software.office}, new List<Periferico>() {Periferico.auriculares}, new List<Juego>() {Juego.DiabloII}, new Dictionary<string, string> {{"RAM","2GB"}, {"Procesador", "Intel Pentium"}, {"Placa de video","486 DLC"}}),
                new Computadora("C05", new List<Software>(){Software.ares}, new List<Periferico>() {Periferico.cámara}, new List<Juego>() {Juego.LineageII}, new Dictionary<string, string> {{"RAM","1GB"}, {"Procesador","Intel 4004"}, {"Placa de video","9600GT"}}),
                new Computadora("C06", new List<Software>(){Software.icq}, new List<Periferico>() {Periferico.micrófono}, new List<Juego>() {Juego.WarcraftIII}, new Dictionary<string, string> {{"RAM","4GB"}, {"Procesador","Intel Pentium 4"}, {"Placa de video","486 DLC"}}),
                new Computadora("C07", new List<Software>(){Software.messenger}, new List<Periferico>() {Periferico.auriculares}, new List<Juego>() {Juego.MuOnline}, new Dictionary<string, string> {{"RAM","2GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video","Geforce 4"}}),
                new Computadora("C08", new List<Software>(){Software.office}, new List<Periferico>() {Periferico.cámara}, new List<Juego>() {Juego.CounterStrike}, new Dictionary<string, string> {{"RAM","4GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video","9600GT"}}),
                new Computadora("C09", new List<Software>(){Software.ares}, new List<Periferico>() {Periferico.micrófono}, new List<Juego>() {Juego.DiabloII}, new Dictionary<string, string> {{"RAM","2GB"}, {"Procesador","Intel Pentium"}, {"Placa de video","486 DLC"}}),
                new Computadora("C10", new List<Software>(){Software.icq}, new List<Periferico>() {Periferico.auriculares}, new List<Juego>() {Juego.WarcraftIII}, new Dictionary<string, string> {{"RAM","1GB"}, {"Procesador","Intel 4004"}, {"Placa de video","9600GT"}}),
            };
            foreach (Equipo p in listaComputadora)
            {
                Usuario.AgregarEquipo(p);
                
            }
            listComputadoras.Text = listaComputadora.ToString();

            //listEspecificaciones.Text = $"{cliente.ToString()}";
            //listEspecificaciones.Text = cliente.Servicio.ToString();
        }
        #endregion
    }
}
