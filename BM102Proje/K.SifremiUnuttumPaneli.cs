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
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace BM102Proje
{
    public partial class SifremiUnuttumPaneli : Form
    {
        //SqlConnection baglanti = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=BM102Proje;Integrated Security=True"); Sql baglantı
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");
        MailMessage mesajım1 = new MailMessage();
        public string kod1;
        public string ad, soyad, email_adresi;
        public SifremiUnuttumPaneli()
        {
            InitializeComponent();
        }
        private void SifremiUnuttumPaneli_Load(object sender, EventArgs e)  
        {      
            // textboxlardaki alt çizgilerin gözükmesini kapatıyor

            TxtKimlikNo.PromptChar = ' ';
            TxtSifre.PromptChar = ' ';
            TxtSifreTekrar.PromptChar = ' ';

            //Robo kod gereçlerini kapatıyorum
            sakla();
        }
        private void göster()
        {
            //Robo kodları gösteriyorum
            Gönder.Visible = true;
            TxtRoboKod.Visible = true;

            //Değiştir butonu kapatıyorum
            Onayla.Enabled = false;
        }
        private void sakla()
        {
            //Robo kodları gizliyorum
            Gönder.Visible = false;
            TxtRoboKod.Visible = false;

            //Değiştir butonu acıyorum
            Onayla.Enabled = true; ;
        }
        private void Temizle()  //temizleme
        {
            TxtKimlikNo.Text = " ";
            TxtSifre.Text = " ";
            TxtSifreTekrar.Text = " ";
            TxtRoboKod.Text = " ";
        }
        private void Onayla_Click(object sender, EventArgs e)
        {
            baglantı.Close();
            //baglanti.Open();
            baglantı.Open();
            /* SQL baglantısı
            SqlCommand kmt1 = new SqlCommand("Select * From HastaBilgileri where HastaKimlikNumarası=@a1 ", baglanti);  //ilk önce kimlik kontrolünü yapıyorum
            kmt1.Parameters.AddWithValue("@a1", TxtKimlikNo.Text);
            SqlDataReader dr1 = kmt1.ExecuteReader();
            */

            OleDbCommand kmt1 = new OleDbCommand("Select HastaKimlikNumarası From HastaBilgileri where HastaKimlikNumarası=@a1 ", baglantı);
            kmt1.Parameters.AddWithValue("@a1", TxtKimlikNo.Text);
            OleDbDataReader dr1 = kmt1.ExecuteReader();
            if (dr1.Read()) //girilen kimlik datada varsa çalışır
            {
                //SqlCommand kmt2 = new SqlCommand("Update HastaBilgileri set HastaSifre=@a2 where HastaKimlikNumarası=@a3",baglanti);    //Sql komudu
                if(TxtSifre.Text == TxtSifreTekrar.Text && TxtSifre.Text != string.Empty)   //şifreler birbiriyle eşleşiyor mu? şifre null değil mi? Kontrol
                {
                    baglantı.Close();
                    email_gönder();
                    göster();

                }
                else
                {
                    MessageBox.Show("Birbiriyle uyuşmayan şifreler!");
                    Temizle();
                    
                }
            }
            else
            {
                MessageBox.Show("Sistemde kayıtlı olmayan kimlik numarası!");
                //-Threading(uyutma koyup - sayaç ile farklı bir şeyler yapabilirim)
                Temizle();
            }
        }

        private void button1_Click(object sender, EventArgs e) //geri butonu
        {
            KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
            KGM.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e) //menü yönlendir 
        {
            KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
            KGM.Show();
            this.Hide();
        }

        private void Gönder_Click(object sender, EventArgs e) // son adım, sifre değiştirme
        {
            if (TxtRoboKod.Text == kod1) //email'e gönderilen kodla kullanıcının girdiği kodu karşılaştırıyorum
            {
                //Şifre değiştiriliyor

                baglantı.Open();

                OleDbCommand kmt2 = new OleDbCommand("UPDATE HastaBilgileri SET HastaSifre = @a1 where HastaKimlikNumarası = @a2", baglantı);//ikinci olarak kimlik numarasına ait sifreyi değiştiriyorum

                kmt2.Parameters.AddWithValue("@a1", TxtSifre.Text);
                kmt2.Parameters.AddWithValue("@a2", TxtKimlikNo.Text);
                kmt2.ExecuteNonQuery();
                MessageBox.Show("Şifreniz başarıyla değiştirilmiştir, giriş yap menüsüne yönlendiriliyorsunuz.");

                KullanıcıGirişiMenü kgm = new KullanıcıGirişiMenü();
                kgm.Show();
                this.Hide();


                baglantı.Close();

            }
            else
            {
                MessageBox.Show("Uyuşmayan robo kod!");
                Temizle();
                sakla();
            }
        }

        private void Datadan_kullanıcı_ad_soyad_al()
        {
            string kimlik_numarası = TxtKimlikNo.Text;
            baglantı.Open();

            OleDbCommand kmt1 = new OleDbCommand("Select HastaAdı, HastaSoyadı, HastaEmailAdresi  From HastaBilgileri where HastaKimlikNumarası = @a1", baglantı);
            kmt1.Parameters.AddWithValue("@a1", kimlik_numarası);
            OleDbDataReader dr = kmt1.ExecuteReader();
            while (dr.Read())
            {
                ad = dr.GetString(0);
                soyad = dr.GetString(1);
                email_adresi = dr.GetString(2);
            }


            baglantı.Close();
        }
        private void email_gönder()
        {
            Datadan_kullanıcı_ad_soyad_al();

            //Mail atmak için gereken ayarlamalar

            KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
            kod1 = KGM.RoboKod();

            mesajım1.From = new MailAddress("csmk_csmk@outlook.com");
            mesajım1.To.Add(email_adresi); // Mail'in gittiği adres
            mesajım1.IsBodyHtml = true;     // 'body' kısmını HTML'e açık hale getiriyorum ki html kullanılabilsin 
            mesajım1.Subject = "BM102 Hastane Randevu Sistemi"; //"Robot Kodunu paneldeki boşluğa giriniz";
            mesajım1.Body =
                "<html>" +
                    "<body style = ' font family:Cambria; '>" +
                        "<div style='border-color:red; height:50%; margin-left:30%; margin-right:30%; margin-top:5%; width:50%; '>" +
                            "<p style = ' text-align:left; font-size:160%; '>" + "Sayın, " + ad + " " + soyad.ToUpper() +  "</p>" +
                            "<hr>" + "<br>" +
                            "<p style = 'font-size:130%; text-align:justify;'>" + "Sizin email adresiniz kullanılarak BM102 Hastane Randevu Sistemin'de şifreniz değiştirilmeye çalışılmaktadır." + "</p>" +
                            "<br>" +
                            "<p style = 'font-size:130%; text-align:justify;'>" + "Şifre değiştirmeye çalışan kişi sizseniz şifre değiştirme kodunuz aşağıdadır, lütfen bu kodu sisteme giriniz. Kodu girdikten sonra şifreniz başarıyla değiştirilmiş olacaktır." + "</p>" +
                            "<p style ='font-size:200%; text-align:center;  color:red; '> " + "<bold>" + "<mark style ='background-color: yellow; color:red;  '>" + kod1 + "</mark>" + "</bold>" + "</p>" +
                            "<br>" +
                            "<p>" + "İletişime geçmek için: sedanurgfb6671@hotmail.com ,absaltukab@gmail.com, mert71719601@gmail.com" + "</p>" +
                            "<p style = 'text-align: bottom; font-size:80%; font-style: italic;'>" + "Otomatik bir mesajdır, lütfen bu mesaj üzerinden cevap vermeyiniz!" + "</p>" +
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
    }
}
