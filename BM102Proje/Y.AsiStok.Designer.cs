
namespace BM102Proje
{
    partial class AsiStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsiStok));
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.biontechtext = new System.Windows.Forms.Label();
            this.SinovacBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.BiontechBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.tarihsaat = new System.Windows.Forms.Label();
            this.geridon = new System.Windows.Forms.PictureBox();
            this.hosgeldin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geridon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.label2);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Controls.Add(this.biontechtext);
            this.bunifuGradientPanel2.Controls.Add(this.SinovacBar);
            this.bunifuGradientPanel2.Controls.Add(this.BiontechBar);
            this.bunifuGradientPanel2.Controls.Add(this.tarihsaat);
            this.bunifuGradientPanel2.Controls.Add(this.geridon);
            this.bunifuGradientPanel2.Controls.Add(this.hosgeldin);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-80, -68);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(716, 463);
            this.bunifuGradientPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(360, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(4, 206);
            this.label2.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F);
            this.label1.Location = new System.Drawing.Point(428, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "Sinovac Stoğu";
            // 
            // biontechtext
            // 
            this.biontechtext.AutoSize = true;
            this.biontechtext.BackColor = System.Drawing.Color.Transparent;
            this.biontechtext.Font = new System.Drawing.Font("Cambria", 14F);
            this.biontechtext.Location = new System.Drawing.Point(137, 289);
            this.biontechtext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.biontechtext.Name = "biontechtext";
            this.biontechtext.Size = new System.Drawing.Size(167, 28);
            this.biontechtext.TabIndex = 34;
            this.biontechtext.Text = "Biontech Stoğu";
            // 
            // SinovacBar
            // 
            this.SinovacBar.animated = false;
            this.SinovacBar.animationIterval = 5;
            this.SinovacBar.animationSpeed = 300;
            this.SinovacBar.BackColor = System.Drawing.Color.Transparent;
            this.SinovacBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SinovacBar.BackgroundImage")));
            this.SinovacBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.SinovacBar.ForeColor = System.Drawing.Color.White;
            this.SinovacBar.LabelVisible = true;
            this.SinovacBar.LineProgressThickness = 12;
            this.SinovacBar.LineThickness = 8;
            this.SinovacBar.Location = new System.Drawing.Point(399, 90);
            this.SinovacBar.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.SinovacBar.MaxValue = 100;
            this.SinovacBar.Name = "SinovacBar";
            this.SinovacBar.ProgressBackColor = System.Drawing.Color.White;
            this.SinovacBar.ProgressColor = System.Drawing.Color.Yellow;
            this.SinovacBar.Size = new System.Drawing.Size(188, 188);
            this.SinovacBar.TabIndex = 33;
            this.SinovacBar.Value = 0;
            // 
            // BiontechBar
            // 
            this.BiontechBar.animated = false;
            this.BiontechBar.animationIterval = 5;
            this.BiontechBar.animationSpeed = 300;
            this.BiontechBar.BackColor = System.Drawing.Color.Transparent;
            this.BiontechBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BiontechBar.BackgroundImage")));
            this.BiontechBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.BiontechBar.ForeColor = System.Drawing.Color.White;
            this.BiontechBar.LabelVisible = true;
            this.BiontechBar.LineProgressThickness = 12;
            this.BiontechBar.LineThickness = 8;
            this.BiontechBar.Location = new System.Drawing.Point(119, 90);
            this.BiontechBar.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.BiontechBar.MaxValue = 100;
            this.BiontechBar.Name = "BiontechBar";
            this.BiontechBar.ProgressBackColor = System.Drawing.Color.White;
            this.BiontechBar.ProgressColor = System.Drawing.Color.Lime;
            this.BiontechBar.Size = new System.Drawing.Size(188, 188);
            this.BiontechBar.TabIndex = 32;
            this.BiontechBar.Value = 0;
            // 
            // tarihsaat
            // 
            this.tarihsaat.AutoSize = true;
            this.tarihsaat.BackColor = System.Drawing.Color.Transparent;
            this.tarihsaat.Font = new System.Drawing.Font("Cambria", 15F);
            this.tarihsaat.Location = new System.Drawing.Point(551, 38);
            this.tarihsaat.Name = "tarihsaat";
            this.tarihsaat.Size = new System.Drawing.Size(135, 30);
            this.tarihsaat.TabIndex = 31;
            this.tarihsaat.Text = "15.05.2021";
            // 
            // geridon
            // 
            this.geridon.BackColor = System.Drawing.Color.Transparent;
            this.geridon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geridon.BackgroundImage")));
            this.geridon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geridon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geridon.Location = new System.Drawing.Point(20, 33);
            this.geridon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(37, 34);
            this.geridon.TabIndex = 22;
            this.geridon.TabStop = false;
            // 
            // hosgeldin
            // 
            this.hosgeldin.AutoSize = true;
            this.hosgeldin.BackColor = System.Drawing.Color.Transparent;
            this.hosgeldin.Font = new System.Drawing.Font("Cambria", 15F);
            this.hosgeldin.Location = new System.Drawing.Point(63, 38);
            this.hosgeldin.Name = "hosgeldin";
            this.hosgeldin.Size = new System.Drawing.Size(184, 30);
            this.hosgeldin.TabIndex = 0;
            this.hosgeldin.Text = "Sayın, xxxx xxxx";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // AsiStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(571, 273);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AsiStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aşı Stok Durumu";
            this.Load += new System.EventHandler(this.AsiStok_Load);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geridon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label tarihsaat;
        private System.Windows.Forms.PictureBox geridon;
        private System.Windows.Forms.Label hosgeldin;
        private Bunifu.Framework.UI.BunifuCircleProgressbar BiontechBar;
        private Bunifu.Framework.UI.BunifuCircleProgressbar SinovacBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label biontechtext;
    }
}