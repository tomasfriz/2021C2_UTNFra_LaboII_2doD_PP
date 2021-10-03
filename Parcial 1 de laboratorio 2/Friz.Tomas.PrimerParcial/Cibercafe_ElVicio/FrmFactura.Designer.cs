
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
            this.rtbFactura = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.cbCafe = new System.Windows.Forms.CheckBox();
            this.cbSoda = new System.Windows.Forms.CheckBox();
            this.cbTostado = new System.Windows.Forms.CheckBox();
            this.cdDona = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbFactura
            // 
            this.rtbFactura.Location = new System.Drawing.Point(12, 34);
            this.rtbFactura.Name = "rtbFactura";
            this.rtbFactura.Size = new System.Drawing.Size(403, 154);
            this.rtbFactura.TabIndex = 0;
            this.rtbFactura.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total: $";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(297, 218);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(118, 23);
            this.btnPagar.TabIndex = 5;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // cbCafe
            // 
            this.cbCafe.Location = new System.Drawing.Point(78, 194);
            this.cbCafe.Name = "cbCafe";
            this.cbCafe.Size = new System.Drawing.Size(67, 19);
            this.cbCafe.TabIndex = 6;
            this.cbCafe.Text = "Cafe";
            this.cbCafe.UseVisualStyleBackColor = true;
            // 
            // cbSoda
            // 
            this.cbSoda.Location = new System.Drawing.Point(151, 194);
            this.cbSoda.Name = "cbSoda";
            this.cbSoda.Size = new System.Drawing.Size(67, 19);
            this.cbSoda.TabIndex = 7;
            this.cbSoda.Text = "Soda";
            this.cbSoda.UseVisualStyleBackColor = true;
            // 
            // cbTostado
            // 
            this.cbTostado.AutoSize = true;
            this.cbTostado.Location = new System.Drawing.Point(224, 194);
            this.cbTostado.Name = "cbTostado";
            this.cbTostado.Size = new System.Drawing.Size(67, 19);
            this.cbTostado.TabIndex = 8;
            this.cbTostado.Text = "Tostado";
            this.cbTostado.UseVisualStyleBackColor = true;
            // 
            // cdDona
            // 
            this.cdDona.AutoSize = true;
            this.cdDona.Location = new System.Drawing.Point(297, 194);
            this.cdDona.Name = "cdDona";
            this.cdDona.Size = new System.Drawing.Size(54, 19);
            this.cdDona.TabIndex = 9;
            this.cdDona.Text = "Dona";
            this.cdDona.UseVisualStyleBackColor = true;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 254);
            this.Controls.Add(this.cdDona);
            this.Controls.Add(this.cbTostado);
            this.Controls.Add(this.cbSoda);
            this.Controls.Add(this.cbCafe);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbFactura);
            this.MaximizeBox = false;
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.CheckBox cbCafe;
        private System.Windows.Forms.CheckBox cbSoda;
        private System.Windows.Forms.CheckBox cbTostado;
        private System.Windows.Forms.CheckBox cdDona;
    }
}