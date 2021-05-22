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
using System.Net.Mail;

namespace BM102Proje
{
    public partial class BilgilerimiGüncelle : Form
    {
        //SqlConnection baglanti = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=BM102Proje;Integrated Security=True");
        OleDbConnection baglantı = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ..\\..\\veriler\\veritabani_access.mdb");
        MailMessage mesajım1 = new MailMessage();
        public BilgilerimiGüncelle()
        {
            InitializeComponent();
        }
        String a = KullanıcıGirişiMenü.ilet; //kullanıcı giriş menüsündeki tc kimlik numarasını aldık
        private void sıfırdan_ekle()
        {
            //baglanti.Open();

            //SqlCommand kmt = new SqlCommand("Select HastaAdı, HastaSoyadı, HastaEmailAdresi, TelefonNumarası, HastaSifre From HastaBilgileri where HastaKimlikNumarası=@a1", baglanti);
            //kmt.Parameters.AddWithValue("@a1", a);
            //SqlDataReader dr = kmt.ExecuteReader();
            //if (dr.Read())
            //{
            //    TxtAd.Text = dr.GetString(0);
            //    TxtSoyad.Text = dr.GetString(1);
            //    TxtEmail.Text = dr.GetString(2);
            //    TxtTelefon.Text = dr.GetString(3);
            //    TxtSifre.Text = dr.GetString(4);
            //    TxtKimlik.Text = a;
            //}

            //baglanti.Close();

            baglantı.Open();
            //sistemdeki bilgileri ekrana yazdırmasını sağlıyor.
            OleDbCommand kmt = new OleDbCommand("Select HastaAdı, HastaSoyadı, HastaEmailAdresi, TelefonNumarası, HastaSifre From HastaBilgileri where HastaKimlikNumarası=@a1", baglantı);
            kmt.Parameters.AddWithValue("@a1", a);
            OleDbDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                TxtAd.Text = dr.GetString(0);
                TxtSoyad.Text = dr.GetString(1);
                TxtEmail.Text = dr.GetString(2);
                TxtTelefon.Text = dr.GetString(3);
                TxtSifre.Text = dr.GetString(4);
                TxtKimlik.Text = a;
            }
            baglantı.Close();


        }
        private void değişiklik_yap()
        {
            //baglanti.Open();

            //SqlCommand kmt = new SqlCommand("Update HastaBilgileri Set HastaSifre=@a1, HastaEmailAdresi=@a2, TelefonNumarası=@a3 where HastaKimlikNumarası = @a4", baglanti);
            //kmt.Parameters.AddWithValue("@a1", TxtSifre.Text);
            //kmt.Parameters.AddWithValue("@a2", TxtEmail.Text);
            //kmt.Parameters.AddWithValue("@a3", TxtTelefon.Text);
            //kmt.Parameters.AddWithValue("@a4", TxtKimlik.Text);
            //kmt.ExecuteNonQuery();

            //baglanti.Close();


            baglantı.Open();
            //Data kodlarıyla apılmış değişikleri dataya atıyoruz
            OleDbCommand kmt = new OleDbCommand("Update HastaBilgileri Set HastaSifre=@a1, HastaEmailAdresi=@a2, TelefonNumarası=@a3 where HastaKimlikNumarası = @a4", baglantı);
            kmt.Parameters.AddWithValue("@a1", TxtSifre.Text);
            kmt.Parameters.AddWithValue("@a2", TxtEmail.Text);
            kmt.Parameters.AddWithValue("@a3", TxtTelefon.Text);
            kmt.Parameters.AddWithValue("@a4", TxtKimlik.Text);
            kmt.ExecuteNonQuery();

            baglantı.Close();
        }
        private void mail_at()
        {
            //birden fazla ismi olan insanlar için isimlerinin ilk harfini büyük yapmaya çalışıyorum
            string[] isim;
            isim = TxtAd.Text.Split(' '); // kullanıcının girdiği isimleri böldüm


            StringBuilder Sb = new StringBuilder(); //Sb adında stringbuilder ile string oluşturdum

            for (int i = 0; i < isim.Length; i++)        // for döngüsüyle her ismi char arrayine dönüştürdüm ardından ilk harfleri büyüterek hepsini stringe geri çevirdim ve stringleri topladım
            {
                char[] ad = isim[i].ToCharArray();
                ad[0] = char.ToUpper(ad[0]);
                isim[i] = new string(ad);
                Sb.Append(isim[i] + " ");
            }

            //Mail atmak için gereken ayarlamalar

            KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();

            mesajım1.From = new MailAddress("csmk_csmk@outlook.com");
            mesajım1.To.Add(TxtEmail.Text);
            mesajım1.IsBodyHtml = true;
            mesajım1.Subject = "BM102 Hastane Randevu Sistemi";
            mesajım1.Body =
                 "<html>" +
                    "<body style = ' font family:Cambria; '>" +
                        "<div style='border-color:red; height:50%; margin-left:30%; margin-right:30%; margin-top:5%; width:50%; '>" +
                            "<p style = ' text-align:left; font-size:160%; '>" + "Sayın, " + Sb.ToString() + " " + TxtSoyad.Text.ToUpper() + "</p>" +
                            "<hr>" + "<br>" +
                            "<p style = 'font-size:130%; text-align:justify;'>" + "BM102 Hastane Randevu Sistemi'ndeki bilgileriniz güncellenmeye çalışılıyor. Güncelleme yapan siz değilseniz lütfen iletişim sekmesinden bize ulaşınız!" + "</p>" +
                            "<br>" + 
                            "<p style = 'font-size:130%; text-align:justify;'>" + "Kayıt olmaya çalışan kişi sizseniz lütfen Bilgileri Güncelle ekranındaki boşluğa 'ONAYLA' yazınız. 'ONAYLA' yazıldıktan sonra bilgileriniz başarıyla güncellenmiş olacaktır." + "</p>" +
                            "<p>" + "İletişime geçmek için: sedanurgfb6671@hotmail.com ,absaltukab@gmail.com, mert71719601@gmail.com" + "</p>" +
                            "<p style = 'text-align: bottom; font-size:80%; font-style: italic;'>" + "Otomatik bir mesajdır, lütfen bu mesaj üzerinden cevap vermeyiniz!" + "</p>" +
                        "</div>" +
                    "</body>" +
                "</html>"; ;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("csmk_csmk@outlook.com", "CSharpmail");
            smtp.Host = "smtp.live.com"; //  smtp.gmail.com -> gmail için
            smtp.EnableSsl = true;
            smtp.Port = 587;

            smtp.Send(mesajım1);
        }
        private void BilgilerimiGüncelle_Load(object sender, EventArgs e)
        {
            //Ad, soyad, kimlik numarasında değişiklik olmayacağı için ad soyad ve kimlik numarasına giriş yapılmasını kapattık.
            TxtAd.Enabled = false;
            TxtSoyad.Enabled = false;
            TxtKimlik.Enabled = false;

            //Onayla butonunu ve onayla txtbox'ını zamanı gelene kadar gizledim
            Onayla.Visible = false;
            TxtOnayla.Visible = false;

            //Boşlukları Datadaki bilgiler ile dolduruyoruz
            sıfırdan_ekle(); 

        }
        private void GeriDön_Click(object sender, EventArgs e)
        {
            KullanıcıMenü KM = new KullanıcıMenü();
            KM.Show();
            this.Hide();
        }

