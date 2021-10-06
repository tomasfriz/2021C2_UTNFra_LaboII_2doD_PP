
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCafe = new System.Windows.Forms.CheckBox();
            this.cbSoda = new System.Windows.Forms.CheckBox();
            this.cdDona = new System.Windows.Forms.CheckBox();
            this.cbTostado = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Factura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Location = new System.Drawing.Point(17, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Costo a pagar con IVA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPagar.Location = new System.Drawing.Point(120, 237);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(135, 28);
            this.btnPagar.TabIndex = 5;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Location = new System.Drawing.Point(17, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Duracion: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Location = new System.Drawing.Point(17, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Costo Bruto: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(387, 274);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFactura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbCafe;
        private System.Windows.Forms.CheckBox cbSoda;
        private System.Windows.Forms.CheckBox cdDona;
        private System.Windows.Forms.CheckBox cbTostado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}