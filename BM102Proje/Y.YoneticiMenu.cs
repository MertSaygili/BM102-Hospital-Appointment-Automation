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
using System.Timers;


namespace BM102Proje
{
    public partial class YoneticiMenu : Form
    {
        public int sayac = 0;
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");  //OleDb bağlantısı
        public YoneticiMenu()
        {
            InitializeComponent();
        }

        private void YoneticiMenu_Load(object sender, EventArgs e)
        {
            sayacayarlari();
            tarihsaat.Text = Convert.ToString(DateTime.Now).Substring(0,10);
            string a = YöneticiGirişiMenü.kimlikno;
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select Ad, Soyad from YoneticiBilgileri where KimlikNumarası=@a1", baglantı);
            komut.Parameters.AddWithValue("@a1", a);
            OleDbDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                hosgeldin.Text = "Sayın, " + dr.GetString(0) + " " + dr.GetString(1);  //ad soyadı ekrana yazdırıyoruz
            }
            baglantı.Close();
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            YöneticiGirişiMenü KGM = new YöneticiGirişiMenü();
            KGM.Show();
            this.Hide();
        }
        private void sayacayarlari()
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void doktorekle_Click(object sender, EventArgs e)
        {
            DoktorEkleMenu DM = new DoktorEkleMenu();
            this.Hide();
            DM.Show();
        }
    }
}
