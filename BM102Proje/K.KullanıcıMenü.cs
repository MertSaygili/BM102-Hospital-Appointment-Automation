using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace BM102Proje
{
    public partial class KullanıcıMenü : Form
    {
        public static string ad;
        public static string soyad;
        public static string mail;
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");  //OleDb bağlantısı
        //SqlConnection baglanti = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=BM102Proje;Integrated Security=True"); SQl Bağlantısı
        public KullanıcıMenü()
        {
            InitializeComponent();
        }

        private void KullanıcıMenü_Load(object sender, EventArgs e)
        { 
            string a = KullanıcıGirişiMenü.ilet;    //Kullanıcı giriş menüsünden  ilet adlı stringi a adlı stringde atıyoruz
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select HastaAdı, HastaSoyadı, HastaEmailAdresi from HastaBilgileri where HastaKimlikNumarası=@a1", baglantı);
            komut.Parameters.AddWithValue("@a1", a);
            OleDbDataReader dr = komut.ExecuteReader();

           /* baglanti.Open();
            SqlCommand kmt = new SqlCommand("Select HastaAdı, HastaSoyadı from HastaBilgileri where HastaKimlikNumarası=@a1",baglanti);
            kmt.Parameters.AddWithValue("@a1", a);
            SqlDataReader dr = kmt.ExecuteReader(); */

            while (dr.Read())
            {
                AdSoyad.Text = "Merhaba, " + dr.GetString(0) + " "  + dr.GetString(1);  //ad soyadı ekrana yazdırıyoruz
                ad = dr.GetString(0);
                soyad = dr.GetString(1);
                mail = dr.GetString(2);
            }
            baglantı.Close();
            //baglanti.Close();
            duyurulariguncelle();
            aktifrandevuupdate();
        }
        private void duyurulariguncelle()
        {
            baglantı.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From Duyurular", baglantı);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Rows[0].Selected = false;
            baglantı.Close();
        }
        private void aktifrandevuupdate()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select Sehir,Hastane,Polikinlik,DoktorAdi,Tarih,Saat From Randevular where KimlikNumarası=@a1", baglantı);
            komut.Parameters.AddWithValue("@a1", KullanıcıGirişiMenü.ilet); // DataBase Komutu ayarlanıyor
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = new DataTable(); // bir data table oluşturdum
            da.SelectCommand = komut;
            da.Fill(dt);    // datatable'ı databasedan aldığımız veriler ile dolduruyoruz
            dataGridView1.DataSource = dt; // veri kaynağı belirleniyor
            dataGridView1.Rows[0].Selected = false; // daha hoş görünmesi için yapıyorum bunu
            dataGridView1.Columns[0].HeaderText = "Şehir";
            dataGridView1.Columns[1].HeaderText = "Hastane";
            dataGridView1.Columns[2].HeaderText = "Polikinlik";
            dataGridView1.Columns[3].HeaderText = "Doktor Adı";
            dataGridView1.Columns[4].HeaderText = "Tarih";
            dataGridView1.Columns[5].HeaderText = "Saat";
            baglantı.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AsiRandevusu ar = new AsiRandevusu();
            ar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
            KGM.Show();
            this.Hide();
        }

        private void BilgilerimButtonBox_Click(object sender, EventArgs e)
        {
            BilgilerimiGüncelle bm = new BilgilerimiGüncelle();
            bm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
            KGM.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            RandevuAl randevu = new RandevuAl();
            randevu.Show();
            this.Hide();
        }

        private void Sikayet_Click(object sender, EventArgs e)
        {
            Sikayetİstek sikayetistek = new Sikayetİstek();
            sikayetistek.Show();
        }
    }
}
