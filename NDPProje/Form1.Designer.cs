namespace NDPProje
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
            this.pbAtikResmi = new System.Windows.Forms.PictureBox();
            this.lbOrganikAtik = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.testtb = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSure = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAtKagit = new System.Windows.Forms.Button();
            this.btnAtOrganik = new System.Windows.Forms.Button();
            this.lbKagitAtik = new System.Windows.Forms.ListBox();
            this.progOrganik = new System.Windows.Forms.ProgressBar();
            this.progKagit = new System.Windows.Forms.ProgressBar();
            this.btnBosaltOrganik = new System.Windows.Forms.Button();
            this.btnBosaltKagit = new System.Windows.Forms.Button();
            this.btnBosaltMetal = new System.Windows.Forms.Button();
            this.btnBosaltCam = new System.Windows.Forms.Button();
            this.progMetal = new System.Windows.Forms.ProgressBar();
            this.progCam = new System.Windows.Forms.ProgressBar();
            this.lbMetalAtik = new System.Windows.Forms.ListBox();
            this.btnAtCam = new System.Windows.Forms.Button();
            this.btnAtMetal = new System.Windows.Forms.Button();
            this.lbCamAtik = new System.Windows.Forms.ListBox();
            this.camAtikKutusuBS = new System.Windows.Forms.BindingSource(this.components);
            this.kagitAtikKutusuBS = new System.Windows.Forms.BindingSource(this.components);
            this.atiklarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atikDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organikAtikKutusuBS = new System.Windows.Forms.BindingSource(this.components);
            this.metalAtikKutusuBS = new System.Windows.Forms.BindingSource(this.components);
            this.atikKutusuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atikKutusuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAtikResmi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camAtikKutusuBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kagitAtikKutusuBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atiklarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atikDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organikAtikKutusuBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalAtikKutusuBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atikKutusuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atikKutusuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAtikResmi
            // 
            this.pbAtikResmi.Location = new System.Drawing.Point(18, 19);
            this.pbAtikResmi.Name = "pbAtikResmi";
            this.pbAtikResmi.Size = new System.Drawing.Size(171, 161);
            this.pbAtikResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAtikResmi.TabIndex = 0;
            this.pbAtikResmi.TabStop = false;
            // 
            // lbOrganikAtik
            // 
            this.lbOrganikAtik.FormattingEnabled = true;
            this.lbOrganikAtik.Location = new System.Drawing.Point(228, 75);
            this.lbOrganikAtik.Name = "lbOrganikAtik";
            this.lbOrganikAtik.Size = new System.Drawing.Size(152, 186);
            this.lbOrganikAtik.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pbAtikResmi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.testtb);
            this.groupBox2.Controls.Add(this.btnCikis);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbPuan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnYeniOyun);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbSure);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 401);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // testtb
            // 
            this.testtb.Location = new System.Drawing.Point(44, 167);
            this.testtb.Name = "testtb";
            this.testtb.Size = new System.Drawing.Size(100, 20);
            this.testtb.TabIndex = 12;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(18, 322);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(171, 47);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PUAN";
            // 
            // lbPuan
            // 
            this.lbPuan.AutoSize = true;
            this.lbPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPuan.Location = new System.Drawing.Point(77, 247);
            this.lbPuan.Name = "lbPuan";
            this.lbPuan.Size = new System.Drawing.Size(42, 46);
            this.lbPuan.TabIndex = 10;
            this.lbPuan.Text = "0";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-18, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 10);
            this.label3.TabIndex = 8;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.Location = new System.Drawing.Point(18, 19);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(171, 47);
            this.btnYeniOyun.TabIndex = 0;
            this.btnYeniOyun.Text = "YENİ OYUN";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SÜRE";
            // 
            // lbSure
            // 
            this.lbSure.AutoSize = true;
            this.lbSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSure.Location = new System.Drawing.Point(77, 119);
            this.lbSure.Name = "lbSure";
            this.lbSure.Size = new System.Drawing.Size(42, 46);
            this.lbSure.TabIndex = 7;
            this.lbSure.Text = "0";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(228, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "ATIK KUTULARI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAtKagit
            // 
            this.btnAtKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAtKagit.Location = new System.Drawing.Point(390, 43);
            this.btnAtKagit.Name = "btnAtKagit";
            this.btnAtKagit.Size = new System.Drawing.Size(154, 26);
            this.btnAtKagit.TabIndex = 12;
            this.btnAtKagit.Text = "KAĞIT";
            this.btnAtKagit.UseVisualStyleBackColor = true;
            this.btnAtKagit.Click += new System.EventHandler(this.btnAtKagit_Click_1);
            // 
            // btnAtOrganik
            // 
            this.btnAtOrganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAtOrganik.Location = new System.Drawing.Point(228, 43);
            this.btnAtOrganik.Name = "btnAtOrganik";
            this.btnAtOrganik.Size = new System.Drawing.Size(152, 26);
            this.btnAtOrganik.TabIndex = 15;
            this.btnAtOrganik.Text = "ORGANİK ATIK";
            this.btnAtOrganik.UseVisualStyleBackColor = true;
            this.btnAtOrganik.Click += new System.EventHandler(this.btnAtOrganik_Click_1);
            // 
            // lbKagitAtik
            // 
            this.lbKagitAtik.FormattingEnabled = true;
            this.lbKagitAtik.Location = new System.Drawing.Point(392, 75);
            this.lbKagitAtik.Name = "lbKagitAtik";
            this.lbKagitAtik.Size = new System.Drawing.Size(152, 186);
            this.lbKagitAtik.TabIndex = 16;
            // 
            // progOrganik
            // 
            this.progOrganik.Location = new System.Drawing.Point(228, 270);
            this.progOrganik.Name = "progOrganik";
            this.progOrganik.Size = new System.Drawing.Size(152, 23);
            this.progOrganik.Step = 1;
            this.progOrganik.TabIndex = 21;
            // 
            // progKagit
            // 
            this.progKagit.Location = new System.Drawing.Point(392, 270);
            this.progKagit.Name = "progKagit";
            this.progKagit.Size = new System.Drawing.Size(152, 23);
            this.progKagit.Step = 1;
            this.progKagit.TabIndex = 22;
            // 
            // btnBosaltOrganik
            // 
            this.btnBosaltOrganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosaltOrganik.Location = new System.Drawing.Point(228, 299);
            this.btnBosaltOrganik.Name = "btnBosaltOrganik";
            this.btnBosaltOrganik.Size = new System.Drawing.Size(152, 26);
            this.btnBosaltOrganik.TabIndex = 23;
            this.btnBosaltOrganik.Text = "BOŞALT";
            this.btnBosaltOrganik.UseVisualStyleBackColor = true;
            this.btnBosaltOrganik.Click += new System.EventHandler(this.btnBosaltOrganik_Click);
            // 
            // btnBosaltKagit
            // 
            this.btnBosaltKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosaltKagit.Location = new System.Drawing.Point(392, 299);
            this.btnBosaltKagit.Name = "btnBosaltKagit";
            this.btnBosaltKagit.Size = new System.Drawing.Size(152, 26);
            this.btnBosaltKagit.TabIndex = 24;
            this.btnBosaltKagit.Text = "BOŞALT";
            this.btnBosaltKagit.UseVisualStyleBackColor = true;
            this.btnBosaltKagit.Click += new System.EventHandler(this.btnBosaltKagit_Click);
            // 
            // btnBosaltMetal
            // 
            this.btnBosaltMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosaltMetal.Location = new System.Drawing.Point(392, 591);
            this.btnBosaltMetal.Name = "btnBosaltMetal";
            this.btnBosaltMetal.Size = new System.Drawing.Size(152, 26);
            this.btnBosaltMetal.TabIndex = 32;
            this.btnBosaltMetal.Text = "BOŞALT";
            this.btnBosaltMetal.UseVisualStyleBackColor = true;
            this.btnBosaltMetal.Click += new System.EventHandler(this.btnBosaltMetal_Click);
            // 
            // btnBosaltCam
            // 
            this.btnBosaltCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosaltCam.Location = new System.Drawing.Point(228, 591);
            this.btnBosaltCam.Name = "btnBosaltCam";
            this.btnBosaltCam.Size = new System.Drawing.Size(152, 26);
            this.btnBosaltCam.TabIndex = 31;
            this.btnBosaltCam.Text = "BOŞALT";
            this.btnBosaltCam.UseVisualStyleBackColor = true;
            this.btnBosaltCam.Click += new System.EventHandler(this.btnBosaltCam_Click);
            // 
            // progMetal
            // 
            this.progMetal.Location = new System.Drawing.Point(392, 562);
            this.progMetal.Name = "progMetal";
            this.progMetal.Size = new System.Drawing.Size(152, 23);
            this.progMetal.Step = 1;
            this.progMetal.TabIndex = 30;
            // 
            // progCam
            // 
            this.progCam.Location = new System.Drawing.Point(228, 562);
            this.progCam.Name = "progCam";
            this.progCam.Size = new System.Drawing.Size(152, 23);
            this.progCam.Step = 1;
            this.progCam.TabIndex = 0;
            // 
            // lbMetalAtik
            // 
            this.lbMetalAtik.FormattingEnabled = true;
            this.lbMetalAtik.Location = new System.Drawing.Point(392, 367);
            this.lbMetalAtik.Name = "lbMetalAtik";
            this.lbMetalAtik.Size = new System.Drawing.Size(152, 186);
            this.lbMetalAtik.TabIndex = 28;
            // 
            // btnAtCam
            // 
            this.btnAtCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAtCam.Location = new System.Drawing.Point(228, 335);
            this.btnAtCam.Name = "btnAtCam";
            this.btnAtCam.Size = new System.Drawing.Size(152, 26);
            this.btnAtCam.TabIndex = 27;
            this.btnAtCam.Text = "CAM";
            this.btnAtCam.UseVisualStyleBackColor = true;
            this.btnAtCam.Click += new System.EventHandler(this.btnAtCam_Click);
            // 
            // btnAtMetal
            // 
            this.btnAtMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAtMetal.Location = new System.Drawing.Point(390, 335);
            this.btnAtMetal.Name = "btnAtMetal";
            this.btnAtMetal.Size = new System.Drawing.Size(154, 26);
            this.btnAtMetal.TabIndex = 26;
            this.btnAtMetal.Text = "METAL";
            this.btnAtMetal.UseVisualStyleBackColor = true;
            this.btnAtMetal.Click += new System.EventHandler(this.btnAtMetal_Click_1);
            // 
            // lbCamAtik
            // 
            this.lbCamAtik.FormattingEnabled = true;
            this.lbCamAtik.Location = new System.Drawing.Point(228, 367);
            this.lbCamAtik.Name = "lbCamAtik";
            this.lbCamAtik.Size = new System.Drawing.Size(152, 186);
            this.lbCamAtik.TabIndex = 25;
            // 
            // atiklarBindingSource
            // 
            this.atiklarBindingSource.DataMember = "Atiklar";
            this.atiklarBindingSource.DataSource = this.atikKutusuBindingSource;
            // 
            // atikKutusuBindingSource
            // 
            this.atikKutusuBindingSource.DataSource = typeof(NDPProje.AtikKutusu);
            // 
            // atikKutusuBindingSource1
            // 
            this.atikKutusuBindingSource1.DataSource = typeof(NDPProje.AtikKutusu);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(554, 623);
            this.Controls.Add(this.btnBosaltMetal);
            this.Controls.Add(this.btnBosaltCam);
            this.Controls.Add(this.progMetal);
            this.Controls.Add(this.progCam);
            this.Controls.Add(this.lbMetalAtik);
            this.Controls.Add(this.btnAtCam);
            this.Controls.Add(this.btnAtMetal);
            this.Controls.Add(this.lbCamAtik);
            this.Controls.Add(this.btnBosaltKagit);
            this.Controls.Add(this.btnBosaltOrganik);
            this.Controls.Add(this.progKagit);
            this.Controls.Add(this.progOrganik);
            this.Controls.Add(this.lbKagitAtik);
            this.Controls.Add(this.btnAtOrganik);
            this.Controls.Add(this.btnAtKagit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbOrganikAtik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAtikResmi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camAtikKutusuBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kagitAtikKutusuBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atiklarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atikDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organikAtikKutusuBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalAtikKutusuBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atikKutusuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atikKutusuBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAtikResmi;
        private System.Windows.Forms.ListBox lbOrganikAtik;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPuan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAtKagit;
        private System.Windows.Forms.Button btnAtOrganik;
        private System.Windows.Forms.ListBox lbKagitAtik;
        private System.Windows.Forms.ProgressBar progOrganik;
        private System.Windows.Forms.ProgressBar progKagit;
        private System.Windows.Forms.Button btnBosaltOrganik;
        private System.Windows.Forms.Button btnBosaltKagit;
        private System.Windows.Forms.Button btnBosaltMetal;
        private System.Windows.Forms.Button btnBosaltCam;
        private System.Windows.Forms.ProgressBar progMetal;
        private System.Windows.Forms.ProgressBar progCam;
        private System.Windows.Forms.ListBox lbMetalAtik;
        private System.Windows.Forms.Button btnAtCam;
        private System.Windows.Forms.Button btnAtMetal;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.BindingSource atikDataBindingSource;
        private System.Windows.Forms.BindingSource organikAtikKutusuBS;
        private System.Windows.Forms.BindingSource metalAtikKutusuBS;
        private System.Windows.Forms.BindingSource kagitAtikKutusuBS;
        private System.Windows.Forms.BindingSource camAtikKutusuBS;
        private System.Windows.Forms.TextBox testtb;
        private System.Windows.Forms.BindingSource atikKutusuBindingSource;
        private System.Windows.Forms.ListBox lbCamAtik;
        private System.Windows.Forms.BindingSource atiklarBindingSource;
        private System.Windows.Forms.BindingSource atikKutusuBindingSource1;
    }
}

