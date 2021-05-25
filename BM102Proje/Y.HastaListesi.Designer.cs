
namespace BM102Proje
{
    partial class YoneticiHasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiHasta));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.GeriDon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hastaview = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeriDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaview)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.GeriDon);
            this.bunifuGradientPanel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-3, -1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1087, 453);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.Transparent;
            this.GeriDon.BackgroundImage = global::BM102Proje.Properties.Resources.back_button_computer_left_blue_116903;
            this.GeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GeriDon.Location = new System.Drawing.Point(16, 14);
            this.GeriDon.Margin = new System.Windows.Forms.Padding(4);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(45, 42);
            this.GeriDon.TabIndex = 60;
            this.GeriDon.TabStop = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(963, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.hastaview);
            this.groupBox1.Location = new System.Drawing.Point(15, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1044, 366);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Listesi";
            // 
            // hastaview
            // 
            this.hastaview.AllowUserToAddRows = false;
            this.hastaview.AllowUserToDeleteRows = false;
            this.hastaview.AllowUserToResizeColumns = false;
            this.hastaview.AllowUserToResizeRows = false;
            this.hastaview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastaview.Location = new System.Drawing.Point(5, 32);
            this.hastaview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hastaview.Name = "hastaview";
            this.hastaview.ReadOnly = true;
            this.hastaview.RowHeadersWidth = 51;
            this.hastaview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.hastaview.RowTemplate.Height = 24;
            this.hastaview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.hastaview.Size = new System.Drawing.Size(1033, 316);
            this.hastaview.TabIndex = 0;
            this.hastaview.SelectionChanged += new System.EventHandler(this.hastaview_SelectionChanged);
            // 
            // YoneticiHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YoneticiHasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Listesi";
            this.Load += new System.EventHandler(this.YoneticiHasta_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GeriDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hastaview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox GeriDon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView hastaview;
    }
}