
namespace BM102Proje
{
    partial class SifremiUnuttumPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttumPaneli));
            this.gradiantPanel1 = new BM102Proje.GradiantPanel();
            this.gönder = new System.Windows.Forms.Button();
            this.TxtKimlikNumarası = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gradiantPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradiantPanel1
            // 
            this.gradiantPanel1.ColorBot = System.Drawing.Color.LightCyan;
            this.gradiantPanel1.ColorTop = System.Drawing.Color.LightSeaGreen;
            this.gradiantPanel1.Controls.Add(this.label3);
            this.gradiantPanel1.Controls.Add(this.gönder);
            this.gradiantPanel1.Controls.Add(this.TxtKimlikNumarası);
            this.gradiantPanel1.Controls.Add(this.label2);
            this.gradiantPanel1.Controls.Add(this.label1);
            this.gradiantPanel1.Controls.Add(this.TxtSifre);
            this.gradiantPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradiantPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradiantPanel1.Name = "gradiantPanel1";
            this.gradiantPanel1.Size = new System.Drawing.Size(675, 373);
            this.gradiantPanel1.TabIndex = 0;
            // 
            // gönder
            // 
            this.gönder.BackColor = System.Drawing.Color.DarkGray;
            this.gönder.Location = new System.Drawing.Point(494, 44);
            this.gönder.Name = "gönder";
            this.gönder.Size = new System.Drawing.Size(128, 51);
            this.gönder.TabIndex = 5;
            this.gönder.Text = "Gönder";
            this.gönder.UseVisualStyleBackColor = false;
            //this.gönder.Click += new System.EventHandler(this.gönder_Click);
            // 
            // TxtKimlikNumarası
            // 
            this.TxtKimlikNumarası.Location = new System.Drawing.Point(242, 55);
            this.TxtKimlikNumarası.Mask = "00000000000";
            this.TxtKimlikNumarası.Name = "TxtKimlikNumarası";
            this.TxtKimlikNumarası.Size = new System.Drawing.Size(200, 31);
            this.TxtKimlikNumarası.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(149, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kimlik Numarası:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(242, 104);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSifre.Mask = "000000";
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(200, 31);
            this.TxtSifre.TabIndex = 1;
            this.TxtSifre.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // SifremiUnuttumPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 372);
            this.Controls.Add(this.gradiantPanel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SifremiUnuttumPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttumPaneli";
            //this.Load += new System.EventHandler(this.SifremiUnuttumPaneli_Load);
            this.gradiantPanel1.ResumeLayout(false);
            this.gradiantPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradiantPanel gradiantPanel1;
        private System.Windows.Forms.MaskedTextBox TxtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtKimlikNumarası;
        private System.Windows.Forms.Button gönder;
        private System.Windows.Forms.Label label3;
    }
}