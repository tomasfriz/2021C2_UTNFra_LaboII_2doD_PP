
namespace Cibercafe_ElVicio
{
    partial class FrmComputadoras
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCompu = new System.Windows.Forms.DataGridView();
            this.btnLibre = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompu)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(507, 362);
            this.panel1.TabIndex = 0;
            // 
            // dgvCompu
            // 
            this.dgvCompu.AllowUserToAddRows = false;
            this.dgvCompu.AllowUserToDeleteRows = false;
            this.dgvCompu.AllowUserToOrderColumns = true;
            this.dgvCompu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCompu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompu.Location = new System.Drawing.Point(0, 0);
            this.dgvCompu.MultiSelect = false;
            this.dgvCompu.Name = "dgvCompu";
            this.dgvCompu.ReadOnly = true;
            this.dgvCompu.RowTemplate.Height = 25;
            this.dgvCompu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompu.Size = new System.Drawing.Size(503, 358);
            this.dgvCompu.TabIndex = 0;
            // 
            // btnLibre
            // 
            this.btnLibre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLibre.Location = new System.Drawing.Point(198, 380);
            this.btnLibre.Name = "btnLibre";
            this.btnLibre.Size = new System.Drawing.Size(75, 23);
            this.btnLibre.TabIndex = 11;
            this.btnLibre.Text = "Conectar";
            this.btnLibre.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAyuda.Location = new System.Drawing.Point(14, 380);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 11;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(443, 380);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDesconectar.Location = new System.Drawing.Point(279, 380);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(75, 23);
            this.btnDesconectar.TabIndex = 13;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // FrmComputadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 410);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLibre);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmComputadoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmComputadoras";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLibre;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvCompu;
        private System.Windows.Forms.Button btnDesconectar;
    }
}