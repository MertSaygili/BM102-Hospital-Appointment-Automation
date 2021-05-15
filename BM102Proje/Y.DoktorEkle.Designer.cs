
namespace BM102Proje
{
    partial class DoktorEkleMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorEkleMenu));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.temizle = new System.Windows.Forms.Button();
            this.onaylabuton = new System.Windows.Forms.Button();
            this.doktorsoyadkutu = new System.Windows.Forms.TextBox();
            this.doktorsoyad = new System.Windows.Forms.Label();
            this.doktoradi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.poliktxt = new System.Windows.Forms.Label();
            this.DoktorPol = new System.Windows.Forms.ComboBox();
            this.GeriDon = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeriDon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.temizle);
            this.bunifuGradientPanel1.Controls.Add(this.onaylabuton);
            this.bunifuGradientPanel1.Controls.Add(this.doktorsoyadkutu);
            this.bunifuGradientPanel1.Controls.Add(this.doktorsoyad);
            this.bunifuGradientPanel1.Controls.Add(this.doktoradi);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.poliktxt);
            this.bunifuGradientPanel1.Controls.Add(this.DoktorPol);
            this.bunifuGradientPanel1.Controls.Add(this.GeriDon);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(464, 297);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // temizle
            // 
            this.temizle.BackColor = System.Drawing.SystemColors.Control;
            this.temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temizle.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle.Location = new System.Drawing.Point(143, 239);
            this.temizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(143, 46);
            this.temizle.TabIndex = 52;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = false;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // onaylabuton
            // 
            this.onaylabuton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.onaylabuton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onaylabuton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylabuton.Location = new System.Drawing.Point(292, 239);
            this.onaylabuton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.onaylabuton.Name = "onaylabuton";
            this.onaylabuton.Size = new System.Drawing.Size(143, 46);
            this.onaylabuton.TabIndex = 51;
            this.onaylabuton.Text = "Onayla";
            this.onaylabuton.UseVisualStyleBackColor = false;
            this.onaylabuton.Click += new System.EventHandler(this.onaylabuton_Click);
            // 
            // doktorsoyadkutu
            // 
            this.doktorsoyadkutu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorsoyadkutu.Location = new System.Drawing.Point(188, 186);
            this.doktorsoyadkutu.Name = "doktorsoyadkutu";
            this.doktorsoyadkutu.Size = new System.Drawing.Size(247, 31);
            this.doktorsoyadkutu.TabIndex = 49;
            // 
            // doktorsoyad
            // 
            this.doktorsoyad.AutoSize = true;
            this.doktorsoyad.BackColor = System.Drawing.Color.Transparent;
            this.doktorsoyad.Font = new System.Drawing.Font("Cambria", 12F);
            this.doktorsoyad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.doktorsoyad.Location = new System.Drawing.Point(45, 189);
            this.doktorsoyad.Name = "doktorsoyad";
            this.doktorsoyad.Size = new System.Drawing.Size(137, 23);
            this.doktorsoyad.TabIndex = 48;
            this.doktorsoyad.Text = "Doktor Soyadı:";
            // 
            // doktoradi
            // 
            this.doktoradi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktoradi.Location = new System.Drawing.Point(189, 140);
            this.doktoradi.Name = "doktoradi";
            this.doktoradi.Size = new System.Drawing.Size(247, 31);
            this.doktoradi.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(74, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Doktor Adı:";
            // 
            // poliktxt
            // 
            this.poliktxt.AutoSize = true;
            this.poliktxt.BackColor = System.Drawing.Color.Transparent;
            this.poliktxt.Font = new System.Drawing.Font("Cambria", 12F);
            this.poliktxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.poliktxt.Location = new System.Drawing.Point(22, 97);
            this.poliktxt.Name = "poliktxt";
            this.poliktxt.Size = new System.Drawing.Size(160, 23);
            this.poliktxt.TabIndex = 45;
            this.poliktxt.Text = "Polikinlik seçiniz:";
            // 
            // DoktorPol
            // 
            this.DoktorPol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoktorPol.Font = new System.Drawing.Font("Cambria", 12F);
            this.DoktorPol.FormattingEnabled = true;
            this.DoktorPol.Items.AddRange(new object[] {
            "Beslenme Polikliniği",
            "Beyin ve Sinir Cerrahisi Polikliniği",
            "Cildiye Poliklinikleri",
            "Çocuk Hastalıkları Genel Polikliniği",
            "Dahiliye Poliklinikleri",
            "Diş Poliklinikleri",
            "Fizik Tedavi ve Rehabilitasyon Poliklinikleri",
            "Göğüs Cerrahi Poliklinikleri",
            "Göz Poliklinikleri",
            "Kalp Damar Cerrahi Poliklinikleri",
            "Kadın Doğum Poliklinikleri",
            "Kulak Burun Boğaz  Poliklinikleri",
            "Ortopedi Poliklinikleri",
            "Psikiyatri Poliklinikleri",
            "Plastik Cerrahi Poliklinikleri"});
            this.DoktorPol.Location = new System.Drawing.Point(188, 94);
            this.DoktorPol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoktorPol.Name = "DoktorPol";
            this.DoktorPol.Size = new System.Drawing.Size(248, 31);
            this.DoktorPol.TabIndex = 44;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.Transparent;
            this.GeriDon.BackgroundImage = global::BM102Proje.Properties.Resources.back_button_computer_left_blue_116903;
            this.GeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GeriDon.Location = new System.Drawing.Point(13, 16);
            this.GeriDon.Margin = new System.Windows.Forms.Padding(4);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(45, 42);
            this.GeriDon.TabIndex = 27;
            this.GeriDon.TabStop = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // DoktorEkleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 293);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "DoktorEkleMenu";
            this.Text = "Doktor Ekleme Menüsü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeriDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox GeriDon;
        private System.Windows.Forms.TextBox doktoradi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label poliktxt;
        private System.Windows.Forms.ComboBox DoktorPol;
        private System.Windows.Forms.TextBox doktorsoyadkutu;
        private System.Windows.Forms.Label doktorsoyad;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button onaylabuton;
    }
}