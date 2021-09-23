
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
            this.cboxTemp = new System.Windows.Forms.ComboBox();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnLibre = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCompu = new System.Windows.Forms.DataGridView();
            this.btnDesconertar = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(599, 362);
            this.panel1.TabIndex = 0;
            // 
            // cboxTemp
            // 
            this.cboxTemp.FormattingEnabled = true;
            this.cboxTemp.Location = new System.Drawing.Point(135, 398);
            this.cboxTemp.Name = "cboxTemp";
            this.cboxTemp.Size = new System.Drawing.Size(59, 23);
            this.cboxTemp.TabIndex = 0;
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(200, 398);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(75, 23);
            this.btnTemp.TabIndex = 10;
            this.btnTemp.Text = "Conectar";
            this.btnTemp.UseVisualStyleBackColor = true;
            // 
            // btnLibre
            // 
            this.btnLibre.Location = new System.Drawing.Point(302, 397);
            this.btnLibre.Name = "btnLibre";
            this.btnLibre.Size = new System.Drawing.Size(75, 23);
            this.btnLibre.TabIndex = 11;
            this.btnLibre.Text = "Conectar";
            this.btnLibre.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(12, 398);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 11;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(536, 398);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(135, 377);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Temporizador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(302, 376);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Libre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCompu
            // 
            this.dgvCompu.AllowUserToAddRows = false;
            this.dgvCompu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompu.Location = new System.Drawing.Point(0, 0);
            this.dgvCompu.Name = "dgvCompu";
            this.dgvCompu.RowTemplate.Height = 25;
            this.dgvCompu.Size = new System.Drawing.Size(595, 358);
            this.dgvCompu.TabIndex = 0;
            // 
            // btnDesconertar
            // 
            this.btnDesconertar.Location = new System.Drawing.Point(415, 398);
            this.btnDesconertar.Name = "btnDesconertar";
            this.btnDesconertar.Size = new System.Drawing.Size(75, 23);
            this.btnDesconertar.TabIndex = 29;
            this.btnDesconertar.Text = "Desconectar";
            this.btnDesconertar.UseVisualStyleBackColor = true;
            // 
            // FrmComputadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 433);
            this.Controls.Add(this.btnDesconertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLibre);
            this.Controls.Add(this.cboxTemp);
            this.Controls.Add(this.btnTemp);
            this.Name = "FrmComputadoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmComputadoras";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLibre;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCompu;
        private System.Windows.Forms.Button btnDesconertar;
    }
}