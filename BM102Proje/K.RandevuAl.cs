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
        static int sayi;
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");
        public RandevuAl()
        {
            InitializeComponent();
        }

        private void RandevuOnaylaButon_Click(object sender, EventArgs e)
        {
            if (RandevuHastaneAdiText.Text != "" && RandevuSehir.SelectedIndex >= 0 && RandevuSaat.SelectedIndex >= 0 && RandevuPolAdi.SelectedIndex >= 0)
            {
                //KONTROL AMAÇLI MESSAGEBOX. SONRA SİLİNECEK.
                //int a = kontrol();
                //MessageBox.Show("bu kadar "+a);
                if (kontrol() < 1)
                {
                    randevuyaz();
                    MessageBox.Show("Randevunuz oluşturulmuştur.");
                    temizle();
                }
                else
                {
                    MessageBox.Show("Bu saatte doktorun randevusu bulunmaktadır. Lütfen başka bir saat ya başka bir hekim deneyiniz.");
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
            komut.Parameters.AddWithValue("@p6", RandevuTarih.Value);
            komut.Parameters.AddWithValue("@p7", RandevuSaat.SelectedItem);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }
        private int kontrol()
        {
            //BU KISIMLA ALAKALI ÇÖZÜM DEVAM EDİYOR. O YÜZDEN HEP 0 DÖNDERİYOR DÜZELENE KADAR.
            /*baglantı.Open();
            OleDbCommand komut = new OleDbCommand("SELECT count (KimlikNumarası,Sehir,Hastane,Polikinlik,DoktorAdi,Tarih,Saat) from Randevular", baglantı);
            sayi = System.Convert.ToInt32(komut.ExecuteScalar());
            baglantı.Close();*/
            return 0;
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
    }
}
