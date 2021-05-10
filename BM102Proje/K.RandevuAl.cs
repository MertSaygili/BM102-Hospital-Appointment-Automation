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
    
    public partial class RandevuAl : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");
        public RandevuAl()
        {
            InitializeComponent();
        }

        private void RandevuOnaylaButon_Click(object sender, EventArgs e)
        {
            if (RandevuHastaneAdiText.Text != "" && RandevuSehir.SelectedIndex >= 0 && RandevuSaat.SelectedIndex >= 0 && RandevuPolAdi.SelectedIndex >= 0)
            {
                if (kontrol() == 1) // KONTROLDEN BİR GELİRSE BAŞARIYLA YAZABİLİR
                {
                    randevuyaz();
                    MessageBox.Show("Randevunuz oluşturulmuştur.");
                    temizle();
                }
                else
                {
                    MessageBox.Show("Bu saatte doktorun randevusu bulunmaktadır. Lütfen başka bir saat ya başka bir hekim deneyiniz."); // ÖBÜRTÜRLÜ DATABASEDA VERİ VAR DEMEK
                    temizlesaat();
                }
            }
            else
            {
                MessageBox.Show("Girdilerde eksik var!");
            }
        }
        private void randevuyaz()
        {
            baglantı.Open();
            string tcno = KullanıcıGirişiMenü.ilet;
            OleDbCommand komut = new OleDbCommand("insert into Randevular (KimlikNumarası,Sehir,Hastane,Polikinlik,DoktorAdi,Tarih,Saat) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglantı);
            komut.Parameters.AddWithValue("@p1", tcno);
            komut.Parameters.AddWithValue("@p2", RandevuSehir.SelectedItem);
            komut.Parameters.AddWithValue("@p3", RandevuHastaneAdiText.Text);
            komut.Parameters.AddWithValue("@p4", RandevuPolAdi.SelectedItem);
            komut.Parameters.AddWithValue("@p5", RandevuDoktorAdi.SelectedItem);
            komut.Parameters.AddWithValue("@p6", Convert.ToString(RandevuTarih.Value));
            komut.Parameters.AddWithValue("@p7", RandevuSaat.SelectedItem);
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

        private void RandevuIptalButon_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            RandevuDoktorAdi.SelectedIndex = -1;
            RandevuPolAdi.SelectedIndex = -1;
            RandevuHastaneAdiText.Text = "";
            RandevuSehir.SelectedIndex = -1;
            RandevuSaat.SelectedIndex = -1;
        }
        private void temizlesaat()
        {
            RandevuSaat.SelectedIndex = -1;
        }
        private void GeriDon_Click_1(object sender, EventArgs e)
        {
            KullanıcıMenü KM = new KullanıcıMenü();
            KM.Show();
            this.Hide();
        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {

        }
        
    }
}
