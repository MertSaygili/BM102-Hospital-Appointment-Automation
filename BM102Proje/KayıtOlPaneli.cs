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
using System.Net.Mail;

namespace BM102Proje
{
    public partial class KayıtOlPaneli : Form
    {
        // !!!!!Şifrelerin textboxları değişebilir, sayı girişi, harf girişi sayısı ayarlanmalı, şifreleri yıldız olarak göstermeli !!!!!
        // bir şeyler ekledim

        SqlConnection baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = BM102Proje; Integrated Security = True");
        MailMessage mesajım1 = new MailMessage();
        string kod1;
        int i = 0;
        public KayıtOlPaneli()
        {
            InitializeComponent();
        }
        private void temizle()  //Hatalar yapılırsa kullanıcının girdiklerini temizlemek için
        {
            TxtVatandaşİsmi.Text = " ";
            TxtVatandaşSoyİsim.Text = " ";
            TxtVatandaşKimlikNumarası.Text = " ";
            TxtVatandaşEmail.Text = " ";
            TxtVatandaşTelNumarası.Text = " ";
            TxtŞifre.Text = " ";
            TxtŞifreTekrar.Text = " ";
            TxtKullanıcıRobosu.Text = " ";
            RoboKod.Text = " ";
            
        }
        public void mail()
        {
            //Mail atmak için gereken ayarlamalar

            KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
            kod1 = KGM.RoboKod();

            mesajım1.From = new MailAddress("csmk_csmk@outlook.com");
            mesajım1.To.Add(TxtVatandaşEmail.Text);
            mesajım1.Subject = "Robot Kodunu paneldeki boşluğa giriniz";
            mesajım1.Body = kod1;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("csmk_csmk@outlook.com", "CSharpmail");
            smtp.Host = "smtp.live.com"; //  smtp.gmail.com -> gmail için
            smtp.EnableSsl = true;
            smtp.Port = 587;

            smtp.Send(mesajım1);
    
        }
        private void SayacGöster()
        {
            //Kullanıcı ilk aşamayı doğru yaparsa çalışacak bölüm

            timer1.Start();
            Sayac.Visible = true;
            TxtKullanıcıRobosu.Visible = true;
            Gönder.Visible = true;
        }
        private void SayacSakla()
        {
            //Email alımı için gereken gereçlerin panel açıldığında görünmemesini sağlar

            Sayac.Visible = false;
            RoboKod.Visible = false;
            TxtKullanıcıRobosu.Visible = false;
            Gönder.Visible = false;
        }
        private void BilgiKaydet()
        {
            //Kullanıcının girdiği girdiler 2 aşamadanda doğru olarak geçerse, kullanıcının verilerinin kayıt edilmesini sağlar

            baglanti.Open();

            SqlCommand cmd1 = new SqlCommand("insert into HastaBilgileri (HastaAdı,HastaSoyadı,HastaKimlikNumarası,HastaEmailAdresi,TelefonNumarası,HastaSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            cmd1.Parameters.AddWithValue("@p1", TxtVatandaşİsmi.Text);
            cmd1.Parameters.AddWithValue("@p2", TxtVatandaşSoyİsim.Text);
            cmd1.Parameters.AddWithValue("@p3", TxtVatandaşKimlikNumarası.Text);
            cmd1.Parameters.AddWithValue("@p4", TxtVatandaşEmail.Text);
            cmd1.Parameters.AddWithValue("@p5", TxtVatandaşTelNumarası.Text);
            cmd1.Parameters.AddWithValue("@p6", TxtŞifre.Text);

            cmd1.ExecuteNonQuery();

            baglanti.Close();
        }
        private void KayıtOl_Click(object sender, EventArgs e)
        {
            KayıtOl.Enabled = false;    //Kayıt ol'a tekrar basılmasını önlüyorum

            if(TxtVatandaşİsmi.Text != " " && Label2.Text != " " && KN.Text != " " && E.Text != " " && TN.Text != " " && S.Text != " ")  //Kullanıcının boşlukları boş bırakmasını önlüyorum
            {
                if (TxtŞifre.Text==TxtŞifreTekrar.Text)     //Girdiği şifrelerin uyumuna bakıyorum
                {
                    mail();
                    MessageBox.Show("Mailinize gönderilmiş olan kodu boşluğa giriniz.");
                    SayacGöster();
                    RoboKod.Text = kod1;
                }
                else
                {
                    MessageBox.Show("Şifreleriniz uyuşmuyor!");
                    temizle();
                    KayıtOl.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Boşlukları doldurunuz!");
                temizle();
                KayıtOl.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Kullanıcının kodu girmesi için geri sayım

            i++;
            Sayac.Text = i.ToString();
            if (i == 120)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz doldu!");
                temizle();
                SayacSakla();
            }

        }
        private void KayıtOlPaneli_Load(object sender, EventArgs e)
        {
            //Şifre bloklarındaki alt cizgilerini kapatır

            TxtŞifre.PromptChar = ' ';
            TxtŞifreTekrar.PromptChar = ' ';

            //Sayac ayarları

            Sayac.Font = new Font("George", 15);
            Sayac.ForeColor = Color.Black;
            Sayac.TextAlign = ContentAlignment.MiddleCenter;

            SayacSakla();

        }

        private void Gönder_Click(object sender, EventArgs e)
        {
            //Son aşama olan maile gönderilen kodla kullanıcının girdiği kodu karşılaştırıyorum ve kullanıcının boş kod girmesini önlüyorum
            if (String.Compare(RoboKod.Text, TxtKullanıcıRobosu.Text) == 0 && RoboKod.Text != " ")
            {
                MessageBox.Show("kod doğru");
                BilgiKaydet();      //Kullanıcının bilgilerini kaydediyorum
                timer1.Stop();
                i = 0;
                //Kullanıcının gönderilmek istendiği yer gelir...
                KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
                KGM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Uyuşmayan kod!");
                temizle();
                SayacSakla();
                KayıtOl.Enabled = true;
            }
        }
    }
}
