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
using System.Net.Mail;
using System.Net;
using CefSharp;
using CefSharp.WinForms;
namespace BM102Proje
{
    
    public partial class RandevuAl : Form
    {
        public int sayac = 0;
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");
        MailMessage mesajım1 = new MailMessage();
        static public StringBuilder url = new StringBuilder("https://www.google.com/maps/search/");
        public RandevuAl()
        {
            InitializeComponent();
        }

        private void randevuyaz()
        {
            baglantı.Open();
            string tcno = KullanıcıGirişiMenü.ilet;
            OleDbCommand komut = new OleDbCommand("insert into Randevular (KimlikNumarası,Sehir,Hastane,Polikinlik,DoktorAdi,Tarih,Saat,Sikayet) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglantı);
            komut.Parameters.AddWithValue("@p1", tcno);
            komut.Parameters.AddWithValue("@p2", RandevuSehir.SelectedItem);
            komut.Parameters.AddWithValue("@p3", RandevuHastaneAdiText.Text);
            komut.Parameters.AddWithValue("@p4", RandevuPolAdi.SelectedItem);    //Aldığımız verileri database'e kaydediyoruz.
            komut.Parameters.AddWithValue("@p5", RandevuDoktorAdi.SelectedItem);
            komut.Parameters.AddWithValue("@p6", Convert.ToString(RandevuTarih.Value).Substring(0,10));
            komut.Parameters.AddWithValue("@p7", RandevuSaat.SelectedItem);
            komut.Parameters.AddWithValue("@p8", RandevuSikayet.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }
        private int kontrol()
        {
            int total = 0;
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select Sehir, Hastane, Tarih, Saat, Polikinlik, DoktorAdi from Randevular", baglantı);
            OleDbDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                string sehir = dr.GetString(0);
                string hastane = dr.GetString(1);
                string tarih = dr.GetString(2);         // SOL TARAFTAKİLER DATABASEDEN GELEN VERİYİ TEMSİL EDİYOR
                string saat = dr.GetString(3);
                string pol = dr.GetString(4);
                string doktor = dr.GetString(5);
                if (sehir == Convert.ToString(RandevuSehir.SelectedItem) &&
                    hastane == RandevuHastaneAdiText.Text &&
                    tarih.Substring(0, 10) == Convert.ToString(RandevuTarih.Value).Substring(0, 10) &&     // BURADA DA KULLANICININ SEÇTİKLERİ İLE DATABASEI KARŞILAŞTIRIYORUM
                    saat == Convert.ToString(RandevuSaat.SelectedItem) && 
                    pol == Convert.ToString(RandevuPolAdi.SelectedItem) &&
                    doktor == Convert.ToString(RandevuDoktorAdi.SelectedItem)
                    )
                {
                    total += 1; // EĞER GİRİLEN VERİ DATABASEDE VARSA TOTALİ 1 KEZ ARTIRIYORUM
                }
            }
            baglantı.Close();
            if (total >= 1)
            {
                return 0; // EĞER EN AZ 1 KERE o VERİ BULUNDUYSA 0 döndürüyor
            }
            else
            {
                return 1; // EĞER SEÇİLEN VERİYİ DATABASEDE BULAMADIYSA 1 döndürüyor
            }
        }

        private void temizle()
        {
            RandevuDoktorAdi.SelectedIndex = -1;
            RandevuPolAdi.SelectedIndex = 0;
            RandevuHastaneAdiText.Text = ""; //butona basıldığında kutucukları temizleyen fonksiyon
            RandevuSehir.SelectedIndex = -1;
            RandevuSaat.SelectedIndex = -1;
        }
        private void temizlesaat()
        {
            RandevuSaat.SelectedIndex = -1; // eğer hastanın istediği randevu saatinde zaten bir randevu varsa saati sıfırlıyoruz
        }
        private void GeriDon_Click_1(object sender, EventArgs e)
        {
            KullanıcıMenü KM = new KullanıcıMenü();
            KM.Show();//Geri dön tuşu ile ana menüye dönüyoruz
            this.Close();
        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {
            tariyici.Visible = false;                   // taryıcı ilk başta görünür değil.
            //doktorlariyukle(); // doktorlar veritabanından çeker
        }
        
        private void doktorlariyukle()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * from Doktorlar", baglantı);
            OleDbDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                string isim = dr.GetString(1);
                string soyisim = dr.GetString(2);               //veritabanından doktorları çekiyoruz
                RandevuDoktorAdi.Items.Add(isim+" "+soyisim);   
            }
            baglantı.Close();
        }
        private void RandevuPolAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            RandevuDoktorAdi.Items.Clear();
            baglantı.Open();
            OleDbCommand kmt = new OleDbCommand("Select Ad, Soyad From Doktorlar where Poliklinik = @a1", baglantı);
            kmt.Parameters.AddWithValue("@a1 ", RandevuPolAdi.SelectedItem.ToString());
            OleDbDataReader dr1 = kmt.ExecuteReader();

            while (dr1.Read())
            {
                string isim = dr1.GetString(0);
                string soyisim = dr1.GetString(1);
                RandevuDoktorAdi.Items.Add(isim + " " + soyisim);
            }

