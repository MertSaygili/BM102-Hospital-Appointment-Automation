using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BM102Proje
{
    public partial class DoktorEkleMenu : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\veritabani_access.mdb");

        public DoktorEkleMenu()
        {
            InitializeComponent();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            YoneticiMenu YM = new YoneticiMenu();
            YM.Show();
            this.Hide();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            DoktorPol.SelectedIndex = -1;
            doktoradi.Text = "";
            doktorsoyadkutu.Text = "";
        }

        private void temizleme()
        {
            DoktorPol.SelectedIndex = -1;
            doktoradi.Text = "";
            doktorsoyadkutu.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onaylabuton_Click(object sender, EventArgs e)
        {
            if (doktoradi.Text != "" && DoktorPol.SelectedIndex >= 0 && doktorsoyadkutu.Text != "")
            {
                if (kontrol() == 1) // KONTROLDEN BİR GELİRSE BAŞARIYLA YAZABİLİR
                {
                    doktorekle();
                    MessageBox.Show("Doktor başarıyla eklenmiştir.");
                    temizleme();
                }
                else
                {
                    MessageBox.Show("Bu doktor zaten mevcut."); // ÖBÜRTÜRLÜ DATABASEDA VERİ VAR DEMEK
                    temizleme();
                }
            }
            else
            {
                MessageBox.Show("Girdilerde eksik var!");
            }
        }

        private int kontrol()
        {
            return 1;
            // şu an bir şartım yok bunu konuşuruz
        }

        private void doktorekle()
        {
            baglantı.Open();
            string tcno = KullanıcıGirişiMenü.ilet;
            OleDbCommand komut = new OleDbCommand("insert into Doktorlar (Poliklinik,Ad,Soyad) values (@p1,@p2,@p3)", baglantı);
            komut.Parameters.AddWithValue("@p2", DoktorPol.SelectedItem);
            komut.Parameters.AddWithValue("@p2", doktoradi.Text);
            komut.Parameters.AddWithValue("@p3", doktorsoyadkutu.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }
    }
}
