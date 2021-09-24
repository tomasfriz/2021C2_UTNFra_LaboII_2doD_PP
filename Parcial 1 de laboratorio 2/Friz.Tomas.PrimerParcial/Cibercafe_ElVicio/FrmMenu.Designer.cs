
namespace Cibercafe_ElVicio
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
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
            this.btnEspecifClientes = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnAsigMaquina = new System.Windows.Forms.Button();
            this.btnAsigCabina = new System.Windows.Forms.Button();
            this.btnMostMaquina = new System.Windows.Forms.Button();
            this.btnMostCabina = new System.Windows.Forms.Button();
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
            this.dgvEspera.AllowUserToDeleteRows = false;
            this.dgvEspera.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.dgvEspera, "dgvEspera");
            this.dgvEspera.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspera.Name = "dgvEspera";
            this.dgvEspera.ReadOnly = true;
            this.dgvEspera.RowTemplate.Height = 25;
            this.dgvEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnEspecifClientes
            // 
            resources.ApplyResources(this.btnEspecifClientes, "btnEspecifClientes");
            this.btnEspecifClientes.Name = "btnEspecifClientes";
            this.btnEspecifClientes.UseVisualStyleBackColor = true;
            this.btnEspecifClientes.Click += new System.EventHandler(this.btnEspecifClientes_Click);
            // 
            // btnHistorial
            // 
            resources.ApplyResources(this.btnHistorial, "btnHistorial");
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnAsigMaquina
            // 
            resources.ApplyResources(this.btnAsigMaquina, "btnAsigMaquina");
            this.btnAsigMaquina.Name = "btnAsigMaquina";
            this.btnAsigMaquina.UseVisualStyleBackColor = true;
            this.btnAsigMaquina.Click += new System.EventHandler(this.btnAsigMaquina_Click);
            // 
            // btnAsigCabina
            // 
            resources.ApplyResources(this.btnAsigCabina, "btnAsigCabina");
            this.btnAsigCabina.Name = "btnAsigCabina";
            this.btnAsigCabina.UseVisualStyleBackColor = true;
            this.btnAsigCabina.Click += new System.EventHandler(this.btnAsigCabina_Click);
            // 
            // btnMostMaquina
            // 
            resources.ApplyResources(this.btnMostMaquina, "btnMostMaquina");
            this.btnMostMaquina.Name = "btnMostMaquina";
            this.btnMostMaquina.UseVisualStyleBackColor = true;
            this.btnMostMaquina.Click += new System.EventHandler(this.btnMostMaquina_Click);
            // 
            // btnMostCabina
            // 
            resources.ApplyResources(this.btnMostCabina, "btnMostCabina");
            this.btnMostCabina.Name = "btnMostCabina";
            this.btnMostCabina.UseVisualStyleBackColor = true;
            this.btnMostCabina.Click += new System.EventHandler(this.btnMostCabina_Click);
            // 
            // FrmMenu
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMostCabina);
            this.Controls.Add(this.btnMostMaquina);
            this.Controls.Add(this.btnAsigCabina);
            this.Controls.Add(this.btnAsigMaquina);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnEspecifClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyuda);
            this.Name = "FrmMenu";
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
        private System.Windows.Forms.Button btnEspecifClientes;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnAsigMaquina;
        private System.Windows.Forms.Button btnAsigCabina;
        private System.Windows.Forms.Button btnMostMaquina;
        private System.Windows.Forms.Button btnMostCabina;
    }
}

