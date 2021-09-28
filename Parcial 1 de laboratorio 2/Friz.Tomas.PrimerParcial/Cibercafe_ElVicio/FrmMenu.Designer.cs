
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCabina = new System.Windows.Forms.DataGridView();
            this.dgvMaquina = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periferico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hardware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Software = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnAsigMaquina = new System.Windows.Forms.Button();
            this.btnAsigCabina = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            resources.ApplyResources(this.btnAyuda, "btnAyuda");
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAyuda.ForeColor = System.Drawing.Color.Black;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(172)))), ((int)(((byte)(245)))));
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(172)))), ((int)(((byte)(245)))));
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(172)))), ((int)(((byte)(245)))));
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(172)))), ((int)(((byte)(245)))));
            this.label3.Name = "label3";
            // 
            // lblFecha
            // 
            resources.ApplyResources(this.lblFecha, "lblFecha");
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(172)))), ((int)(((byte)(245)))));
            this.lblFecha.Name = "lblFecha";
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvCabina);
            this.panel1.Controls.Add(this.dgvMaquina);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Name = "panel1";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dgvCabina
            // 
            this.dgvCabina.AllowUserToAddRows = false;
            this.dgvCabina.AllowUserToDeleteRows = false;
            this.dgvCabina.AllowUserToOrderColumns = true;
            this.dgvCabina.BackgroundColor = System.Drawing.Color.White;
            this.dgvCabina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabina.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.dgvCabina, "dgvCabina");
            this.dgvCabina.MultiSelect = false;
            this.dgvCabina.Name = "dgvCabina";
            this.dgvCabina.ReadOnly = true;
            this.dgvCabina.RowTemplate.Height = 25;
            this.dgvCabina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dgvMaquina
            // 
            this.dgvMaquina.AllowUserToDeleteRows = false;
            this.dgvMaquina.AllowUserToOrderColumns = true;
            this.dgvMaquina.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaquina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.Edad,
            this.Equipo,
            this.Periferico,
            this.Hardware,
            this.Software,
            this.Juego});
            this.dgvMaquina.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.dgvMaquina, "dgvMaquina");
            this.dgvMaquina.MultiSelect = false;
            this.dgvMaquina.Name = "dgvMaquina";
            this.dgvMaquina.ReadOnly = true;
            this.dgvMaquina.RowTemplate.Height = 25;
            this.dgvMaquina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Dni
            // 
            resources.ApplyResources(this.Dni, "Dni");
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Nombre
            // 
            resources.ApplyResources(this.Nombre, "Nombre");
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            resources.ApplyResources(this.Apellido, "Apellido");
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Edad
            // 
            resources.ApplyResources(this.Edad, "Edad");
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Equipo
            // 
            resources.ApplyResources(this.Equipo, "Equipo");
            this.Equipo.Name = "Equipo";
            this.Equipo.ReadOnly = true;
            // 
            // Periferico
            // 
            resources.ApplyResources(this.Periferico, "Periferico");
            this.Periferico.Name = "Periferico";
            this.Periferico.ReadOnly = true;
            // 
            // Hardware
            // 
            resources.ApplyResources(this.Hardware, "Hardware");
            this.Hardware.Name = "Hardware";
            this.Hardware.ReadOnly = true;
            // 
            // Software
            // 
            resources.ApplyResources(this.Software, "Software");
            this.Software.Name = "Software";
            this.Software.ReadOnly = true;
            // 
            // Juego
            // 
            resources.ApplyResources(this.Juego, "Juego");
            this.Juego.Name = "Juego";
            this.Juego.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.label4.Name = "label4";
            // 
            // btnHistorial
            // 
            resources.ApplyResources(this.btnHistorial, "btnHistorial");
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnAsigMaquina
            // 
            resources.ApplyResources(this.btnAsigMaquina, "btnAsigMaquina");
            this.btnAsigMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAsigMaquina.Name = "btnAsigMaquina";
            this.btnAsigMaquina.UseVisualStyleBackColor = false;
            this.btnAsigMaquina.Click += new System.EventHandler(this.btnAsigMaquina_Click);
            // 
            // btnAsigCabina
            // 
            resources.ApplyResources(this.btnAsigCabina, "btnAsigCabina");
            this.btnAsigCabina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAsigCabina.Name = "btnAsigCabina";
            this.btnAsigCabina.UseVisualStyleBackColor = false;
            this.btnAsigCabina.Click += new System.EventHandler(this.btnAsigCabina_Click);
            // 
            // FrmMenu
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.btnAsigCabina);
            this.Controls.Add(this.btnAsigMaquina);
            this.Controls.Add(this.btnHistorial);
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
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquina)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvMaquina;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnAsigMaquina;
        private System.Windows.Forms.Button btnAsigCabina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCabina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periferico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hardware;
        private System.Windows.Forms.DataGridViewTextBoxColumn Software;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juego;
    }
}

