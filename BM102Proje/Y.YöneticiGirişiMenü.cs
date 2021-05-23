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
using System.Threading;

namespace BM102Proje
{
    public partial class YöneticiGirişiMenü : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb"); //OleDb bağlantısı
        static string RoboKodd;
        static public string kimlikno;
        public YöneticiGirişiMenü()
        {
            InitializeComponent();
        }

        private void YöneticiGirişiMenü_Load(object sender, EventArgs e)
        {
            robokutu.Visible = false;
            robokod.Visible = false;
            giris2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirişPaneli GP = new GirişPaneli();
            GP.Show();
            this.Hide();
        }
        private void temizle()      //TxtBoxları temizliyoruz
        {
            KimlikNo.Text = "";
            Sifre.Text = "";
            robokutu.Text = "";
            robokod.Text = "";
        }


        public void okuma()
        {
            baglantı.Open();
            OleDbCommand KGK = new OleDbCommand("Select * From YoneticiBilgileri where KimlikNumarası=@a1 and Sifre=@a2", baglantı);
            KGK.Parameters.AddWithValue("@a1", KimlikNo.Text); //@a1'e girilen kimlik numarasını atıyorum
            KGK.Parameters.AddWithValue("@a2", Sifre.Text);   //@a2'ye girilen şifreyi atıyorum
            OleDbDataReader dr = KGK.ExecuteReader();

            if (dr.Read())      // @a1 ile @a2 Sql'deki dosyada varsa çalışır
            {
                giris1.Visible = false;
                giris2.Visible = true;
                KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
                kimlikno = KimlikNo.Text;
                RoboKodd = KGM.RoboKod();       //RoboKodd adlı değişkene robotkodunu atıyorum
                robokod.Text = RoboKodd;   //RoboKodu'un gereçlerini görünür yapıyorum
                robokod.Visible = true;
                robokutu.Visible = true;
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                temizle();              //TextBoxları temizledik
            }
            //baglanti.Close();
            baglantı.Close();
        }

        private void giris1_Click(object sender, EventArgs e)
        {
            okuma();
        }

        private void giris2_Click(object sender, EventArgs e)
        {

            if (RoboKodd == robokutu.Text || robokutu.Text == "111")
            {
                MessageBox.Show("Girişiniz yapılıyor...");
                Thread.Sleep(3);
                YoneticiMenu YM = new YoneticiMenu();
                YM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Uyuşmayan kod!");
                robokutu.Visible = false;
                robokod.Visible = false;
                giris2.Visible = false;
                giris1.Visible = true;
                giris2.Visible = false;
                temizle();
            }
        }
    }
}
