namespace G201210057_MUHAMMET_BARIŞ_YILMAZ
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BILGILER_label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sayac_label3 = new System.Windows.Forms.Label();
            this.BASLA_button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kati_button1 = new System.Windows.Forms.Button();
            this.sivi_button2 = new System.Windows.Forms.Button();
            this.a_textBox1 = new System.Windows.Forms.TextBox();
            this.c_textBox2 = new System.Windows.Forms.TextBox();
            this.sivi_textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pure_textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "image1.jpg");
            this.ımageList1.Images.SetKeyName(1, "image2.jpg");
            this.ımageList1.Images.SetKeyName(2, "image3.jpg");
            this.ımageList1.Images.SetKeyName(3, "image4.jpg");
            this.ımageList1.Images.SetKeyName(4, "image5.jpg");
            this.ımageList1.Images.SetKeyName(5, "image6.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(299, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BILGILER_label1
            // 
            this.BILGILER_label1.AutoSize = true;
            this.BILGILER_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BILGILER_label1.Location = new System.Drawing.Point(1, 1);
            this.BILGILER_label1.Name = "BILGILER_label1";
            this.BILGILER_label1.Size = new System.Drawing.Size(0, 17);
            this.BILGILER_label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(112, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "KALAN SÜRE  ";
            // 
            // sayac_label3
            // 
            this.sayac_label3.AutoSize = true;
            this.sayac_label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sayac_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayac_label3.Location = new System.Drawing.Point(256, 7);
            this.sayac_label3.Name = "sayac_label3";
            this.sayac_label3.Size = new System.Drawing.Size(23, 25);
            this.sayac_label3.TabIndex = 3;
            this.sayac_label3.Text = "0";
            // 
            // BASLA_button1
            // 
            this.BASLA_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BASLA_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BASLA_button1.Location = new System.Drawing.Point(3, 4);
            this.BASLA_button1.Name = "BASLA_button1";
            this.BASLA_button1.Size = new System.Drawing.Size(106, 31);
            this.BASLA_button1.TabIndex = 4;
            this.BASLA_button1.Text = "BAŞLA";
            this.BASLA_button1.UseVisualStyleBackColor = false;
            this.BASLA_button1.Click += new System.EventHandler(this.BASLA_button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BILGILER_label1);
            this.panel1.Location = new System.Drawing.Point(299, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 114);
            this.panel1.TabIndex = 5;
            // 
            // kati_button1
            // 
            this.kati_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kati_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kati_button1.Location = new System.Drawing.Point(3, 41);
            this.kati_button1.Name = "kati_button1";
            this.kati_button1.Size = new System.Drawing.Size(138, 46);
            this.kati_button1.TabIndex = 6;
            this.kati_button1.Text = "KATI MEYVE";
            this.kati_button1.UseVisualStyleBackColor = false;
            this.kati_button1.Click += new System.EventHandler(this.kati_button1_Click);
            // 
            // sivi_button2
            // 
            this.sivi_button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sivi_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sivi_button2.Location = new System.Drawing.Point(141, 41);
            this.sivi_button2.Name = "sivi_button2";
            this.sivi_button2.Size = new System.Drawing.Size(138, 46);
            this.sivi_button2.TabIndex = 7;
            this.sivi_button2.Text = "SIVI MEYVE";
            this.sivi_button2.UseVisualStyleBackColor = false;
            this.sivi_button2.Click += new System.EventHandler(this.sivi_button2_Click);
            // 
            // a_textBox1
            // 
            this.a_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.a_textBox1.Location = new System.Drawing.Point(161, 124);
            this.a_textBox1.Name = "a_textBox1";
            this.a_textBox1.ReadOnly = true;
            this.a_textBox1.Size = new System.Drawing.Size(127, 23);
            this.a_textBox1.TabIndex = 8;
            this.a_textBox1.Text = "0";
            this.a_textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c_textBox2
            // 
            this.c_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.c_textBox2.Location = new System.Drawing.Point(161, 176);
            this.c_textBox2.Name = "c_textBox2";
            this.c_textBox2.ReadOnly = true;
            this.c_textBox2.Size = new System.Drawing.Size(127, 23);
            this.c_textBox2.TabIndex = 9;
            this.c_textBox2.Text = "0";
            this.c_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sivi_textBox3
            // 
            this.sivi_textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sivi_textBox3.Location = new System.Drawing.Point(161, 228);
            this.sivi_textBox3.Name = "sivi_textBox3";
            this.sivi_textBox3.ReadOnly = true;
            this.sivi_textBox3.Size = new System.Drawing.Size(127, 23);
            this.sivi_textBox3.TabIndex = 10;
            this.sivi_textBox3.Text = "0";
            this.sivi_textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(2, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "TOPLAM SIVI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(2, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "TOPLAM C VİTAMİNİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(2, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "TOPLAM A VİTAMİNİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "TOPLAM PÜRE";
            // 
            // pure_textBox4
            // 
            this.pure_textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pure_textBox4.Location = new System.Drawing.Point(161, 280);
            this.pure_textBox4.Name = "pure_textBox4";
            this.pure_textBox4.ReadOnly = true;
            this.pure_textBox4.Size = new System.Drawing.Size(127, 23);
            this.pure_textBox4.TabIndex = 16;
            this.pure_textBox4.Text = "0";
            this.pure_textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(486, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pure_textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sivi_textBox3);
            this.Controls.Add(this.c_textBox2);
            this.Controls.Add(this.a_textBox1);
            this.Controls.Add(this.sivi_button2);
            this.Controls.Add(this.kati_button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BASLA_button1);
            this.Controls.Add(this.sayac_label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BILGILER_label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sayac_label3;
        private System.Windows.Forms.Button BASLA_button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kati_button1;
        private System.Windows.Forms.Button sivi_button2;
        private System.Windows.Forms.TextBox a_textBox1;
        private System.Windows.Forms.TextBox c_textBox2;
        private System.Windows.Forms.TextBox sivi_textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pure_textBox4;
    }
}

