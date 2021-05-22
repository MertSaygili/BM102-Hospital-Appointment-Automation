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
using System.Data.OleDb;
using System.Net;

namespace BM102Proje
{
    public partial class KayıtOlPaneli : Form
    {
        // !!!!!Şifrelerin textboxları değişebilir, sayı girişi, harf girişi sayısı ayarlanmalı, şifreleri yıldız olarak göstermeli !!!!!
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");      //OleDb bağlantısı
        //SqlConnection baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = BM102Proje; Integrated Security = True"); SQL bağlantısı
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
            string soyisim = TxtVatandaşSoyİsim.Text;
            
            //birden fazla ismi olan insanlar için isimlerinin ilk harfini büyük yapmaya çalışıyorum
            string[] isim;
            isim = TxtVatandaşİsmi.Text.Split(' '); // kullanıcının girdiği isimleri böldüm
            

            StringBuilder Sb = new StringBuilder(); //Sb adında stringbuilder ile string oluşturudum

            for(int i=0; i<isim.Length; i++)        // for döngüsüyle her ismi char arrayine dönüştürdüm ardından ilkk harfleri büyüterek hepsini stringe geri çevirdim ve stringleri topladım
            {
                char[] ad = isim[i].ToCharArray();
                ad[0] = char.ToUpper(ad[0]);
                isim[i] = new string(ad);
                Sb.Append(isim[i] + " ");
            }


            /*  tek isimli insanlar için ismin ilk harfini büyütüyor
            char[] isim = TxtVatandaşİsmi.Text.ToCharArray();
            isim[0] = char.ToUpper(isim[0]);
            string ad = new string(isim);
            */

            //Mail atmak için gereken ayarlamalar

            KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
            kod1 = KGM.RoboKod();

            mesajım1.From = new MailAddress("csmk_csmk@outlook.com");
            mesajım1.To.Add(TxtVatandaşEmail.Text);
            mesajım1.IsBodyHtml = true;     // 'body' kısmını HTML'e açık hale getiriyorum ki html kullanılabilsin 
            mesajım1.Subject = "BM102 Hastane Randevu Sistemi"; //"Robot Kodunu paneldeki boşluğa giriniz";
            mesajım1.Body = 
                "<html>" +
                    "<body style = ' font family: Cambria; '>" +
                        "<div style='border-color:red; height:50%; margin-left:30%; margin-right:30%; margin-top:7%; width:50%; '>" +
                            "<p style = ' text-align:left; font-size:160%; '>" + "Sayın, " + Sb.ToString() + " " + TxtVatandaşSoyİsim.Text.ToUpper() +  "</p>" +
                            "<hr>" + "<br>" +
                            "<p style = 'font-size: 130%; '>" + "Sizin email adresiniz kullanılarak BM102 Hastane Randevu Sistemin'e kayıt olmaya çalışılmaktadır." + "</p>" + 
                            "<br>" +
                            "<p style = 'font-size:130%;'>" + "Kayıt olmaya çalışan kişi sizseniz aktivaston kodunuz aşağıdadır, lütfen bu kodu sisteme giriniz. Kodu girdikten sonra kaydınız başarıyla yapılmış olacaktır." + "</p>" +
                            "<p style ='font-size:200%; text-align:center;  color:red; '> " + "<bold>" + "<mark style ='background-color: yellow; color:red;  '>" + kod1 + "</mark>" + "</bold>" + "</p>" +
                            "<br>" +
                            "<p>" + "İletişime geçmek için: sedanurgfb6671@hotmail.com ,absaltukab@gmail.com, mert71719601@gmail.com" + "</p>" +
                            "<p style = 'text-align: bottom; font-size:80%; font-style: italic;'>" + "Otomatik bir mesajdır, lütfen bu mesaj üzerinden cevap vermeyiniz" + "</p>" +
                        "</div>" +
                    "</body>" +
                "</html>";

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

            baglantı.Open();
            //OleDbCommand komut = new OleDbCommand("insert into HastaBilgileri (HastaAdı, HastaSoyadı, HastaKimlikNumarası, HastaEmailAdresi, TelefonNumarası, HastaSifre) values ('" + TxtVatandaşİsmi.Text.ToString() + "','" + TxtVatandaşSoyİsim.Text.ToString() + "','" + TxtVatandaşKimlikNumarası.Text.ToString() + "','" + TxtVatandaşEmail.Text.ToString() + "','" + TxtVatandaşTelNumarası.Text.ToString() + "','" + TxtŞifre.Text.ToString() + "')", baglantı);
            OleDbCommand komut = new OleDbCommand("insert into HastaBilgileri (HastaAdı,HastaSoyadı,HastaKimlikNumarası,HastaEmailAdresi,TelefonNumarası,HastaSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglantı);
            komut.Parameters.AddWithValue("@p1", TxtVatandaşİsmi.Text);
            komut.Parameters.AddWithValue("@p2", TxtVatandaşSoyİsim.Text);
            komut.Parameters.AddWithValue("@p3", TxtVatandaşKimlikNumarası.Text);
            komut.Parameters.AddWithValue("@p4", TxtVatandaşEmail.Text);
            komut.Parameters.AddWithValue("@p5", TxtVatandaşTelNumarası.Text);
            komut.Parameters.AddWithValue("@p6", TxtŞifre.Text);

            komut.ExecuteNonQuery();
            baglantı.Close();

          /*  baglanti.Open();

            SqlCommand cmd1 = new SqlCommand("insert into HastaBilgileri (HastaAdı,HastaSoyadı,HastaKimlikNumarası,HastaEmailAdresi,TelefonNumarası,HastaSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            cmd1.Parameters.AddWithValue("@p1", TxtVatandaşİsmi.Text);
            cmd1.Parameters.AddWithValue("@p2", TxtVatandaşSoyİsim.Text);
            cmd1.Parameters.AddWithValue("@p3", TxtVatandaşKimlikNumarası.Text);
            cmd1.Parameters.AddWithValue("@p4", TxtVatandaşEmail.Text);
            cmd1.Parameters.AddWithValue("@p5", TxtVatandaşTelNumarası.Text);
            cmd1.Parameters.AddWithValue("@p6", TxtŞifre.Text);

            cmd1.ExecuteNonQuery();

            baglanti.Close(); */
        }
        private void KayıtOl_Click(object sender, EventArgs e)
        {
            KayıtOl.Enabled = false;    //Kayıt ol'a tekrar basılmasını önlüyorum

            if(TxtVatandaşİsmi.Text != "" && TxtVatandaşSoyİsim.Text != "" && TxtVatandaşKimlikNumarası.Text != "" && TxtVatandaşEmail.Text!= "" && TxtVatandaşTelNumarası.Text != "")  //Kullanıcının boşlukları boş bırakmasını önlüyorum
            {
                if (TxtŞifre.Text==TxtŞifreTekrar.Text && TxtŞifre.Text != "")     //Girdiği şifrelerin uyumuna bakıyorum
                {
                    mail();
                    Console.WriteLine(kod1);
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

            KullanıcıGirişiMenü kgm = new KullanıcıGirişiMenü();

        }

        private void Gönder_Click(object sender, EventArgs e)
        {
            //Son aşama olan maile gönderilen kodla kullanıcının girdiği kodu karşılaştırıyorum ve kullanıcının boş kod girmesini önlüyorum
            if (String.Compare(RoboKod.Text, TxtKullanıcıRobosu.Text) == 0 && RoboKod.Text != " ")
            {
                MessageBox.Show("Kaydınız başarıyla yapılmıştır.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
            KGM.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
            KGM.Show();
            this.Hide();
        }
    }
}
