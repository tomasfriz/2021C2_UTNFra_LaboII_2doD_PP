
namespace Cibercafe_ElVicio
{
    partial class FrmMostrarTelefono
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnDesconertar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCompu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(478, 367);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 43;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnDesconertar
            // 
            this.btnDesconertar.Location = new System.Drawing.Point(232, 367);
            this.btnDesconertar.Name = "btnDesconertar";
            this.btnDesconertar.Size = new System.Drawing.Size(75, 23);
            this.btnDesconertar.TabIndex = 42;
            this.btnDesconertar.Text = "Desconectar";
            this.btnDesconertar.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(12, 367);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 41;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvCompu);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 349);
            this.panel1.TabIndex = 40;
            // 
            // dgvCompu
            // 
            this.dgvCompu.AllowUserToAddRows = false;
            this.dgvCompu.AllowUserToDeleteRows = false;
            this.dgvCompu.AllowUserToOrderColumns = true;
            this.dgvCompu.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCompu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompu.Location = new System.Drawing.Point(0, 0);
            this.dgvCompu.Name = "dgvCompu";
            this.dgvCompu.ReadOnly = true;
            this.dgvCompu.RowTemplate.Height = 25;
            this.dgvCompu.Size = new System.Drawing.Size(537, 345);
            this.dgvCompu.TabIndex = 0;
            // 
            // FrmMostrarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 400);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnDesconertar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMostrarTelefono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrarTelefono";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnDesconertar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCompu;
    }
}