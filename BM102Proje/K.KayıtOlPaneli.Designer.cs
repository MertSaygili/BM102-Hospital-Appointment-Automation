
namespace BM102Proje
{
    partial class KayıtOlPaneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayıtOlPaneli));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradiantPanel1 = new BM102Proje.GradiantPanel();
            this.button1 = new System.Windows.Forms.PictureBox();
            this.TxtŞifreTekrar = new System.Windows.Forms.MaskedTextBox();
            this.TxtŞifre = new System.Windows.Forms.MaskedTextBox();
            this.Gönder = new System.Windows.Forms.Button();
            this.RoboKod = new System.Windows.Forms.Label();
            this.TxtKullanıcıRobosu = new System.Windows.Forms.TextBox();
            this.Sayac = new System.Windows.Forms.Label();
            this.KayıtOl = new System.Windows.Forms.Button();
            this.SY = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtVatandaşTelNumarası = new System.Windows.Forms.TextBox();
            this.TxtVatandaşKimlikNumarası = new System.Windows.Forms.TextBox();
            this.TxtVatandaşEmail = new System.Windows.Forms.TextBox();
            this.TxtVatandaşSoyİsim = new System.Windows.Forms.TextBox();
            this.TxtVatandaşİsmi = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.Label();
            this.TN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.Label();
            this.KN = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradiantPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gradiantPanel1
            // 
            this.gradiantPanel1.ColorBot = System.Drawing.Color.LightCyan;
            this.gradiantPanel1.ColorTop = System.Drawing.Color.LightSeaGreen;
            this.gradiantPanel1.Controls.Add(this.button1);
            this.gradiantPanel1.Controls.Add(this.TxtŞifreTekrar);
            this.gradiantPanel1.Controls.Add(this.TxtŞifre);
            this.gradiantPanel1.Controls.Add(this.Gönder);
            this.gradiantPanel1.Controls.Add(this.RoboKod);
            this.gradiantPanel1.Controls.Add(this.TxtKullanıcıRobosu);
            this.gradiantPanel1.Controls.Add(this.Sayac);
            this.gradiantPanel1.Controls.Add(this.KayıtOl);
            this.gradiantPanel1.Controls.Add(this.SY);
            this.gradiantPanel1.Controls.Add(this.label8);
            this.gradiantPanel1.Controls.Add(this.TxtVatandaşTelNumarası);
            this.gradiantPanel1.Controls.Add(this.TxtVatandaşKimlikNumarası);
            this.gradiantPanel1.Controls.Add(this.TxtVatandaşEmail);
            this.gradiantPanel1.Controls.Add(this.TxtVatandaşSoyİsim);
            this.gradiantPanel1.Controls.Add(this.TxtVatandaşİsmi);
            this.gradiantPanel1.Controls.Add(this.S);
            this.gradiantPanel1.Controls.Add(this.TN);
            this.gradiantPanel1.Controls.Add(this.label5);
            this.gradiantPanel1.Controls.Add(this.E);
            this.gradiantPanel1.Controls.Add(this.KN);
            this.gradiantPanel1.Controls.Add(this.Label2);
            this.gradiantPanel1.Controls.Add(this.label1);
            resources.ApplyResources(this.gradiantPanel1, "gradiantPanel1");
            this.gradiantPanel1.Name = "gradiantPanel1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BM102Proje.Properties.Resources.back_button_computer_left_blue_116903;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Name = "button1";
            this.button1.TabStop = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TxtŞifreTekrar
            // 
            resources.ApplyResources(this.TxtŞifreTekrar, "TxtŞifreTekrar");
            this.TxtŞifreTekrar.Name = "TxtŞifreTekrar";
            this.TxtŞifreTekrar.PasswordChar = '*';
            this.TxtŞifreTekrar.ValidatingType = typeof(int);
            // 
            // TxtŞifre
            // 
            resources.ApplyResources(this.TxtŞifre, "TxtŞifre");
            this.TxtŞifre.Name = "TxtŞifre";
            this.TxtŞifre.PasswordChar = '*';
            this.TxtŞifre.ValidatingType = typeof(int);
            // 
            // Gönder
            // 
            this.Gönder.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.Gönder, "Gönder");
            this.Gönder.Name = "Gönder";
            this.Gönder.UseVisualStyleBackColor = false;
            this.Gönder.Click += new System.EventHandler(this.Gönder_Click);
            // 
            // RoboKod
            // 
            this.RoboKod.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.RoboKod, "RoboKod");
            this.RoboKod.Name = "RoboKod";
            // 
            // TxtKullanıcıRobosu
            // 
            resources.ApplyResources(this.TxtKullanıcıRobosu, "TxtKullanıcıRobosu");
            this.TxtKullanıcıRobosu.Name = "TxtKullanıcıRobosu";
            // 
            // Sayac
            // 
            this.Sayac.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Sayac, "Sayac");
            this.Sayac.Name = "Sayac";
            // 
            // KayıtOl
            // 
            this.KayıtOl.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.KayıtOl, "KayıtOl");
            this.KayıtOl.Name = "KayıtOl";
            this.KayıtOl.UseVisualStyleBackColor = false;
            this.KayıtOl.Click += new System.EventHandler(this.KayıtOl_Click);
            // 
            // SY
            // 
            resources.ApplyResources(this.SY, "SY");
            this.SY.BackColor = System.Drawing.Color.Transparent;
            this.SY.Name = "SY";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Name = "label8";
            // 
            // TxtVatandaşTelNumarası
            // 
            resources.ApplyResources(this.TxtVatandaşTelNumarası, "TxtVatandaşTelNumarası");
            this.TxtVatandaşTelNumarası.Name = "TxtVatandaşTelNumarası";
            // 
            // TxtVatandaşKimlikNumarası
            // 
            resources.ApplyResources(this.TxtVatandaşKimlikNumarası, "TxtVatandaşKimlikNumarası");
            this.TxtVatandaşKimlikNumarası.Name = "TxtVatandaşKimlikNumarası";
            // 
            // TxtVatandaşEmail
            // 
            resources.ApplyResources(this.TxtVatandaşEmail, "TxtVatandaşEmail");
            this.TxtVatandaşEmail.Name = "TxtVatandaşEmail";
            // 
            // TxtVatandaşSoyİsim
            // 
            resources.ApplyResources(this.TxtVatandaşSoyİsim, "TxtVatandaşSoyİsim");
            this.TxtVatandaşSoyİsim.Name = "TxtVatandaşSoyİsim";
            // 
            // TxtVatandaşİsmi
            // 
            resources.ApplyResources(this.TxtVatandaşİsmi, "TxtVatandaşİsmi");
            this.TxtVatandaşİsmi.Name = "TxtVatandaşİsmi";
            // 
            // S
            // 
            resources.ApplyResources(this.S, "S");
            this.S.BackColor = System.Drawing.Color.Transparent;
            this.S.Name = "S";
            // 
            // TN
            // 
            resources.ApplyResources(this.TN, "TN");
            this.TN.BackColor = System.Drawing.Color.Transparent;
            this.TN.Name = "TN";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // E
            // 
            resources.ApplyResources(this.E, "E");
            this.E.BackColor = System.Drawing.Color.Transparent;
            this.E.Name = "E";
            // 
            // KN
            // 
            resources.ApplyResources(this.KN, "KN");
            this.KN.BackColor = System.Drawing.Color.Transparent;
            this.KN.Name = "KN";
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Name = "Label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // KayıtOlPaneli
            // 
            this.AcceptButton = this.KayıtOl;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradiantPanel1);
            this.MaximizeBox = false;
            this.Name = "KayıtOlPaneli";
            this.Load += new System.EventHandler(this.KayıtOlPaneli_Load);
            this.gradiantPanel1.ResumeLayout(false);
            this.gradiantPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradiantPanel gradiantPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtVatandaşTelNumarası;
        private System.Windows.Forms.TextBox TxtVatandaşKimlikNumarası;
        private System.Windows.Forms.TextBox TxtVatandaşEmail;
        private System.Windows.Forms.TextBox TxtVatandaşSoyİsim;
        private System.Windows.Forms.TextBox TxtVatandaşİsmi;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label TN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label KN;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SY;
        private System.Windows.Forms.Button KayıtOl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Sayac;
        private System.Windows.Forms.TextBox TxtKullanıcıRobosu;
        private System.Windows.Forms.Button Gönder;
        private System.Windows.Forms.Label RoboKod;
        private System.Windows.Forms.MaskedTextBox TxtŞifre;
        private System.Windows.Forms.MaskedTextBox TxtŞifreTekrar;
        private System.Windows.Forms.PictureBox button1;
    }
}