            baglantı.Close();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (RandevuHastaneAdiText.Text != "" && RandevuSehir.SelectedIndex >= 0 && RandevuSaat.SelectedIndex >= 0 && RandevuPolAdi.SelectedIndex >= 0)
            {
                //kutucukların boş olup olmaması kontrol ediliyor.
                if (kontrol() == 1) // KONTROLDEN BİR GELİRSE BAŞARIYLA YAZABİLİR
                {
                    randevuyaz();
                    Mail_at(); //randevu bilgilerini bilgilendirme maili şeklinde mail atıyoruz.
                    MessageBox.Show("Randevunuz oluşturulmuştur.");
                    temizle();
                }
                else
                {
                    MessageBox.Show("Bu saatte doktorun randevusu bulunmaktadır. Lütfen başka bir saat ya başka bir hekim deneyiniz."); // ÖBÜRTÜRLÜ DATABASEDA VERİ VAR DEMEK
                    temizlesaat(); //o saatte randevu dolu olduğu için sadece saati sıfırlıyoruz ki kullanıcı diğer seçeneklerle tekrar uğraşmasın
                }
            }
            else
            {
                MessageBox.Show("Girdilerde eksik var!");
            }
        }
        private void Mail_at()
        {
            //verilerimizden mail isim ve soyad bilgilerini alıyoruz
            string email = KullanıcıMenü.mail;
            string isim = KullanıcıMenü.ad;
            string soyisim = KullanıcıMenü.soyad;
            //Mail atımı
            mesajım1.From = new MailAddress("csmk_csmk@outlook.com");
            mesajım1.To.Add(email); //mail gelecek
            mesajım1.IsBodyHtml = true;     // 'body' kısmını HTML'e açık hale getiriyorum ki html kullanılabilsin 
            mesajım1.Subject = "BM102 Hastane Randevu Sistemi"; //"Robot Kodunu paneldeki boşluğa giriniz";
            mesajım1.Body = 
                "<html>" +
                    "<body style = ' font family:Cambria; '>" +
                        "<div style='border-color:red; height:50%; margin-left:30%; margin-right:30%; margin-top:5%; width:50%; '>" +
                            "<p style = ' text-align:left; font-size:160%; '>" + "Sayın, " + isim.ToUpper() + " " + soyisim.ToUpper() + "</p>" +
                            "<hr>" + "<br>" +
                            "<p style = 'font-size:130%; text-align:justify;'>" + "Randevunuz, " + RandevuHastaneAdiText.Text + " " + RandevuPolAdi.SelectedItem + " Doktor " + RandevuDoktorAdi.SelectedItem + " ile " + Convert.ToString(RandevuTarih.Value) + " tarihinde saat " + RandevuSaat.SelectedItem + "'da oluşturulmuştur." + "</p>" +
                            "<br>" +
                            "<p style = 'font-size:130%; text-align:justify;'>" + "Lütfen randevu saatinizden en geç 15 dakika önce hastanenize giderek gerekli birimden randevunuzu onaylayınız." + "</p>" +
                            "<br>" +
                            "<p>" + "Herhangi bir hata bulunuyorsa iletişime geçmek için: sedanurgfb6671@hotmail.com ,absaltukab@gmail.com, mert71719601@gmail.com" + "</p>" +
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
        private void iptalbutton_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void hastanebutton_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0) { 
                if (RandevuSehir.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen Şehir Seçiniz!");
                }
                else
                {
                    this.Size = new Size(1038, 433);
                    string il = RandevuSehir.SelectedItem.ToString();
                    url.Append(il + "+"+"Hastaneleri");                 // urlyi ayarlayıp tarayıcı açıyoruz.
                    tarayiciayarla();
                    hastanebutton.Text = "Haritayı Kapat"; 
                        var script = @"
                             document.getElementsByClassName('widget-pane-toggle-button noprint')[0].click();   
                         ";
                    Program.chromeBrowser.ExecuteScriptAsyncWhenPageLoaded(script); // Side paneli otomatik kapatan JavaScript scriptini sayfa yüklendiğinde çalıştırıyoruz.
                    sayac += 1;
                }
            }
            else
            {
                tariyici.Visible = false;
                this.Size = new Size(517, 433);
                bunifuGradientPanel1.Size = new Size(509,395);
                hastanebutton.Text = "En Yakın Hastane";
                sayac += 1;
                
            }
        }
        private void tarayiciayarla()
        {
            bunifuGradientPanel1.Size = new Size(1027, 395);
            tariyici.Location = new Point(504, 0);
            tariyici.Size = new Size(525, 395);                 // Tarayıcı panel görselliği ayarlanıyor.
            tariyici.Visible = true;
            tariyici.Controls.Add(Program.chromeBrowser);           // Tarayıcı paneline browser ekleniyor.
            Program.chromeBrowser.Load(RandevuAl.url.ToString());   // url adresini tarayıca açıyoruz.
            url = new StringBuilder("https://www.google.com/maps/search/"); // URL tekrar ilk haline alınıyor.
            Program.chromeBrowser.Dock = DockStyle.Fill;    
            Cef.EnableHighDPISupport(); // Her türlü monitörde uyumlu çalışması sağlıyor.
        }

        private void RandevuAl_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
