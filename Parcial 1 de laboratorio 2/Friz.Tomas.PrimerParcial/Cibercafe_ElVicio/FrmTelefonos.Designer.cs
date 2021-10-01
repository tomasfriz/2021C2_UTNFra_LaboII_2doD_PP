
namespace Cibercafe_ElVicio
{
    partial class FrmTelefonos
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
            this.btnAyuda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColgar = new System.Windows.Forms.Button();
            this.listCliente = new System.Windows.Forms.ListBox();
            this.listCabina = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(375, 352);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(72, 28);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAyuda.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAyuda.Location = new System.Drawing.Point(141, 351);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(72, 29);
            this.btnAyuda.TabIndex = 0;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.listCabina);
            this.panel1.Controls.Add(this.listCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 287);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(16, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Clientes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(292, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cabina";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(141, 302);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Codigo Pais";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLlamar
            // 
            this.btnLlamar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLlamar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLlamar.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLlamar.Location = new System.Drawing.Point(219, 352);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(72, 28);
            this.btnLlamar.TabIndex = 4;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = false;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(141, 325);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(219, 325);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox3.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(297, 326);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 23);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 303);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Prefijo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(296, 303);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Numero Telefonico";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnColgar
            // 
            this.btnColgar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnColgar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnColgar.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnColgar.Location = new System.Drawing.Point(297, 352);
            this.btnColgar.Name = "btnColgar";
            this.btnColgar.Size = new System.Drawing.Size(72, 28);
            this.btnColgar.TabIndex = 5;
            this.btnColgar.Text = "Colgar";
            this.btnColgar.UseVisualStyleBackColor = false;
            this.btnColgar.Click += new System.EventHandler(this.btnColgar_Click);
            // 
            // listCliente
            // 
            this.listCliente.FormattingEnabled = true;
            this.listCliente.ItemHeight = 18;
            this.listCliente.Location = new System.Drawing.Point(3, 36);
            this.listCliente.Name = "listCliente";
            this.listCliente.Size = new System.Drawing.Size(274, 238);
            this.listCliente.TabIndex = 17;
            this.listCliente.SelectedIndexChanged += new System.EventHandler(this.listCliente_SelectedIndexChanged);
            // 
            // listCabina
            // 
            this.listCabina.FormattingEnabled = true;
            this.listCabina.ItemHeight = 18;
            this.listCabina.Location = new System.Drawing.Point(294, 36);
            this.listCabina.Name = "listCabina";
            this.listCabina.Size = new System.Drawing.Size(274, 238);
            this.listCabina.TabIndex = 18;
            // 
            // FrmTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(599, 386);
            this.Controls.Add(this.btnColgar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLlamar);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmTelefonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTelefonos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColgar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listCliente;
        private System.Windows.Forms.ListBox listCabina;
    }
}