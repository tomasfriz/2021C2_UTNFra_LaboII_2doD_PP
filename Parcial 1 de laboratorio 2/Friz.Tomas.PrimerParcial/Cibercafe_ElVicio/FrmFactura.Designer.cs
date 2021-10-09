
namespace Cibercafe_ElVicio
{
    partial class FrmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCafe = new System.Windows.Forms.CheckBox();
            this.cbSoda = new System.Windows.Forms.CheckBox();
            this.cdDona = new System.Windows.Forms.CheckBox();
            this.cbTostado = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Factura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIVA
            // 
            this.lblIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIVA.Location = new System.Drawing.Point(5, 205);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(180, 28);
            this.lblIVA.TabIndex = 4;
            this.lblIVA.Text = "Costo con IVA:";
            this.lblIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPagar.Location = new System.Drawing.Point(200, 237);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(182, 28);
            this.btnPagar.TabIndex = 5;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // lblDuracion
            // 
            this.lblDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuracion.Location = new System.Drawing.Point(5, 149);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(180, 28);
            this.lblDuracion.TabIndex = 10;
            this.lblDuracion.Text = "Duracion: ";
            this.lblDuracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCosto
            // 
            this.lblCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCosto.Location = new System.Drawing.Point(5, 177);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(180, 28);
            this.lblCosto.TabIndex = 11;
            this.lblCosto.Text = "Costo: ";
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Aperitivos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCafe
            // 
            this.cbCafe.Location = new System.Drawing.Point(32, 36);
            this.cbCafe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCafe.Name = "cbCafe";
            this.cbCafe.Size = new System.Drawing.Size(77, 23);
            this.cbCafe.TabIndex = 6;
            this.cbCafe.Text = "Cafe";
            this.cbCafe.UseVisualStyleBackColor = true;
            // 
            // cbSoda
            // 
            this.cbSoda.Location = new System.Drawing.Point(115, 36);
            this.cbSoda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSoda.Name = "cbSoda";
            this.cbSoda.Size = new System.Drawing.Size(77, 23);
            this.cbSoda.TabIndex = 7;
            this.cbSoda.Text = "Soda";
            this.cbSoda.UseVisualStyleBackColor = true;
            // 
            // cdDona
            // 
            this.cdDona.AutoSize = true;
            this.cdDona.Location = new System.Drawing.Point(282, 36);
            this.cdDona.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cdDona.Name = "cdDona";
            this.cdDona.Size = new System.Drawing.Size(60, 22);
            this.cdDona.TabIndex = 9;
            this.cdDona.Text = "Dona";
            this.cdDona.UseVisualStyleBackColor = true;
            // 
            // cbTostado
            // 
            this.cbTostado.AutoSize = true;
            this.cbTostado.Location = new System.Drawing.Point(199, 36);
            this.cbTostado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTostado.Name = "cbTostado";
            this.cbTostado.Size = new System.Drawing.Size(78, 22);
            this.cbTostado.TabIndex = 8;
            this.cbTostado.Text = "Tostado";
            this.cbTostado.UseVisualStyleBackColor = true;
            this.cbTostado.CheckedChanged += new System.EventHandler(this.cbTostado_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.groupBox1.Controls.Add(this.cbTostado);
            this.groupBox1.Controls.Add(this.cbCafe);
            this.groupBox1.Controls.Add(this.cbSoda);
            this.groupBox1.Controls.Add(this.cdDona);
            this.groupBox1.Location = new System.Drawing.Point(5, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 78);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de aperitivos";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAyuda.Location = new System.Drawing.Point(3, 237);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(182, 28);
            this.btnAyuda.TabIndex = 14;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(200, 151);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(182, 23);
            this.txtDuracion.TabIndex = 15;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(200, 179);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(182, 23);
            this.txtCosto.TabIndex = 16;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(200, 207);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(182, 23);
            this.txtIVA.TabIndex = 17;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(387, 274);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(403, 313);
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbCafe;
        private System.Windows.Forms.CheckBox cbSoda;
        private System.Windows.Forms.CheckBox cdDona;
        private System.Windows.Forms.CheckBox cbTostado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtIVA;
    }
}