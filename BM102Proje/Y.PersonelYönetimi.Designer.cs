
namespace BM102Proje
{
    partial class PersonelYönetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelYönetimi));
            this.gradiantPanel1 = new BM102Proje.GradiantPanel();
            this.Yönetici_cıkar = new System.Windows.Forms.Button();
            this.yönetici_ekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradiantPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradiantPanel1
            // 
            this.gradiantPanel1.ColorBot = System.Drawing.Color.LightCyan;
            this.gradiantPanel1.ColorTop = System.Drawing.Color.LightSeaGreen;
            this.gradiantPanel1.Controls.Add(this.label1);
            this.gradiantPanel1.Controls.Add(this.button1);
            this.gradiantPanel1.Controls.Add(this.Yönetici_cıkar);
            this.gradiantPanel1.Controls.Add(this.yönetici_ekle);
            this.gradiantPanel1.Controls.Add(this.groupBox1);
            this.gradiantPanel1.Location = new System.Drawing.Point(-2, -1);
            this.gradiantPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradiantPanel1.Name = "gradiantPanel1";
            this.gradiantPanel1.Size = new System.Drawing.Size(859, 508);
            this.gradiantPanel1.TabIndex = 0;
            // 
            // Yönetici_cıkar
            // 
            this.Yönetici_cıkar.BackColor = System.Drawing.Color.DarkGray;
            this.Yönetici_cıkar.Location = new System.Drawing.Point(302, 392);
            this.Yönetici_cıkar.Name = "Yönetici_cıkar";
            this.Yönetici_cıkar.Size = new System.Drawing.Size(193, 76);
            this.Yönetici_cıkar.TabIndex = 3;
            this.Yönetici_cıkar.Text = "Yönetici çıkar";
            this.Yönetici_cıkar.UseVisualStyleBackColor = false;
            this.Yönetici_cıkar.Click += new System.EventHandler(this.Yönetici_cıkar_Click);
            // 
            // yönetici_ekle
            // 
            this.yönetici_ekle.BackColor = System.Drawing.Color.DarkGray;
            this.yönetici_ekle.Location = new System.Drawing.Point(42, 392);
            this.yönetici_ekle.Name = "yönetici_ekle";
            this.yönetici_ekle.Size = new System.Drawing.Size(193, 76);
            this.yönetici_ekle.TabIndex = 2;
            this.yönetici_ekle.Text = "Yönetici ekle";
            this.yönetici_ekle.UseVisualStyleBackColor = false;
            this.yönetici_ekle.Click += new System.EventHandler(this.yönetici_ekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 273);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yöneticiler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BM102Proje.Properties.Resources.back_button_computer_left_blue_116903;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(15, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 44);
            this.button1.TabIndex = 21;
            this.button1.TabStop = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 14F);
            this.label1.Location = new System.Drawing.Point(330, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Yönetici Bilgileri";
            // 
            // PersonelYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(857, 505);
            this.Controls.Add(this.gradiantPanel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PersonelYönetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Yönetimi";
            this.Load += new System.EventHandler(this.PersonelYönetimi_Load);
            this.gradiantPanel1.ResumeLayout(false);
            this.gradiantPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradiantPanel gradiantPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button yönetici_ekle;
        private System.Windows.Forms.Button Yönetici_cıkar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox button1;
    }
}