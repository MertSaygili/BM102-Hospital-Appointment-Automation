
namespace BM102Proje
{
    partial class DuyuruEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuyuruEkle));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.onaylabutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.DuyuruEkleText = new System.Windows.Forms.RichTextBox();
            this.SikayetSikayetText = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onaylabutton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.onaylabutton);
            this.bunifuGradientPanel1.Controls.Add(this.DuyuruEkleText);
            this.bunifuGradientPanel1.Controls.Add(this.SikayetSikayetText);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-6, -6);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(670, 444);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // onaylabutton
            // 
            this.onaylabutton.BackColor = System.Drawing.Color.Transparent;
            this.onaylabutton.Image = ((System.Drawing.Image)(resources.GetObject("onaylabutton.Image")));
            this.onaylabutton.ImageActive = null;
            this.onaylabutton.Location = new System.Drawing.Point(231, 194);
            this.onaylabutton.Name = "onaylabutton";
            this.onaylabutton.Size = new System.Drawing.Size(50, 45);
            this.onaylabutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onaylabutton.TabIndex = 66;
            this.onaylabutton.TabStop = false;
            this.onaylabutton.Zoom = 10;
            this.onaylabutton.Click += new System.EventHandler(this.onaylabutton_Click);
            // 
            // DuyuruEkleText
            // 
            this.DuyuruEkleText.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DuyuruEkleText.Location = new System.Drawing.Point(81, 31);
            this.DuyuruEkleText.Margin = new System.Windows.Forms.Padding(2);
            this.DuyuruEkleText.Name = "DuyuruEkleText";
            this.DuyuruEkleText.Size = new System.Drawing.Size(200, 158);
            this.DuyuruEkleText.TabIndex = 64;
            this.DuyuruEkleText.Text = "";
            // 
            // SikayetSikayetText
            // 
            this.SikayetSikayetText.AutoSize = true;
            this.SikayetSikayetText.BackColor = System.Drawing.Color.Transparent;
            this.SikayetSikayetText.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SikayetSikayetText.Location = new System.Drawing.Point(17, 31);
            this.SikayetSikayetText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SikayetSikayetText.Name = "SikayetSikayetText";
            this.SikayetSikayetText.Size = new System.Drawing.Size(60, 17);
            this.SikayetSikayetText.TabIndex = 63;
            this.SikayetSikayetText.Text = "Duyuru:";
            // 
            // DuyuruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(296, 240);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DuyuruEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyuru Ekleme Paneli";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onaylabutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton onaylabutton;
        private System.Windows.Forms.RichTextBox DuyuruEkleText;
        private System.Windows.Forms.Label SikayetSikayetText;
    }
}