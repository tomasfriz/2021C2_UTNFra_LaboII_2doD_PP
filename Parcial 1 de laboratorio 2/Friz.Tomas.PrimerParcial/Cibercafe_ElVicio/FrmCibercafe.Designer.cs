
namespace Cibercafe_ElVicio
{
    partial class FrmCibercafe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCibercafe));
            this.btnAyuda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEspera = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspera)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            resources.ApplyResources(this.btnAyuda, "btnAyuda");
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Name = "label3";
            // 
            // lblFecha
            // 
            resources.ApplyResources(this.lblFecha, "lblFecha");
            this.lblFecha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblFecha.Name = "lblFecha";
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.dgvEspera);
            this.panel1.Name = "panel1";
            // 
            // dgvEspera
            // 
            this.dgvEspera.AllowUserToAddRows = false;
            this.dgvEspera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspera.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvEspera, "dgvEspera");
            this.dgvEspera.Name = "dgvEspera";
            this.dgvEspera.RowTemplate.Height = 25;
            this.dgvEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspera.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEspera_CellFormatting);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // FrmCibercafe
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyuda);
            this.Name = "FrmCibercafe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCibercafe_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvEspera;
    }
}

