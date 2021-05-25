
namespace BM102Proje
{
    partial class Randevular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevular));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randevuview = new System.Windows.Forms.DataGridView();
            this.GeriDon = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevuview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeriDon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.tarih);
            this.bunifuGradientPanel1.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel1.Controls.Add(this.GeriDon);
            this.bunifuGradientPanel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1016, 453);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // tarih
            // 
            this.tarih.CalendarForeColor = System.Drawing.Color.Cornsilk;
            this.tarih.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.tarih.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.tarih.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.tarih.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.tarih.Enabled = false;
            this.tarih.Location = new System.Drawing.Point(734, 26);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(265, 31);
            this.tarih.TabIndex = 57;
            this.tarih.Value = new System.DateTime(2021, 5, 25, 14, 5, 45, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.randevuview);
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 376);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevularım";
            // 
            // randevuview
            // 
            this.randevuview.AllowUserToAddRows = false;
            this.randevuview.AllowUserToDeleteRows = false;
            this.randevuview.AllowUserToResizeColumns = false;
            this.randevuview.AllowUserToResizeRows = false;
            this.randevuview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevuview.Location = new System.Drawing.Point(6, 32);
            this.randevuview.Name = "randevuview";
            this.randevuview.ReadOnly = true;
            this.randevuview.RowHeadersWidth = 51;
            this.randevuview.RowTemplate.Height = 24;
            this.randevuview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.randevuview.Size = new System.Drawing.Size(980, 331);
            this.randevuview.TabIndex = 0;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.Transparent;
            this.GeriDon.BackgroundImage = global::BM102Proje.Properties.Resources.back_button_computer_left_blue_116903;
            this.GeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GeriDon.Location = new System.Drawing.Point(13, 14);
            this.GeriDon.Margin = new System.Windows.Forms.Padding(4);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(45, 42);
            this.GeriDon.TabIndex = 54;
            this.GeriDon.TabStop = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // Randevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Randevular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevular";
            this.Load += new System.EventHandler(this.Randevular_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.randevuview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeriDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox GeriDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView randevuview;
        private System.Windows.Forms.DateTimePicker tarih;
    }
}