
namespace BM102Proje
{
    partial class GirişPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirişPaneli));
            this.gradiantPanel1 = new BM102Proje.GradiantPanel();
            this.YöneticiGirişi = new System.Windows.Forms.Button();
            this.KullanıcıGirişi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Başlık = new System.Windows.Forms.Label();
            this.gradiantPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradiantPanel1
            // 
            this.gradiantPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.gradiantPanel1.ColorBot = System.Drawing.Color.LightCyan;
            this.gradiantPanel1.ColorTop = System.Drawing.Color.LightSeaGreen;
            this.gradiantPanel1.Controls.Add(this.YöneticiGirişi);
            this.gradiantPanel1.Controls.Add(this.KullanıcıGirişi);
            this.gradiantPanel1.Controls.Add(this.pictureBox1);
            this.gradiantPanel1.Controls.Add(this.Başlık);
            this.gradiantPanel1.ForeColor = System.Drawing.Color.Black;
            this.gradiantPanel1.Location = new System.Drawing.Point(0, -3);
            this.gradiantPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradiantPanel1.Name = "gradiantPanel1";
            this.gradiantPanel1.Size = new System.Drawing.Size(776, 262);
            this.gradiantPanel1.TabIndex = 0;
            // 
            // YöneticiGirişi
            // 
            this.YöneticiGirişi.BackColor = System.Drawing.Color.DarkGray;
            this.YöneticiGirişi.Location = new System.Drawing.Point(508, 141);
            this.YöneticiGirişi.Name = "YöneticiGirişi";
            this.YöneticiGirişi.Size = new System.Drawing.Size(224, 61);
            this.YöneticiGirişi.TabIndex = 3;
            this.YöneticiGirişi.Text = "Personel Giriş";
            this.YöneticiGirişi.UseVisualStyleBackColor = false;
            this.YöneticiGirişi.Click += new System.EventHandler(this.YöneticiGirişi_Click);
            // 
            // KullanıcıGirişi
            // 
            this.KullanıcıGirişi.BackColor = System.Drawing.Color.DarkGray;
            this.KullanıcıGirişi.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.KullanıcıGirişi.FlatAppearance.BorderSize = 0;
            this.KullanıcıGirişi.Location = new System.Drawing.Point(264, 141);
            this.KullanıcıGirişi.Name = "KullanıcıGirişi";
            this.KullanıcıGirişi.Size = new System.Drawing.Size(224, 61);
            this.KullanıcıGirişi.TabIndex = 2;
            this.KullanıcıGirişi.Text = "Vatandaş Giriş";
            this.KullanıcıGirişi.UseVisualStyleBackColor = false;
            this.KullanıcıGirişi.Click += new System.EventHandler(this.KullanıcıGirişi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Başlık
            // 
            this.Başlık.BackColor = System.Drawing.Color.Transparent;
            this.Başlık.Font = new System.Drawing.Font("Cambria", 16F);
            this.Başlık.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Başlık.Location = new System.Drawing.Point(248, 38);
            this.Başlık.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Başlık.Name = "Başlık";
            this.Başlık.Size = new System.Drawing.Size(506, 42);
            this.Başlık.TabIndex = 1;
            this.Başlık.Text = "TC Sağlık Bakanlığı Randevu Sistemi";
            this.Başlık.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GirişPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(775, 258);
            this.Controls.Add(this.gradiantPanel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GirişPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradiantPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradiantPanel gradiantPanel1;
        private System.Windows.Forms.Label Başlık;
        private System.Windows.Forms.Button YöneticiGirişi;
        private System.Windows.Forms.Button KullanıcıGirişi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

