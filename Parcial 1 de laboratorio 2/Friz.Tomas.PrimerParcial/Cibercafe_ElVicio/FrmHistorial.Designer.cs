
namespace Cibercafe_ElVicio
{
    partial class FrmHistorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListCompu = new System.Windows.Forms.Button();
            this.btnListCabin = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnGanancias = new System.Windows.Forms.Button();
            this.btnRecaudacion = new System.Windows.Forms.Button();
            this.btnSoftware = new System.Windows.Forms.Button();
            this.btnPeriferico = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListCompu
            // 
            this.btnListCompu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListCompu.Location = new System.Drawing.Point(10, 12);
            this.btnListCompu.Name = "btnListCompu";
            this.btnListCompu.Size = new System.Drawing.Size(487, 27);
            this.btnListCompu.TabIndex = 1;
            this.btnListCompu.Text = "Lista de computadoras ordenadas por minutos de uso de forma descendente";
            this.btnListCompu.UseVisualStyleBackColor = true;
            this.btnListCompu.Click += new System.EventHandler(this.btnListCompu_Click);
            // 
            // btnListCabin
            // 
            this.btnListCabin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListCabin.Location = new System.Drawing.Point(10, 45);
            this.btnListCabin.Name = "btnListCabin";
            this.btnListCabin.Size = new System.Drawing.Size(487, 23);
            this.btnListCabin.TabIndex = 2;
            this.btnListCabin.Text = "Lista de cabinas ordenadas por minutos de uso de forma descendente";
            this.btnListCabin.UseVisualStyleBackColor = true;
            this.btnListCabin.Click += new System.EventHandler(this.btnListCabin_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAyuda.Location = new System.Drawing.Point(12, 227);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 0;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnGanancias
            // 
            this.btnGanancias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGanancias.Location = new System.Drawing.Point(12, 74);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(485, 23);
            this.btnGanancias.TabIndex = 3;
            this.btnGanancias.Text = "Ganancias totales y clasificadas por servicio (teléfono/computadora)";
            this.btnGanancias.UseVisualStyleBackColor = true;
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // btnRecaudacion
            // 
            this.btnRecaudacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecaudacion.Location = new System.Drawing.Point(12, 103);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(485, 23);
            this.btnRecaudacion.TabIndex = 4;
            this.btnRecaudacion.Text = "Horas totales y la recaudación por tipo de llamada";
            this.btnRecaudacion.UseVisualStyleBackColor = true;
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // btnSoftware
            // 
            this.btnSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoftware.Location = new System.Drawing.Point(12, 133);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(485, 23);
            this.btnSoftware.TabIndex = 5;
            this.btnSoftware.Text = "El software más pedido por los clientes";
            this.btnSoftware.UseVisualStyleBackColor = true;
            this.btnSoftware.Click += new System.EventHandler(this.btnSoftware_Click);
            // 
            // btnPeriferico
            // 
            this.btnPeriferico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeriferico.Location = new System.Drawing.Point(12, 161);
            this.btnPeriferico.Name = "btnPeriferico";
            this.btnPeriferico.Size = new System.Drawing.Size(485, 23);
            this.btnPeriferico.TabIndex = 6;
            this.btnPeriferico.Text = "El periférico más pedido por los clientes";
            this.btnPeriferico.UseVisualStyleBackColor = true;
            this.btnPeriferico.Click += new System.EventHandler(this.btnPeriferico_Click);
            // 
            // btnJuego
            // 
            this.btnJuego.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJuego.Location = new System.Drawing.Point(12, 190);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(485, 23);
            this.btnJuego.TabIndex = 7;
            this.btnJuego.Text = "El juego más pedido por los clientes";
            this.btnJuego.UseVisualStyleBackColor = true;
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(422, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 253);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnJuego);
            this.Controls.Add(this.btnPeriferico);
            this.Controls.Add(this.btnSoftware);
            this.Controls.Add(this.btnRecaudacion);
            this.Controls.Add(this.btnGanancias);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnListCabin);
            this.Controls.Add(this.btnListCompu);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistorial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListCompu;
        private System.Windows.Forms.Button btnListCabin;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnGanancias;
        private System.Windows.Forms.Button btnRecaudacion;
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.Button btnPeriferico;
        private System.Windows.Forms.Button btnJuego;
        private System.Windows.Forms.Button btnSalir;
    }
}