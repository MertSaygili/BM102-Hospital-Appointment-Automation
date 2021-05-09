
namespace BM102Proje
{
    partial class KullanıcıGirişiMenü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıGirişiMenü));
            this.gradiantPanel2 = new BM102Proje.GradiantPanel();
            this.button1 = new System.Windows.Forms.PictureBox();
            this.TxtSifreGirisi = new System.Windows.Forms.MaskedTextBox();
            this.Giriş2 = new System.Windows.Forms.Button();
            this.TxtKimlikNumarası = new System.Windows.Forms.MaskedTextBox();
            this.RoboKodGörünüm = new System.Windows.Forms.Label();
            this.TxtRoboKodGiriş = new System.Windows.Forms.TextBox();
            this.RoboKodBilgi = new System.Windows.Forms.Label();
            this.Gİriş1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KayıtOl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KullanıcıGirişPaneli = new System.Windows.Forms.Label();
            this.gradiantPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradiantPanel2
            // 
            this.gradiantPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gradiantPanel2.ColorBot = System.Drawing.Color.LightCyan;
            this.gradiantPanel2.ColorTop = System.Drawing.Color.LightSeaGreen;
            this.gradiantPanel2.Controls.Add(this.button1);
            this.gradiantPanel2.Controls.Add(this.TxtSifreGirisi);
            this.gradiantPanel2.Controls.Add(this.Giriş2);
            this.gradiantPanel2.Controls.Add(this.TxtKimlikNumarası);
            this.gradiantPanel2.Controls.Add(this.RoboKodGörünüm);
            this.gradiantPanel2.Controls.Add(this.TxtRoboKodGiriş);
            this.gradiantPanel2.Controls.Add(this.RoboKodBilgi);
            this.gradiantPanel2.Controls.Add(this.Gİriş1);
            this.gradiantPanel2.Controls.Add(this.button2);
            this.gradiantPanel2.Controls.Add(this.KayıtOl);
            this.gradiantPanel2.Controls.Add(this.label2);
            this.gradiantPanel2.Controls.Add(this.label1);
            this.gradiantPanel2.Controls.Add(this.KullanıcıGirişPaneli);
            this.gradiantPanel2.Location = new System.Drawing.Point(-2, -1);
            this.gradiantPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gradiantPanel2.Name = "gradiantPanel2";
            this.gradiantPanel2.Size = new System.Drawing.Size(712, 455);
            this.gradiantPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BM102Proje.Properties.Resources.back_button_computer_left_blue_116903;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(14, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 35);
            this.button1.TabIndex = 20;
            this.button1.TabStop = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TxtSifreGirisi
            // 
            this.TxtSifreGirisi.Location = new System.Drawing.Point(244, 150);
            this.TxtSifreGirisi.Mask = "000000";
            this.TxtSifreGirisi.Name = "TxtSifreGirisi";
            this.TxtSifreGirisi.PasswordChar = '*';
            this.TxtSifreGirisi.Size = new System.Drawing.Size(331, 26);
            this.TxtSifreGirisi.TabIndex = 1;
            this.TxtSifreGirisi.ValidatingType = typeof(int);
            // 
            // Giriş2
            // 
            this.Giriş2.BackColor = System.Drawing.Color.DarkGray;
            this.Giriş2.Location = new System.Drawing.Point(493, 335);
            this.Giriş2.Name = "Giriş2";
            this.Giriş2.Size = new System.Drawing.Size(185, 80);
            this.Giriş2.TabIndex = 13;
            this.Giriş2.Text = "Giriş";
            this.Giriş2.UseVisualStyleBackColor = false;
            this.Giriş2.Click += new System.EventHandler(this.Giriş2_Click);
            // 
            // TxtKimlikNumarası
            // 
            this.TxtKimlikNumarası.Location = new System.Drawing.Point(244, 95);
            this.TxtKimlikNumarası.Name = "TxtKimlikNumarası";
            this.TxtKimlikNumarası.Size = new System.Drawing.Size(331, 26);
            this.TxtKimlikNumarası.TabIndex = 3;
            this.TxtKimlikNumarası.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtKimlikNumarası_MaskInputRejected);
            // 
            // RoboKodGörünüm
            // 
            this.RoboKodGörünüm.AutoSize = true;
            this.RoboKodGörünüm.Location = new System.Drawing.Point(159, 238);
            this.RoboKodGörünüm.Name = "RoboKodGörünüm";
            this.RoboKodGörünüm.Size = new System.Drawing.Size(51, 19);
            this.RoboKodGörünüm.TabIndex = 12;
            this.RoboKodGörünüm.Text = "label4";
            // 
            // TxtRoboKodGiriş
            // 
            this.TxtRoboKodGiriş.Location = new System.Drawing.Point(536, 232);
            this.TxtRoboKodGiriş.Name = "TxtRoboKodGiriş";
            this.TxtRoboKodGiriş.Size = new System.Drawing.Size(130, 26);
            this.TxtRoboKodGiriş.TabIndex = 11;
            // 
            // RoboKodBilgi
            // 
            this.RoboKodBilgi.AutoSize = true;
            this.RoboKodBilgi.Location = new System.Drawing.Point(240, 235);
            this.RoboKodBilgi.Name = "RoboKodBilgi";
            this.RoboKodBilgi.Size = new System.Drawing.Size(221, 19);
            this.RoboKodBilgi.TabIndex = 10;
            this.RoboKodBilgi.Text = "Soldaki kodu sağ tarafa yazınız";
            // 
            // Gİriş1
            // 
            this.Gİriş1.BackColor = System.Drawing.Color.DarkGray;
            this.Gİriş1.Location = new System.Drawing.Point(493, 335);
            this.Gİriş1.Name = "Gİriş1";
            this.Gİriş1.Size = new System.Drawing.Size(185, 80);
            this.Gİriş1.TabIndex = 9;
            this.Gİriş1.Text = "Giriş";
            this.Gİriş1.UseVisualStyleBackColor = false;
            this.Gİriş1.Click += new System.EventHandler(this.Gİriş1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(255, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 80);
            this.button2.TabIndex = 8;
            this.button2.Text = "Şifremi Unuttum";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KayıtOl
            // 
            this.KayıtOl.BackColor = System.Drawing.Color.DarkGray;
            this.KayıtOl.Location = new System.Drawing.Point(29, 335);
            this.KayıtOl.Name = "KayıtOl";
            this.KayıtOl.Size = new System.Drawing.Size(192, 80);
            this.KayıtOl.TabIndex = 7;
            this.KayıtOl.Text = "Kayıt Ol";
            this.KayıtOl.UseVisualStyleBackColor = false;
            this.KayıtOl.Click += new System.EventHandler(this.KayıtOl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(88, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kimlik Numarası:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KullanıcıGirişPaneli
            // 
            this.KullanıcıGirişPaneli.BackColor = System.Drawing.Color.Transparent;
            this.KullanıcıGirişPaneli.Font = new System.Drawing.Font("Cambria", 16F);
            this.KullanıcıGirişPaneli.ForeColor = System.Drawing.Color.MidnightBlue;
            this.KullanıcıGirişPaneli.Location = new System.Drawing.Point(138, 10);
            this.KullanıcıGirişPaneli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KullanıcıGirişPaneli.Name = "KullanıcıGirişPaneli";
            this.KullanıcıGirişPaneli.Size = new System.Drawing.Size(411, 53);
            this.KullanıcıGirişPaneli.TabIndex = 2;
            this.KullanıcıGirişPaneli.Text = "Kullanıcı Giriş Paneli";
            this.KullanıcıGirişPaneli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KullanıcıGirişiMenü
            // 
            this.AcceptButton = this.Gİriş1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(702, 447);
            this.Controls.Add(this.gradiantPanel2);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullanıcıGirişiMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Paneli";
            this.Load += new System.EventHandler(this.KullanıcıGirişiMenü_Load);
            this.gradiantPanel2.ResumeLayout(false);
            this.gradiantPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradiantPanel gradiantPanel2;
        private System.Windows.Forms.Label KullanıcıGirişPaneli;
        private System.Windows.Forms.Button Gİriş1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button KayıtOl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtKimlikNumarası;
        private System.Windows.Forms.Label RoboKodGörünüm;
        private System.Windows.Forms.TextBox TxtRoboKodGiriş;
        private System.Windows.Forms.Label RoboKodBilgi;
        private System.Windows.Forms.Button Giriş2;
        private System.Windows.Forms.MaskedTextBox TxtSifreGirisi;
        private System.Windows.Forms.PictureBox button1;
    }
}