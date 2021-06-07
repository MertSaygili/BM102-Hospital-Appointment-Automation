
namespace BM102Proje
{
    partial class YoneticiRandevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiRandevu));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.GeriDon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randevuview1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.asirandevulariview = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeriDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevuview1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asirandevulariview)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.groupBox2);
            this.bunifuGradientPanel1.Controls.Add(this.GeriDon);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.tarih);
            this.bunifuGradientPanel1.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(823, 622);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.Transparent;
            this.GeriDon.BackgroundImage = global::BM102Proje.Properties.Resources.back_button_computer_left_blue_116903;
            this.GeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GeriDon.Location = new System.Drawing.Point(14, 11);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(34, 34);
            this.GeriDon.TabIndex = 59;
            this.GeriDon.TabStop = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(755, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // tarih
            // 
            this.tarih.CalendarForeColor = System.Drawing.Color.Cornsilk;
            this.tarih.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.tarih.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.tarih.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.tarih.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.tarih.Enabled = false;
            this.tarih.Location = new System.Drawing.Point(52, 20);
            this.tarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(200, 26);
            this.tarih.TabIndex = 57;
            this.tarih.Value = new System.DateTime(2021, 5, 25, 14, 5, 45, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.randevuview1);
            this.groupBox1.Location = new System.Drawing.Point(10, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(804, 282);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevular";
            // 
            // randevuview1
            // 
            this.randevuview1.AllowUserToAddRows = false;
            this.randevuview1.AllowUserToDeleteRows = false;
            this.randevuview1.AllowUserToResizeColumns = false;
            this.randevuview1.AllowUserToResizeRows = false;
            this.randevuview1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.randevuview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevuview1.Location = new System.Drawing.Point(4, 23);
            this.randevuview1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randevuview1.Name = "randevuview1";
            this.randevuview1.ReadOnly = true;
            this.randevuview1.RowHeadersWidth = 51;
            this.randevuview1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.randevuview1.RowTemplate.Height = 24;
            this.randevuview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.randevuview1.Size = new System.Drawing.Size(795, 255);
            this.randevuview1.TabIndex = 0;
            this.randevuview1.SelectionChanged += new System.EventHandler(this.randevuview1_SelectionChanged);
            this.randevuview1.Sorted += new System.EventHandler(this.randevuview1_Sorted);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.asirandevulariview);
            this.groupBox2.Location = new System.Drawing.Point(10, 350);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(804, 261);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aşı Randevuları";
            // 
            // asirandevulariview
            // 
            this.asirandevulariview.AllowUserToAddRows = false;
            this.asirandevulariview.AllowUserToDeleteRows = false;
            this.asirandevulariview.AllowUserToResizeColumns = false;
            this.asirandevulariview.AllowUserToResizeRows = false;
            this.asirandevulariview.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.asirandevulariview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asirandevulariview.Location = new System.Drawing.Point(4, 23);
            this.asirandevulariview.Margin = new System.Windows.Forms.Padding(2);
            this.asirandevulariview.Name = "asirandevulariview";
            this.asirandevulariview.ReadOnly = true;
            this.asirandevulariview.RowHeadersWidth = 51;
            this.asirandevulariview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.asirandevulariview.RowTemplate.Height = 24;
            this.asirandevulariview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.asirandevulariview.Size = new System.Drawing.Size(795, 230);
            this.asirandevulariview.TabIndex = 0;
            this.asirandevulariview.SelectionChanged += new System.EventHandler(this.asirandevulariview_SelectionChanged);
            this.asirandevulariview.Sorted += new System.EventHandler(this.asirandevulariview_Sorted);
            // 
            // YoneticiRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(824, 622);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "YoneticiRandevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevular";
            this.Load += new System.EventHandler(this.YoneticiRandevu_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GeriDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.randevuview1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.asirandevulariview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView randevuview1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox GeriDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView asirandevulariview;
    }
}