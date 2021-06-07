using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM102Proje
{
    public partial class YoneticiBilgileri : Form
    {
        public YoneticiBilgileri()
        {
            InitializeComponent();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            YoneticiMenu YM = new YoneticiMenu();
            this.Close();
            YM.Show();
        }

        private void AsiStok_Click(object sender, EventArgs e)
        {
            AsiStok AS = new AsiStok();
            AS.Show();
        }

        private void DuyuruEkle_Click(object sender, EventArgs e)
        {
            DuyuruEkle DE = new DuyuruEkle();
            DE.Show();
        }

        private void PersonelButton_Click(object sender, EventArgs e)
        {
            PersonelYönetimi PY = new PersonelYönetimi();
            PY.Show();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Sikayet S = new Sikayet();
            S.Show();
            this.Close();
        }
    }
}
