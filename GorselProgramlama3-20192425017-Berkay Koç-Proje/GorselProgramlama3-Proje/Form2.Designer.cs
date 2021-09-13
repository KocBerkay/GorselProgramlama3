
namespace GorselProgramlama3_Proje
{
    partial class Form2
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
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_MasaEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MasaAdi = new System.Windows.Forms.TextBox();
            this.txt_MasaCalismaAlani = new System.Windows.Forms.TextBox();
            this.DGW_Masalar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MasaID = new System.Windows.Forms.TextBox();
            this.btn_OgrenciGoruntule = new System.Windows.Forms.Button();
            this.DGW_Gorevli_Ogrenciler = new System.Windows.Forms.DataGridView();
            this.btn_MasaSil = new System.Windows.Forms.Button();
            this.pictureBox_Masa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Masalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Gorevli_Ogrenciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Masa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.Location = new System.Drawing.Point(12, 42);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(75, 41);
            this.btn_Geri.TabIndex = 0;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_MasaEkle
            // 
            this.btn_MasaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MasaEkle.Location = new System.Drawing.Point(57, 225);
            this.btn_MasaEkle.Name = "btn_MasaEkle";
            this.btn_MasaEkle.Size = new System.Drawing.Size(106, 59);
            this.btn_MasaEkle.TabIndex = 1;
            this.btn_MasaEkle.Text = "Masa Ekle";
            this.btn_MasaEkle.UseVisualStyleBackColor = true;
            this.btn_MasaEkle.Click += new System.EventHandler(this.btn_MasaEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(132, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Masa Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Masa Çalışma Alanı:";
            // 
            // txt_MasaAdi
            // 
            this.txt_MasaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MasaAdi.Location = new System.Drawing.Point(241, 98);
            this.txt_MasaAdi.Name = "txt_MasaAdi";
            this.txt_MasaAdi.Size = new System.Drawing.Size(151, 26);
            this.txt_MasaAdi.TabIndex = 4;
            // 
            // txt_MasaCalismaAlani
            // 
            this.txt_MasaCalismaAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MasaCalismaAlani.Location = new System.Drawing.Point(241, 153);
            this.txt_MasaCalismaAlani.Name = "txt_MasaCalismaAlani";
            this.txt_MasaCalismaAlani.Size = new System.Drawing.Size(151, 26);
            this.txt_MasaCalismaAlani.TabIndex = 5;
            // 
            // DGW_Masalar
            // 
            this.DGW_Masalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Masalar.Location = new System.Drawing.Point(627, 35);
            this.DGW_Masalar.Name = "DGW_Masalar";
            this.DGW_Masalar.RowHeadersWidth = 51;
            this.DGW_Masalar.RowTemplate.Height = 24;
            this.DGW_Masalar.Size = new System.Drawing.Size(474, 300);
            this.DGW_Masalar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(139, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Masa ID:";
            // 
            // txt_MasaID
            // 
            this.txt_MasaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MasaID.Location = new System.Drawing.Point(241, 42);
            this.txt_MasaID.Name = "txt_MasaID";
            this.txt_MasaID.Size = new System.Drawing.Size(151, 26);
            this.txt_MasaID.TabIndex = 8;
            // 
            // btn_OgrenciGoruntule
            // 
            this.btn_OgrenciGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OgrenciGoruntule.Location = new System.Drawing.Point(241, 486);
            this.btn_OgrenciGoruntule.Name = "btn_OgrenciGoruntule";
            this.btn_OgrenciGoruntule.Size = new System.Drawing.Size(107, 59);
            this.btn_OgrenciGoruntule.TabIndex = 36;
            this.btn_OgrenciGoruntule.Text = "Öğrenci Görüntüle";
            this.btn_OgrenciGoruntule.UseVisualStyleBackColor = true;
            this.btn_OgrenciGoruntule.Click += new System.EventHandler(this.btn_OgrenciGoruntule_Click_1);
            // 
            // DGW_Gorevli_Ogrenciler
            // 
            this.DGW_Gorevli_Ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Gorevli_Ogrenciler.Location = new System.Drawing.Point(627, 377);
            this.DGW_Gorevli_Ogrenciler.Name = "DGW_Gorevli_Ogrenciler";
            this.DGW_Gorevli_Ogrenciler.RowHeadersWidth = 51;
            this.DGW_Gorevli_Ogrenciler.RowTemplate.Height = 24;
            this.DGW_Gorevli_Ogrenciler.Size = new System.Drawing.Size(474, 300);
            this.DGW_Gorevli_Ogrenciler.TabIndex = 37;
            // 
            // btn_MasaSil
            // 
            this.btn_MasaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MasaSil.Location = new System.Drawing.Point(464, 225);
            this.btn_MasaSil.Name = "btn_MasaSil";
            this.btn_MasaSil.Size = new System.Drawing.Size(106, 59);
            this.btn_MasaSil.TabIndex = 38;
            this.btn_MasaSil.Text = "Masa Sil";
            this.btn_MasaSil.UseVisualStyleBackColor = true;
            this.btn_MasaSil.Click += new System.EventHandler(this.btn_MasaSil_Click);
            // 
            // pictureBox_Masa
            // 
            this.pictureBox_Masa.Image = global::GorselProgramlama3_Proje.Properties.Resources.chair_1_;
            this.pictureBox_Masa.Location = new System.Drawing.Point(241, 225);
            this.pictureBox_Masa.Name = "pictureBox_Masa";
            this.pictureBox_Masa.Size = new System.Drawing.Size(151, 110);
            this.pictureBox_Masa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Masa.TabIndex = 39;
            this.pictureBox_Masa.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 694);
            this.Controls.Add(this.pictureBox_Masa);
            this.Controls.Add(this.btn_MasaSil);
            this.Controls.Add(this.DGW_Gorevli_Ogrenciler);
            this.Controls.Add(this.btn_OgrenciGoruntule);
            this.Controls.Add(this.txt_MasaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGW_Masalar);
            this.Controls.Add(this.txt_MasaCalismaAlani);
            this.Controls.Add(this.txt_MasaAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MasaEkle);
            this.Controls.Add(this.btn_Geri);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Masalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Gorevli_Ogrenciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Masa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Button btn_MasaEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MasaAdi;
        private System.Windows.Forms.TextBox txt_MasaCalismaAlani;
        private System.Windows.Forms.DataGridView DGW_Masalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MasaID;
        private System.Windows.Forms.Button btn_OgrenciGoruntule;
        private System.Windows.Forms.DataGridView DGW_Gorevli_Ogrenciler;
        private System.Windows.Forms.Button btn_MasaSil;
        private System.Windows.Forms.PictureBox pictureBox_Masa;
    }
}