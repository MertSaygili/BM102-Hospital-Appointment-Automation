
namespace BM102Proje
{
    partial class KullanıcıMenü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıMenü));
            this.gradiantPanel1 = new BM102Proje.GradiantPanel();
            this.SuspendLayout();
            // 
            // gradiantPanel1
            // 
            this.gradiantPanel1.ColorBot = System.Drawing.Color.LightCyan;
            this.gradiantPanel1.ColorTop = System.Drawing.Color.LightSeaGreen;
            this.gradiantPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradiantPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradiantPanel1.Name = "gradiantPanel1";
            this.gradiantPanel1.Size = new System.Drawing.Size(821, 326);
            this.gradiantPanel1.TabIndex = 0;
            // 
            // KullanıcıMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 327);
            this.Controls.Add(this.gradiantPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KullanıcıMenü";
            this.Text = "Kullanıcı Menü";
            this.Load += new System.EventHandler(this.KullanıcıMenü_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GradiantPanel gradiantPanel1;
    }
}