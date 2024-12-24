namespace DovizOfis
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
            this.LblDolarAlis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblDolarSatis = new System.Windows.Forms.Label();
            this.LblEuroAlis = new System.Windows.Forms.Label();
            this.LblEuroSatis = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtKur = new System.Windows.Forms.TextBox();
            this.BtnDolarAl = new System.Windows.Forms.Button();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDolarSat = new System.Windows.Forms.Button();
            this.BtnEuroAl = new System.Windows.Forms.Button();
            this.BtnEuroSat = new System.Windows.Forms.Button();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnSatisYap = new System.Windows.Forms.Button();
            this.BtnSatisYap2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // LblDolarAlis
            // 
            this.LblDolarAlis.AutoSize = true;
            this.LblDolarAlis.Location = new System.Drawing.Point(123, 9);
            this.LblDolarAlis.Name = "LblDolarAlis";
            this.LblDolarAlis.Size = new System.Drawing.Size(22, 24);
            this.LblDolarAlis.TabIndex = 1;
            this.LblDolarAlis.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dolar Satış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Euro Alış:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Euro Satış:";
            // 
            // LblDolarSatis
            // 
            this.LblDolarSatis.AutoSize = true;
            this.LblDolarSatis.Location = new System.Drawing.Point(123, 54);
            this.LblDolarSatis.Name = "LblDolarSatis";
            this.LblDolarSatis.Size = new System.Drawing.Size(22, 24);
            this.LblDolarSatis.TabIndex = 5;
            this.LblDolarSatis.Text = "0";
            // 
            // LblEuroAlis
            // 
            this.LblEuroAlis.AutoSize = true;
            this.LblEuroAlis.Location = new System.Drawing.Point(123, 137);
            this.LblEuroAlis.Name = "LblEuroAlis";
            this.LblEuroAlis.Size = new System.Drawing.Size(22, 24);
            this.LblEuroAlis.TabIndex = 6;
            this.LblEuroAlis.Text = "0";
            // 
            // LblEuroSatis
            // 
            this.LblEuroSatis.AutoSize = true;
            this.LblEuroSatis.Location = new System.Drawing.Point(123, 173);
            this.LblEuroSatis.Name = "LblEuroSatis";
            this.LblEuroSatis.Size = new System.Drawing.Size(22, 24);
            this.LblEuroSatis.TabIndex = 7;
            this.LblEuroSatis.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSatisYap2);
            this.groupBox1.Controls.Add(this.BtnSatisYap);
            this.groupBox1.Controls.Add(this.TxtKalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(281, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 232);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kur:";
            // 
            // TxtKur
            // 
            this.TxtKur.Location = new System.Drawing.Point(89, 18);
            this.TxtKur.Name = "TxtKur";
            this.TxtKur.Size = new System.Drawing.Size(344, 30);
            this.TxtKur.TabIndex = 9;
            this.TxtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // BtnDolarAl
            // 
            this.BtnDolarAl.Location = new System.Drawing.Point(281, 4);
            this.BtnDolarAl.Name = "BtnDolarAl";
            this.BtnDolarAl.Size = new System.Drawing.Size(42, 34);
            this.BtnDolarAl.TabIndex = 9;
            this.BtnDolarAl.Text = "...";
            this.BtnDolarAl.UseVisualStyleBackColor = true;
            this.BtnDolarAl.Click += new System.EventHandler(this.BtnDolarAl_Click);
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(89, 54);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(344, 30);
            this.TxtMiktar.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Miktar:";
            // 
            // BtnDolarSat
            // 
            this.BtnDolarSat.Location = new System.Drawing.Point(281, 49);
            this.BtnDolarSat.Name = "BtnDolarSat";
            this.BtnDolarSat.Size = new System.Drawing.Size(42, 34);
            this.BtnDolarSat.TabIndex = 10;
            this.BtnDolarSat.Text = "...";
            this.BtnDolarSat.UseVisualStyleBackColor = true;
            this.BtnDolarSat.Click += new System.EventHandler(this.BtnDolarSat_Click);
            // 
            // BtnEuroAl
            // 
            this.BtnEuroAl.Location = new System.Drawing.Point(281, 132);
            this.BtnEuroAl.Name = "BtnEuroAl";
            this.BtnEuroAl.Size = new System.Drawing.Size(42, 34);
            this.BtnEuroAl.TabIndex = 11;
            this.BtnEuroAl.Text = "...";
            this.BtnEuroAl.UseVisualStyleBackColor = true;
            this.BtnEuroAl.Click += new System.EventHandler(this.BtnEuroAl_Click);
            // 
            // BtnEuroSat
            // 
            this.BtnEuroSat.Location = new System.Drawing.Point(281, 168);
            this.BtnEuroSat.Name = "BtnEuroSat";
            this.BtnEuroSat.Size = new System.Drawing.Size(42, 34);
            this.BtnEuroSat.TabIndex = 12;
            this.BtnEuroSat.Text = "...";
            this.BtnEuroSat.UseVisualStyleBackColor = true;
            this.BtnEuroSat.Click += new System.EventHandler(this.BtnEuroSat_Click);
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(89, 90);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(344, 30);
            this.TxtTutar.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tutar:";
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(89, 126);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(344, 30);
            this.TxtKalan.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kalan:";
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.Location = new System.Drawing.Point(110, 162);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Size = new System.Drawing.Size(142, 36);
            this.BtnSatisYap.TabIndex = 16;
            this.BtnSatisYap.Text = "İşlem 1";
            this.BtnSatisYap.UseVisualStyleBackColor = true;
            this.BtnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // BtnSatisYap2
            // 
            this.BtnSatisYap2.Location = new System.Drawing.Point(258, 162);
            this.BtnSatisYap2.Name = "BtnSatisYap2";
            this.BtnSatisYap2.Size = new System.Drawing.Size(142, 36);
            this.BtnSatisYap2.TabIndex = 17;
            this.BtnSatisYap2.Text = "İşlem 2";
            this.BtnSatisYap2.UseVisualStyleBackColor = true;
            this.BtnSatisYap2.Click += new System.EventHandler(this.BtnSatisYap2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(932, 544);
            this.Controls.Add(this.BtnEuroSat);
            this.Controls.Add(this.BtnEuroAl);
            this.Controls.Add(this.BtnDolarSat);
            this.Controls.Add(this.BtnDolarAl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblEuroSatis);
            this.Controls.Add(this.LblEuroAlis);
            this.Controls.Add(this.LblDolarSatis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblDolarAlis);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "DÖVİZ SATIŞ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDolarAlis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblDolarSatis;
        private System.Windows.Forms.Label LblEuroAlis;
        private System.Windows.Forms.Label LblEuroSatis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtKur;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnDolarAl;
        private System.Windows.Forms.Button BtnSatisYap;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnDolarSat;
        private System.Windows.Forms.Button BtnEuroAl;
        private System.Windows.Forms.Button BtnEuroSat;
        private System.Windows.Forms.Button BtnSatisYap2;
    }
}

