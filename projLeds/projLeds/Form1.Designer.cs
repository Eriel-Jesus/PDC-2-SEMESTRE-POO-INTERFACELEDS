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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDadoDec = new System.Windows.Forms.TextBox();
            this.txtDadoBin = new System.Windows.Forms.TextBox();
            this.txtDadoHex = new System.Windows.Forms.TextBox();
            this.btnLed1 = new System.Windows.Forms.Button();
            this.btnLed2 = new System.Windows.Forms.Button();
            this.btnLed3 = new System.Windows.Forms.Button();
            this.picLed1 = new System.Windows.Forms.PictureBox();
            this.picLed2 = new System.Windows.Forms.PictureBox();
            this.picLed3 = new System.Windows.Forms.PictureBox();
            this.picLed4 = new System.Windows.Forms.PictureBox();
            this.btnLed4 = new System.Windows.Forms.Button();
            this.picLed8 = new System.Windows.Forms.PictureBox();
            this.btnLed8 = new System.Windows.Forms.Button();
            this.picLed7 = new System.Windows.Forms.PictureBox();
            this.picLed6 = new System.Windows.Forms.PictureBox();
            this.picLed5 = new System.Windows.Forms.PictureBox();
            this.btnLed7 = new System.Windows.Forms.Button();
            this.btnLed6 = new System.Windows.Forms.Button();
            this.btnLed5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDadoDec
            // 
            this.txtDadoDec.Location = new System.Drawing.Point(171, 189);
            this.txtDadoDec.Name = "txtDadoDec";
            this.txtDadoDec.Size = new System.Drawing.Size(100, 20);
            this.txtDadoDec.TabIndex = 0;
            // 
            // txtDadoBin
            // 
            this.txtDadoBin.Location = new System.Drawing.Point(288, 189);
            this.txtDadoBin.Name = "txtDadoBin";
            this.txtDadoBin.Size = new System.Drawing.Size(100, 20);
            this.txtDadoBin.TabIndex = 2;
            // 
            // txtDadoHex
            // 
            this.txtDadoHex.Location = new System.Drawing.Point(408, 189);
            this.txtDadoHex.Name = "txtDadoHex";
            this.txtDadoHex.Size = new System.Drawing.Size(100, 20);
            this.txtDadoHex.TabIndex = 3;
            // 
            // btnLed1
            // 
            this.btnLed1.Location = new System.Drawing.Point(611, 143);
            this.btnLed1.Name = "btnLed1";
            this.btnLed1.Size = new System.Drawing.Size(49, 23);
            this.btnLed1.TabIndex = 4;
            this.btnLed1.Text = "Led1";
            this.btnLed1.UseVisualStyleBackColor = true;
            this.btnLed1.Click += new System.EventHandler(this.btnLed1_Click);
            // 
            // btnLed2
            // 
            this.btnLed2.Location = new System.Drawing.Point(528, 143);
            this.btnLed2.Name = "btnLed2";
            this.btnLed2.Size = new System.Drawing.Size(49, 23);
            this.btnLed2.TabIndex = 5;
            this.btnLed2.Text = "Led2";
            this.btnLed2.UseVisualStyleBackColor = true;
            this.btnLed2.Click += new System.EventHandler(this.btnLed2_Click);
            // 
            // btnLed3
            // 
            this.btnLed3.Location = new System.Drawing.Point(449, 143);
            this.btnLed3.Name = "btnLed3";
            this.btnLed3.Size = new System.Drawing.Size(49, 23);
            this.btnLed3.TabIndex = 6;
            this.btnLed3.Text = "Led3";
            this.btnLed3.UseVisualStyleBackColor = true;
            this.btnLed3.Click += new System.EventHandler(this.btnLed3_Click);
            // 
            // picLed1
            // 
            this.picLed1.Image = global::projLeds.Properties.Resources.lamp_apagada;
            this.picLed1.Location = new System.Drawing.Point(598, 38);
            this.picLed1.Name = "picLed1";
            this.picLed1.Size = new System.Drawing.Size(74, 85);
            this.picLed1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLed1.TabIndex = 7;
            this.picLed1.TabStop = false;
            // 
            // picLed2
            // 
            this.picLed2.Image = ((System.Drawing.Image)(resources.GetObject("picLed2.Image")));
            this.picLed2.Location = new System.Drawing.Point(516, 38);
            this.picLed2.Name = "picLed2";
            this.picLed2.Size = new System.Drawing.Size(74, 85);
            this.picLed2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLed2.TabIndex = 8;
            this.picLed2.TabStop = false;
            // 
            // picLed3
            // 
            this.picLed3.Image = ((System.Drawing.Image)(resources.GetObject("picLed3.Image")));
            this.picLed3.Location = new System.Drawing.Point(434, 38);
            this.picLed3.Name = "picLed3";
            this.picLed3.Size = new System.Drawing.Size(74, 85);
            this.picLed3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLed3.TabIndex = 9;
            this.picLed3.TabStop = false;
            // 
            // picLed4
            // 
            this.picLed4.Image = ((System.Drawing.Image)(resources.GetObject("picLed4.Image")));
            this.picLed4.Location = new System.Drawing.Point(354, 38);
            this.picLed4.Name = "picLed4";
            this.picLed4.Size = new System.Drawing.Size(74, 85);
            this.picLed4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLed4.TabIndex = 11;
            this.picLed4.TabStop = false;
            // 
            // btnLed4
            // 
            this.btnLed4.Location = new System.Drawing.Point(365, 143);
            this.btnLed4.Name = "btnLed4";
            this.btnLed4.Size = new System.Drawing.Size(49, 23);
            this.btnLed4.TabIndex = 10;
            this.btnLed4.Text = "Led4";
            this.btnLed4.UseVisualStyleBackColor = true;
            this.btnLed4.Click += new System.EventHandler(this.btnLed4_Click);
            // 
            // picLed8
            // 
            this.picLed8.Image = ((System.Drawing.Image)(resources.GetObject("picLed8.Image")));
            this.picLed8.Location = new System.Drawing.Point(25, 38);
            this.picLed8.Name = "picLed8";
            this.picLed8.Size = new System.Drawing.Size(74, 85);
            this.picLed8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLed8.TabIndex = 19;
            this.picLed8.TabStop = false;
            // 
            // btnLed8
            // 
            this.btnLed8.Location = new System.Drawing.Point(38, 143);
            this.btnLed8.Name = "btnLed8";
            this.btnLed8.Size = new System.Drawing.Size(49, 23);
            this.btnLed8.TabIndex = 18;
            this.btnLed8.Text = "Led8";
            this.btnLed8.UseVisualStyleBackColor = true;
            this.btnLed8.Click += new System.EventHandler(this.btnLed8_Click);
            // 
            // picLed7
            // 
            this.picLed7.Image = ((System.Drawing.Image)(resources.GetObject("picLed7.Image")));
            this.picLed7.Location = new System.Drawing.Point(113, 38);
            this.picLed7.Name = "picLed7";
            this.picLed7.Size = new System.Drawing.Size(74, 85);
            this.picLed7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLed7.TabIndex = 17;
            this.picLed7.TabStop = false;
            // 
            // picLed6
            // 
            this.picLed6.Image = ((System.Drawing.Image)(resources.GetObject("picLed6.Image")));
            this.picLed6.Location = new System.Drawing.Point(196, 38);
            this.picLed6.Name = "picLed6";
            this.picLed6.Size = new System.Drawing.Size(74, 85);
            this.picLed6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLed6.TabIndex = 16;
            this.picLed6.TabStop = false;
            // 
            // picLed5
            // 
            this.picLed5.Image = ((System.Drawing.Image)(resources.GetObject("picLed5.Image")));
            this.picLed5.Location = new System.Drawing.Point(275, 38);
            this.picLed5.Name = "picLed5";
            this.picLed5.Size = new System.Drawing.Size(74, 85);
            this.picLed5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLed5.TabIndex = 15;
            this.picLed5.TabStop = false;
            // 
            // btnLed7
            // 
            this.btnLed7.Location = new System.Drawing.Point(127, 143);
            this.btnLed7.Name = "btnLed7";
            this.btnLed7.Size = new System.Drawing.Size(49, 23);
            this.btnLed7.TabIndex = 14;
            this.btnLed7.Text = "Led7";
            this.btnLed7.UseVisualStyleBackColor = true;
            this.btnLed7.Click += new System.EventHandler(this.btnLed7_Click);
            // 
            // btnLed6
            // 
            this.btnLed6.Location = new System.Drawing.Point(207, 143);
            this.btnLed6.Name = "btnLed6";
            this.btnLed6.Size = new System.Drawing.Size(49, 23);
            this.btnLed6.TabIndex = 13;
            this.btnLed6.Text = "Led6";
            this.btnLed6.UseVisualStyleBackColor = true;
            this.btnLed6.Click += new System.EventHandler(this.btnLed6_Click);
            // 
            // btnLed5
            // 
            this.btnLed5.Location = new System.Drawing.Point(287, 143);
            this.btnLed5.Name = "btnLed5";
            this.btnLed5.Size = new System.Drawing.Size(49, 23);
            this.btnLed5.TabIndex = 12;
            this.btnLed5.Text = "Led5";
            this.btnLed5.UseVisualStyleBackColor = true;
            this.btnLed5.Click += new System.EventHandler(this.btnLed5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 231);
            this.Controls.Add(this.picLed8);
            this.Controls.Add(this.btnLed8);
            this.Controls.Add(this.picLed7);
            this.Controls.Add(this.picLed6);
            this.Controls.Add(this.picLed5);
            this.Controls.Add(this.btnLed7);
            this.Controls.Add(this.btnLed6);
            this.Controls.Add(this.btnLed5);
            this.Controls.Add(this.picLed4);
            this.Controls.Add(this.btnLed4);
            this.Controls.Add(this.picLed3);
            this.Controls.Add(this.picLed2);
            this.Controls.Add(this.picLed1);
            this.Controls.Add(this.btnLed3);
            this.Controls.Add(this.btnLed2);
            this.Controls.Add(this.btnLed1);
            this.Controls.Add(this.txtDadoHex);
            this.Controls.Add(this.txtDadoBin);
            this.Controls.Add(this.txtDadoDec);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLed5)).EndInit();
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
        private System.Windows.Forms.PictureBox picLed1;
        private System.Windows.Forms.PictureBox picLed2;
        private System.Windows.Forms.PictureBox picLed3;
        private System.Windows.Forms.PictureBox picLed4;
        private System.Windows.Forms.Button btnLed4;
        private System.Windows.Forms.PictureBox picLed8;
        private System.Windows.Forms.Button btnLed8;
        private System.Windows.Forms.PictureBox picLed7;
        private System.Windows.Forms.PictureBox picLed6;
        private System.Windows.Forms.PictureBox picLed5;
        private System.Windows.Forms.Button btnLed7;
        private System.Windows.Forms.Button btnLed6;
        private System.Windows.Forms.Button btnLed5;
    }
}

