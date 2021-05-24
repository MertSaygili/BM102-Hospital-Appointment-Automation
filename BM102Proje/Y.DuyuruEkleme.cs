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
    public partial class DuyuruEkle : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");
        public DuyuruEkle()
        {
            InitializeComponent();
        }
        private void DuyuruEkle_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * from Duyurular", baglantı);
            OleDbDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                string duyuru = dr.GetString(0);             //duyuruları comboxın içine koyuyoruz.
                duyurucikarma.Items.Add(duyuru);
            }

            baglantı.Close();
            duyurutext.Hide();
            DuyuruEkleText.Hide();
            onaylabutton.Hide();
            duyurucikarma.Hide();
            onaylabuton1.Hide();
        }
        private void onaylabutton_Click(object sender, EventArgs e)
        {
            //onayla butonuna basılınca girdileri veritabanına kaydeder.
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("insert into Duyurular (Duyuru) values (@p1)", baglantı);
            komut.Parameters.AddWithValue("@p1", DuyuruEkleText.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Duyuru sisteme başarıyla eklenmiştir.");
            this.Close(); // paneli kapatır
        }

        private void onaylabuton1_Click(object sender, EventArgs e)
        {
            //onayla butonuna basılınca girilen sıradaki veriyi veritabanından siler. Sonra tekrardan başa dönderir.
            string sira = duyurucikarma.SelectedItem.ToString();
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Delete * From Duyurular Where Duyuru = @a1", baglantı);
            komut.Parameters.AddWithValue("@a1", sira);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Duyuru sistemden başarıyla silinmiştir.");
            this.Close();
        }

        private void ekleme_Click(object sender, EventArgs e)
        {
            duyurucikarma.Hide();
            onaylabuton1.Hide();
            duyurutext.Show();
            DuyuruEkleText.Show();
            onaylabutton.Show();
        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            DuyuruEkleText.Hide();
            onaylabutton.Hide();
            duyurutext.Show();
            duyurucikarma.Show();
            onaylabuton1.Show();
        }
    }
}
