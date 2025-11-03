namespace projLeds
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDadoDec = new System.Windows.Forms.TextBox();
            this.txtDadoBin = new System.Windows.Forms.TextBox();
            this.txtDadoHex = new System.Windows.Forms.TextBox();
            this.btnLed1 = new System.Windows.Forms.Button();
            this.btnLed2 = new System.Windows.Forms.Button();
            this.btnLed3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDadoDec
            // 
            this.txtDadoDec.Location = new System.Drawing.Point(12, 20);
            this.txtDadoDec.Name = "txtDadoDec";
            this.txtDadoDec.Size = new System.Drawing.Size(100, 20);
            this.txtDadoDec.TabIndex = 0;
            // 
            // txtDadoBin
            // 
            this.txtDadoBin.Location = new System.Drawing.Point(127, 20);
            this.txtDadoBin.Name = "txtDadoBin";
            this.txtDadoBin.Size = new System.Drawing.Size(100, 20);
            this.txtDadoBin.TabIndex = 2;
            // 
            // txtDadoHex
            // 
            this.txtDadoHex.Location = new System.Drawing.Point(233, 20);
            this.txtDadoHex.Name = "txtDadoHex";
            this.txtDadoHex.Size = new System.Drawing.Size(100, 20);
            this.txtDadoHex.TabIndex = 3;
            // 
            // btnLed1
            // 
            this.btnLed1.Location = new System.Drawing.Point(284, 71);
            this.btnLed1.Name = "btnLed1";
            this.btnLed1.Size = new System.Drawing.Size(49, 23);
            this.btnLed1.TabIndex = 4;
            this.btnLed1.Text = "Led1";
            this.btnLed1.UseVisualStyleBackColor = true;
            this.btnLed1.Click += new System.EventHandler(this.btnLed1_Click);
            // 
            // btnLed2
            // 
            this.btnLed2.Location = new System.Drawing.Point(229, 71);
            this.btnLed2.Name = "btnLed2";
            this.btnLed2.Size = new System.Drawing.Size(49, 23);
            this.btnLed2.TabIndex = 5;
            this.btnLed2.Text = "Led2";
            this.btnLed2.UseVisualStyleBackColor = true;
            this.btnLed2.Click += new System.EventHandler(this.btnLed2_Click);
            // 
            // btnLed3
            // 
            this.btnLed3.Location = new System.Drawing.Point(168, 71);
            this.btnLed3.Name = "btnLed3";
            this.btnLed3.Size = new System.Drawing.Size(49, 23);
            this.btnLed3.TabIndex = 6;
            this.btnLed3.Text = "Led3";
            this.btnLed3.UseVisualStyleBackColor = true;
            this.btnLed3.Click += new System.EventHandler(this.btnLed3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 215);
            this.Controls.Add(this.btnLed3);
            this.Controls.Add(this.btnLed2);
            this.Controls.Add(this.btnLed1);
            this.Controls.Add(this.txtDadoHex);
            this.Controls.Add(this.txtDadoBin);
            this.Controls.Add(this.txtDadoDec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDadoDec;
        private System.Windows.Forms.TextBox txtDadoBin;
        private System.Windows.Forms.TextBox txtDadoHex;
        private System.Windows.Forms.Button btnLed1;
        private System.Windows.Forms.Button btnLed2;
        private System.Windows.Forms.Button btnLed3;
    }
}

