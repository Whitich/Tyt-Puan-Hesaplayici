namespace oodev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDogrut = new System.Windows.Forms.TextBox();
            this.txtYanlıst = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDogruM = new System.Windows.Forms.TextBox();
            this.txtYanlısM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDogruS = new System.Windows.Forms.TextBox();
            this.txtYanlısS = new System.Windows.Forms.TextBox();
            this.txtDogruF = new System.Windows.Forms.TextBox();
            this.txtYanlısF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğru";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yanlış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Türkçe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Net";
            // 
            // txtDogrut
            // 
            this.txtDogrut.Location = new System.Drawing.Point(71, 56);
            this.txtDogrut.Name = "txtDogrut";
            this.txtDogrut.Size = new System.Drawing.Size(100, 22);
            this.txtDogrut.TabIndex = 4;
            this.txtDogrut.Text = "0";
            this.txtDogrut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogrut_KeyPress);
            // 
            // txtYanlıst
            // 
            this.txtYanlıst.Location = new System.Drawing.Point(71, 100);
            this.txtYanlıst.Name = "txtYanlıst";
            this.txtYanlıst.Size = new System.Drawing.Size(100, 22);
            this.txtYanlıst.TabIndex = 5;
            this.txtYanlıst.Text = "0";
            this.txtYanlıst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYanlıst_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDogruM
            // 
            this.txtDogruM.Location = new System.Drawing.Point(239, 56);
            this.txtDogruM.Name = "txtDogruM";
            this.txtDogruM.Size = new System.Drawing.Size(100, 22);
            this.txtDogruM.TabIndex = 7;
            this.txtDogruM.Text = "0";
            this.txtDogruM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogruM_KeyPress);
            // 
            // txtYanlısM
            // 
            this.txtYanlısM.Location = new System.Drawing.Point(239, 100);
            this.txtYanlısM.Name = "txtYanlısM";
            this.txtYanlısM.Size = new System.Drawing.Size(100, 22);
            this.txtYanlısM.TabIndex = 8;
            this.txtYanlısM.Text = "0";
            this.txtYanlısM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYanlısM_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Matematik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Net";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sosyal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Net";
            // 
            // txtDogruS
            // 
            this.txtDogruS.Location = new System.Drawing.Point(417, 56);
            this.txtDogruS.Name = "txtDogruS";
            this.txtDogruS.Size = new System.Drawing.Size(100, 22);
            this.txtDogruS.TabIndex = 13;
            this.txtDogruS.Text = "0";
            this.txtDogruS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogruS_KeyPress);
            // 
            // txtYanlısS
            // 
            this.txtYanlısS.Location = new System.Drawing.Point(417, 100);
            this.txtYanlısS.Name = "txtYanlısS";
            this.txtYanlısS.Size = new System.Drawing.Size(100, 22);
            this.txtYanlısS.TabIndex = 14;
            this.txtYanlısS.Text = "0";
            this.txtYanlısS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYanlısS_KeyPress);
            // 
            // txtDogruF
            // 
            this.txtDogruF.Location = new System.Drawing.Point(605, 56);
            this.txtDogruF.Name = "txtDogruF";
            this.txtDogruF.Size = new System.Drawing.Size(100, 22);
            this.txtDogruF.TabIndex = 15;
            this.txtDogruF.Text = "0";
            this.txtDogruF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogruF_KeyPress);
            // 
            // txtYanlısF
            // 
            this.txtYanlısF.Location = new System.Drawing.Point(605, 100);
            this.txtYanlısF.Name = "txtYanlısF";
            this.txtYanlısF.Size = new System.Drawing.Size(100, 22);
            this.txtYanlısF.TabIndex = 16;
            this.txtYanlısF.Text = "0";
            this.txtYanlısF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYanlısF_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(602, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Net";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(238, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Toplam Net";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "TYT Puanı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 293);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYanlısF);
            this.Controls.Add(this.txtDogruF);
            this.Controls.Add(this.txtYanlısS);
            this.Controls.Add(this.txtDogruS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYanlısM);
            this.Controls.Add(this.txtDogruM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtYanlıst);
            this.Controls.Add(this.txtDogrut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDogrut;
        private System.Windows.Forms.TextBox txtYanlıst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDogruM;
        private System.Windows.Forms.TextBox txtYanlısM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDogruS;
        private System.Windows.Forms.TextBox txtYanlısS;
        private System.Windows.Forms.TextBox txtDogruF;
        private System.Windows.Forms.TextBox txtYanlısF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

