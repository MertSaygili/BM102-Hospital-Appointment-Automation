
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
            this.gradiantPanel1 = new BM102Proje.GradiantPanel();
            this.Onayla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.MaskedTextBox();
            this.TxtKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ŞifreTekrar = new System.Windows.Forms.Label();
            this.TxtSifreTekrar = new System.Windows.Forms.MaskedTextBox();
            this.gradiantPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradiantPanel1
            // 
            this.gradiantPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gradiantPanel1.ColorBot = System.Drawing.Color.LightCyan;
            this.gradiantPanel1.ColorTop = System.Drawing.Color.LightSeaGreen;
            this.gradiantPanel1.Controls.Add(this.TxtSifreTekrar);
            this.gradiantPanel1.Controls.Add(this.ŞifreTekrar);
            this.gradiantPanel1.Controls.Add(this.label3);
            this.gradiantPanel1.Controls.Add(this.Onayla);
            this.gradiantPanel1.Controls.Add(this.label2);
            this.gradiantPanel1.Controls.Add(this.label1);
            this.gradiantPanel1.Controls.Add(this.TxtSifre);
            this.gradiantPanel1.Controls.Add(this.TxtKimlikNo);
            this.gradiantPanel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradiantPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradiantPanel1.Name = "gradiantPanel1";
            this.gradiantPanel1.Size = new System.Drawing.Size(801, 455);
            this.gradiantPanel1.TabIndex = 0;
            this.gradiantPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradiantPanel1_Paint);
            // 
            // Onayla
            // 
            this.Onayla.BackColor = System.Drawing.Color.DarkGray;
            this.Onayla.Location = new System.Drawing.Point(580, 156);
            this.Onayla.Name = "Onayla";
            this.Onayla.Size = new System.Drawing.Size(167, 72);
            this.Onayla.TabIndex = 5;
            this.Onayla.Text = "Değiştir";
            this.Onayla.UseVisualStyleBackColor = false;
            this.Onayla.Click += new System.EventHandler(this.Onayla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(128, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kimlik Numarası:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(204, 181);
            this.TxtSifre.Mask = "000000";
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(308, 31);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.ValidatingType = typeof(int);
            // 
            // TxtKimlikNo
            // 
            this.TxtKimlikNo.Location = new System.Drawing.Point(204, 103);
            this.TxtKimlikNo.Mask = "00000000000";
            this.TxtKimlikNo.Name = "TxtKimlikNo";
            this.TxtKimlikNo.Size = new System.Drawing.Size(308, 31);
            this.TxtKimlikNo.TabIndex = 1;
            this.TxtKimlikNo.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 16F);
            this.label3.Location = new System.Drawing.Point(235, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre Değiştirme Paneli";
            // 
            // ŞifreTekrar
            // 
            this.ŞifreTekrar.AutoSize = true;
            this.ŞifreTekrar.BackColor = System.Drawing.Color.Transparent;
            this.ŞifreTekrar.Location = new System.Drawing.Point(71, 261);
            this.ŞifreTekrar.Name = "ŞifreTekrar";
            this.ŞifreTekrar.Size = new System.Drawing.Size(116, 23);
            this.ŞifreTekrar.TabIndex = 7;
            this.ŞifreTekrar.Text = "Şifre tekrar: ";
            // 
            // TxtSifreTekrar
            // 
            this.TxtSifreTekrar.Location = new System.Drawing.Point(204, 253);
            this.TxtSifreTekrar.Mask = "000000";
            this.TxtSifreTekrar.Name = "TxtSifreTekrar";
            this.TxtSifreTekrar.PasswordChar = '*';
            this.TxtSifreTekrar.Size = new System.Drawing.Size(308, 31);
            this.TxtSifreTekrar.TabIndex = 8;
            this.TxtSifreTekrar.ValidatingType = typeof(int);
            // 
            // SifremiUnuttumPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradiantPanel1);
            this.Name = "SifremiUnuttumPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttumPaneli";
            this.Load += new System.EventHandler(this.SifremiUnuttumPaneli_Load);
            this.gradiantPanel1.ResumeLayout(false);
            this.gradiantPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradiantPanel gradiantPanel1;
        private System.Windows.Forms.MaskedTextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox TxtKimlikNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Onayla;
        private System.Windows.Forms.MaskedTextBox TxtSifreTekrar;
        private System.Windows.Forms.Label ŞifreTekrar;
        private System.Windows.Forms.Label label3;
    }
}