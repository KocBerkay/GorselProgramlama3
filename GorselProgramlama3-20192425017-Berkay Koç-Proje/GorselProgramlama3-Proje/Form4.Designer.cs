
namespace GorselProgramlama3_Proje
{
    partial class Form4
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
            this.btn_AileSec = new System.Windows.Forms.Button();
            this.DGW_Secilenler = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Secilenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AileSec
            // 
            this.btn_AileSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AileSec.Location = new System.Drawing.Point(28, 218);
            this.btn_AileSec.Name = "btn_AileSec";
            this.btn_AileSec.Size = new System.Drawing.Size(147, 138);
            this.btn_AileSec.TabIndex = 0;
            this.btn_AileSec.Text = "Aile Seç --> 0 ";
            this.btn_AileSec.UseVisualStyleBackColor = true;
            this.btn_AileSec.Click += new System.EventHandler(this.btn_AileSec_Click);
            // 
            // DGW_Secilenler
            // 
            this.DGW_Secilenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Secilenler.Location = new System.Drawing.Point(233, 37);
            this.DGW_Secilenler.Name = "DGW_Secilenler";
            this.DGW_Secilenler.RowHeadersWidth = 51;
            this.DGW_Secilenler.RowTemplate.Height = 24;
            this.DGW_Secilenler.Size = new System.Drawing.Size(687, 319);
            this.DGW_Secilenler.TabIndex = 1;
            this.DGW_Secilenler.ColumnSortModeChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DGW_Secilenler_ColumnSortModeChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GorselProgramlama3_Proje.Properties.Resources.family;
            this.pictureBox1.Location = new System.Drawing.Point(28, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGW_Secilenler);
            this.Controls.Add(this.btn_AileSec);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Secilenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AileSec;
        private System.Windows.Forms.DataGridView DGW_Secilenler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}