        private void Değiştir_Click(object sender, EventArgs e)
        {

            if(TxtEmail.Text!="" || TxtTelefon.Text!="" || TxtSifre.Text != "") //Hataları girişleri önlüyoruz
            {
                MessageBox.Show("Mail adresinize bir adet mail atılmıştır...");     
                mail_at();      // mail at methodunu çağırarak mail atıyoruz
                Değiştir.Visible = false;
                Onayla.Visible = true;
                TxtOnayla.Visible = true;
            }
            else
            {
                MessageBox.Show("Geçersiz girdi");
                sıfırdan_ekle();
            }
        }

        private void Onayla_Click(object sender, EventArgs e)
        {
            if (string.Compare(TxtOnayla.Text, "ONAYLA") == 0) //Kullanıcı tarafından girilen girdi 'ONAYLA' ya eşitse 0 döndürür
            {
                MessageBox.Show("Değişiklikleriniz başarıyla yapılmıştır.");
                değişiklik_yap();
                Onayla.Visible = false; 
                TxtOnayla.Visible = false;
                Değiştir.Visible = true;
                sıfırdan_ekle();
            }
            else
            {
                MessageBox.Show("Yanlış girdi yapılmıştır!");
                sıfırdan_ekle();
            }
        }

        private void GeriDön_Click_1(object sender, EventArgs e)
        {
            KullanıcıMenü KM = new KullanıcıMenü();
            KM.Show();
            this.Hide();
        }
    }
}
