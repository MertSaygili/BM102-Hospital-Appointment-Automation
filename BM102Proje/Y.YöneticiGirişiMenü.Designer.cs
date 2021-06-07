
namespace BM102Proje
{
    partial class YöneticiGirişiMenü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiGirişiMenü));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.robokod = new System.Windows.Forms.Label();
            this.Txtrobokutu = new System.Windows.Forms.MaskedTextBox();
            this.giris1 = new System.Windows.Forms.Button();
            this.giris2 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sifregoster = new System.Windows.Forms.PictureBox();
            this.sifregizle = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifregoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifregizle)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.sifregizle);
            this.bunifuGradientPanel1.Controls.Add(this.sifregoster);
            this.bunifuGradientPanel1.Controls.Add(this.robokod);
            this.bunifuGradientPanel1.Controls.Add(this.Txtrobokutu);
            this.bunifuGradientPanel1.Controls.Add(this.giris1);
            this.bunifuGradientPanel1.Controls.Add(this.giris2);
            this.bunifuGradientPanel1.Controls.Add(this.password);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.KimlikNo);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.button1);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-4, -1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(512, 269);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // robokod
            // 
            this.robokod.AutoSize = true;
            this.robokod.BackColor = System.Drawing.Color.Transparent;
            this.robokod.Font = new System.Drawing.Font("Cambria", 12F);
            this.robokod.ForeColor = System.Drawing.Color.Black;
            this.robokod.Location = new System.Drawing.Point(151, 201);
            this.robokod.Name = "robokod";
            this.robokod.Size = new System.Drawing.Size(49, 19);
            this.robokod.TabIndex = 29;
            this.robokod.Text = "xxxxx";
            // 
            // Txtrobokutu
            // 
            this.Txtrobokutu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtrobokutu.Location = new System.Drawing.Point(217, 202);
            this.Txtrobokutu.Name = "Txtrobokutu";
            this.Txtrobokutu.Size = new System.Drawing.Size(85, 26);
            this.Txtrobokutu.TabIndex = 28;
            // 
            // giris1
            // 
            this.giris1.BackColor = System.Drawing.Color.DarkGray;
            this.giris1.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.giris1.Location = new System.Drawing.Point(333, 183);
            this.giris1.Name = "giris1";
            this.giris1.Size = new System.Drawing.Size(126, 54);
            this.giris1.TabIndex = 27;
            this.giris1.Text = "Giriş";
            this.giris1.UseVisualStyleBackColor = false;
            this.giris1.Click += new System.EventHandler(this.giris1_Click);
            // 
            // giris2
            // 
            this.giris2.BackColor = System.Drawing.Color.DarkGray;
            this.giris2.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.giris2.Location = new System.Drawing.Point(333, 183);
            this.giris2.Name = "giris2";
            this.giris2.Size = new System.Drawing.Size(126, 54);
            this.giris2.TabIndex = 26;
            this.giris2.Text = "Giriş";
            this.giris2.UseVisualStyleBackColor = false;
            this.giris2.Click += new System.EventHandler(this.giris2_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.Location = new System.Drawing.Point(216, 134);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(243, 26);
            this.password.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(161, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Şifre: ";
            // 
            // KimlikNo
            // 
            this.KimlikNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KimlikNo.Location = new System.Drawing.Point(217, 92);
            this.KimlikNo.Name = "KimlikNo";
            this.KimlikNo.Size = new System.Drawing.Size(243, 26);
            this.KimlikNo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(83, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kimlik Numarası:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BM102Proje.Properties.Resources.back_button_computer_left_blue_116903;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(16, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 35);
            this.button1.TabIndex = 21;
            this.button1.TabStop = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(160, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Personel Girişi";
            // 
            // sifregoster
            // 
            this.sifregoster.Image = ((System.Drawing.Image)(resources.GetObject("sifregoster.Image")));
            this.sifregoster.Location = new System.Drawing.Point(466, 133);
            this.sifregoster.Name = "sifregoster";
            this.sifregoster.Size = new System.Drawing.Size(27, 27);
            this.sifregoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sifregoster.TabIndex = 30;
            this.sifregoster.TabStop = false;
            this.sifregoster.Click += new System.EventHandler(this.sifregoster_Click);
            // 
            // sifregizle
            // 
            this.sifregizle.Image = ((System.Drawing.Image)(resources.GetObject("sifregizle.Image")));
            this.sifregizle.Location = new System.Drawing.Point(466, 133);
            this.sifregizle.Name = "sifregizle";
            this.sifregizle.Size = new System.Drawing.Size(27, 27);
            this.sifregizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sifregizle.TabIndex = 31;
            this.sifregizle.TabStop = false;
            this.sifregizle.Click += new System.EventHandler(this.sifregizle_Click);
            // 
            // YöneticiGirişiMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(505, 267);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "YöneticiGirişiMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Girişi Menü";
            this.Load += new System.EventHandler(this.YöneticiGirişiMenü_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifregoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifregizle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox KimlikNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.Button giris2;
        private System.Windows.Forms.Button giris1;
        private System.Windows.Forms.Label robokod;
        private System.Windows.Forms.MaskedTextBox Txtrobokutu;
        private System.Windows.Forms.PictureBox sifregizle;
        private System.Windows.Forms.PictureBox sifregoster;
    }
}