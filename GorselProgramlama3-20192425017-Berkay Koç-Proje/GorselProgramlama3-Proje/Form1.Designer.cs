
namespace GorselProgramlama3_Proje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OgrenciKayitOl = new System.Windows.Forms.Button();
            this.btn_OgrenciGiris = new System.Windows.Forms.Button();
            this.btn_AdminGirisYap = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.txt_OkulNo = new System.Windows.Forms.TextBox();
            this.pictureBox_KizOgrenci = new System.Windows.Forms.PictureBox();
            this.pictureBox_Admin = new System.Windows.Forms.PictureBox();
            this.pictureBox_ErkekOgrenci = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_KizOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ErkekOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sifre.Location = new System.Drawing.Point(147, 294);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(150, 26);
            this.txt_Sifre.TabIndex = 1;
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(147, 234);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(150, 26);
            this.txt_KullaniciAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // btn_OgrenciKayitOl
            // 
            this.btn_OgrenciKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OgrenciKayitOl.Location = new System.Drawing.Point(452, 416);
            this.btn_OgrenciKayitOl.Name = "btn_OgrenciKayitOl";
            this.btn_OgrenciKayitOl.Size = new System.Drawing.Size(106, 37);
            this.btn_OgrenciKayitOl.TabIndex = 7;
            this.btn_OgrenciKayitOl.Text = " Kayıt Ol";
            this.btn_OgrenciKayitOl.UseVisualStyleBackColor = true;
            this.btn_OgrenciKayitOl.Click += new System.EventHandler(this.btn_OgrenciKayitOl_Click);
            // 
            // btn_OgrenciGiris
            // 
            this.btn_OgrenciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OgrenciGiris.Location = new System.Drawing.Point(655, 410);
            this.btn_OgrenciGiris.Name = "btn_OgrenciGiris";
            this.btn_OgrenciGiris.Size = new System.Drawing.Size(106, 43);
            this.btn_OgrenciGiris.TabIndex = 8;
            this.btn_OgrenciGiris.Text = "Giriş";
            this.btn_OgrenciGiris.UseVisualStyleBackColor = true;
            this.btn_OgrenciGiris.Click += new System.EventHandler(this.btn_OgrenciGiris_Click);
            // 
            // btn_AdminGirisYap
            // 
            this.btn_AdminGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AdminGirisYap.Location = new System.Drawing.Point(147, 368);
            this.btn_AdminGirisYap.Name = "btn_AdminGirisYap";
            this.btn_AdminGirisYap.Size = new System.Drawing.Size(104, 37);
            this.btn_AdminGirisYap.TabIndex = 9;
            this.btn_AdminGirisYap.Text = "Giriş";
            this.btn_AdminGirisYap.UseVisualStyleBackColor = true;
            this.btn_AdminGirisYap.Click += new System.EventHandler(this.btn_AdminGirisYap_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(610, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 26);
            this.textBox1.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(450, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Parola:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(450, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Kullanıcı Adi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(450, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(452, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(450, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Okul No:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ad.Location = new System.Drawing.Point(610, 210);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(151, 26);
            this.txt_Ad.TabIndex = 37;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyad.Location = new System.Drawing.Point(610, 259);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(151, 26);
            this.txt_Soyad.TabIndex = 36;
            // 
            // txt_Parola
            // 
            this.txt_Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Parola.Location = new System.Drawing.Point(610, 355);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(151, 26);
            this.txt_Parola.TabIndex = 35;
            // 
            // txt_OkulNo
            // 
            this.txt_OkulNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_OkulNo.Location = new System.Drawing.Point(610, 161);
            this.txt_OkulNo.Name = "txt_OkulNo";
            this.txt_OkulNo.Size = new System.Drawing.Size(151, 26);
            this.txt_OkulNo.TabIndex = 34;
            // 
            // pictureBox_KizOgrenci
            // 
            this.pictureBox_KizOgrenci.Image = global::GorselProgramlama3_Proje.Properties.Resources.graduation_hat;
            this.pictureBox_KizOgrenci.Location = new System.Drawing.Point(622, 12);
            this.pictureBox_KizOgrenci.Name = "pictureBox_KizOgrenci";
            this.pictureBox_KizOgrenci.Size = new System.Drawing.Size(139, 120);
            this.pictureBox_KizOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_KizOgrenci.TabIndex = 47;
            this.pictureBox_KizOgrenci.TabStop = false;
            // 
            // pictureBox_Admin
            // 
            this.pictureBox_Admin.Image = global::GorselProgramlama3_Proje.Properties.Resources.Users_Administrator_icon;
            this.pictureBox_Admin.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Admin.InitialImage")));
            this.pictureBox_Admin.Location = new System.Drawing.Point(109, 12);
            this.pictureBox_Admin.Name = "pictureBox_Admin";
            this.pictureBox_Admin.Size = new System.Drawing.Size(148, 120);
            this.pictureBox_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Admin.TabIndex = 46;
            this.pictureBox_Admin.TabStop = false;
            // 
            // pictureBox_ErkekOgrenci
            // 
            this.pictureBox_ErkekOgrenci.Image = global::GorselProgramlama3_Proje.Properties.Resources.graduated;
            this.pictureBox_ErkekOgrenci.Location = new System.Drawing.Point(456, 12);
            this.pictureBox_ErkekOgrenci.Name = "pictureBox_ErkekOgrenci";
            this.pictureBox_ErkekOgrenci.Size = new System.Drawing.Size(139, 120);
            this.pictureBox_ErkekOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ErkekOgrenci.TabIndex = 45;
            this.pictureBox_ErkekOgrenci.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 475);
            this.Controls.Add(this.pictureBox_KizOgrenci);
            this.Controls.Add(this.pictureBox_Admin);
            this.Controls.Add(this.pictureBox_ErkekOgrenci);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_OkulNo);
            this.Controls.Add(this.btn_AdminGirisYap);
            this.Controls.Add(this.btn_OgrenciGiris);
            this.Controls.Add(this.btn_OgrenciKayitOl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.txt_Sifre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_KizOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ErkekOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OgrenciKayitOl;
        private System.Windows.Forms.Button btn_OgrenciGiris;
        private System.Windows.Forms.Button btn_AdminGirisYap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.TextBox txt_OkulNo;
        private System.Windows.Forms.PictureBox pictureBox_ErkekOgrenci;
        private System.Windows.Forms.PictureBox pictureBox_Admin;
        private System.Windows.Forms.PictureBox pictureBox_KizOgrenci;
    }
}

