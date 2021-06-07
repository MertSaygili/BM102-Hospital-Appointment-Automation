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
    public partial class YoneticiRandevu : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");
        public YoneticiRandevu()
        {
            InitializeComponent();
        }

        private void YoneticiRandevu_Load(object sender, EventArgs e)
        {
            randevugoster();
            asigoster();
        }
        public void randevugoster()
        {
            //veritabanından verileri okuyup tabloya yazdırıyoruz
            string tcno = KullanıcıGirişiMenü.ilet;
            baglantı.Open();
            OleDbDataAdapter komut = new OleDbDataAdapter("Select KimlikNumarası,Sehir,Hastane,Polikinlik,DoktorAdi,Tarih,Saat from Randevular", baglantı);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            randevuview1.DataSource = dt;

            //hücrelerin boyutunu ayarlıyoruz
            randevuview1.Columns[0].Width = 100;
            randevuview1.Columns[1].Width = 90;
            randevuview1.Columns[2].Width = 100;
            randevuview1.Columns[3].Width = 150;
            randevuview1.Columns[4].Width = 150;
            randevuview1.Columns[5].Width = 92;
            randevuview1.Columns[6].Width = 60;
            //hücrelerin başlıklarını düzenliyoruz
            randevuview1.Columns[0].HeaderText = "T.C. No";
            randevuview1.Columns[1].HeaderText = "Şehir";
            randevuview1.Columns[2].HeaderText = "Hastane";
            randevuview1.Columns[3].HeaderText = "Polikinlik";
            randevuview1.Columns[4].HeaderText = "Doktor";
            randevuview1.Columns[5].HeaderText = "Tarih";
            randevuview1.Columns[6].HeaderText = "R.Saati";

            //başlıkların rengini ayarladık.
            randevuview1.EnableHeadersVisualStyles = false;
            randevuview1.ColumnHeadersDefaultCellStyle.BackColor = Color.Thistle;

            baglantı.Close();
            kontrol();
        }
        public void asigoster()
        {
            //veritabanından verileri okuyup tabloya yazdırıyoruz
            string tcno = KullanıcıGirişiMenü.ilet;
            baglantı.Open();
            OleDbDataAdapter komut = new OleDbDataAdapter("Select KimlikNumarası,Sehir,Hastane,Tarih,Saat,AsiTipi from AsiRandevulari", baglantı);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            asirandevulariview.DataSource = dt;

            //hücrelerin boyutunu ayarlıyoruz
            asirandevulariview.Columns[0].Width = 143;
            asirandevulariview.Columns[1].Width = 90;
            asirandevulariview.Columns[2].Width = 100;
            asirandevulariview.Columns[3].Width = 150;
            asirandevulariview.Columns[4].Width = 150;
            asirandevulariview.Columns[5].Width = 92;
            //hücrelerin başlıklarını düzenliyoruz
            asirandevulariview.Columns[0].HeaderText = "T.C. No";
            asirandevulariview.Columns[1].HeaderText = "Şehir";
            asirandevulariview.Columns[2].HeaderText = "Hastane";
            asirandevulariview.Columns[3].HeaderText = "Tarih";
            asirandevulariview.Columns[4].HeaderText = "Saat";
            asirandevulariview.Columns[5].HeaderText = "Aşı Tipi";

            //başlıkların rengini ayarladık.
            asirandevulariview.EnableHeadersVisualStyles = false;
            asirandevulariview.ColumnHeadersDefaultCellStyle.BackColor = Color.Thistle;

            baglantı.Close();
            kontrol1();
        }
        public void kontrol()
        {
            DateTime simdi = DateTime.Now.Date; // bugünü gün ay yıl olarak alıyoruz.
            for (int j = 0; j < randevuview1.Rows.Count; j++)
            {
                string[] tarih_dizi = new string[3];
                tarih_dizi = randevuview1.Rows[j].Cells[5].Value.ToString().Split('.');
                int ay = Convert.ToInt32(tarih_dizi[1]);
                int yil = Convert.ToInt32(tarih_dizi[2]);
                int gun = Convert.ToInt32(tarih_dizi[0]);
                DateTime rand = new DateTime(yil, ay, gun);

                //her satırdaki tarihi bugünle kıyaslayarak ileri mi geçmiş mi bugün mü randevu var diye sorguluyoruz.
                if (DateTime.Compare(simdi, rand) < 0)
                {
                    randevuview1.Rows[j].Cells[0].Style.BackColor = Color.LightCyan;
                    randevuview1.Rows[j].Cells[1].Style.BackColor = Color.LightCyan;
                    randevuview1.Rows[j].Cells[2].Style.BackColor = Color.LightCyan; //eğer tarih ilerki bir günse hücreleri bu renge boyuyoruz.
                    randevuview1.Rows[j].Cells[3].Style.BackColor = Color.LightCyan;
                    randevuview1.Rows[j].Cells[4].Style.BackColor = Color.LightCyan;
                    randevuview1.Rows[j].Cells[5].Style.BackColor = Color.LightCyan;
                    randevuview1.Rows[j].Cells[6].Style.BackColor = Color.LightCyan;
                }
                else if (DateTime.Compare(simdi, rand) == 0)
                {
                    randevuview1.Rows[j].Cells[0].Style.BackColor = Color.LightCoral;
                    randevuview1.Rows[j].Cells[1].Style.BackColor = Color.LightCoral;
                    randevuview1.Rows[j].Cells[2].Style.BackColor = Color.LightCoral; //eğer randevu günü bugünse yeşile boyuyoruz.
                    randevuview1.Rows[j].Cells[3].Style.BackColor = Color.LightCoral;
                    randevuview1.Rows[j].Cells[4].Style.BackColor = Color.LightCoral;
                    randevuview1.Rows[j].Cells[5].Style.BackColor = Color.LightCoral;
                    randevuview1.Rows[j].Cells[6].Style.BackColor = Color.LightCoral;
                }
                else
                {
                    randevuview1.Rows[j].Cells[0].Style.BackColor = Color.Tomato;
                    randevuview1.Rows[j].Cells[1].Style.BackColor = Color.Tomato;
                    randevuview1.Rows[j].Cells[2].Style.BackColor = Color.Tomato; // eğer randevu günü geçmişse kırmızıya boyuyoruz.
                    randevuview1.Rows[j].Cells[3].Style.BackColor = Color.Tomato;
                    randevuview1.Rows[j].Cells[4].Style.BackColor = Color.Tomato;
                    randevuview1.Rows[j].Cells[5].Style.BackColor = Color.Tomato;
                    randevuview1.Rows[j].Cells[6].Style.BackColor = Color.Tomato;
                }
            }
        }
        public void kontrol1()
        {
            DateTime simdi = DateTime.Now.Date; // bugünü gün ay yıl olarak alıyoruz.
            for (int j = 0; j < asirandevulariview.Rows.Count; j++)
            {
                string[]  Atarih_dizi = asirandevulariview.Rows[j].Cells[3].Value.ToString().TrimEnd().Split('.');
                int Aay = Convert.ToInt32(Atarih_dizi[1]);
                int Ayil = Convert.ToInt32(Atarih_dizi[2]);
                int Agun = Convert.ToInt32(Atarih_dizi[0]);
                DateTime rand = new DateTime(Ayil, Aay, Agun);

                //her satırdaki tarihi bugünle kıyaslayarak ileri mi geçmiş mi bugün mü randevu var diye sorguluyoruz.
                if (DateTime.Compare(simdi, rand) < 0)
                {
                    asirandevulariview.Rows[j].Cells[0].Style.BackColor = Color.LightCyan;
                    asirandevulariview.Rows[j].Cells[1].Style.BackColor = Color.LightCyan;
                    asirandevulariview.Rows[j].Cells[2].Style.BackColor = Color.LightCyan; //eğer tarih ilerki bir günse hücreleri bu renge boyuyoruz.
                    asirandevulariview.Rows[j].Cells[3].Style.BackColor = Color.LightCyan;
                    asirandevulariview.Rows[j].Cells[4].Style.BackColor = Color.LightCyan;
                    asirandevulariview.Rows[j].Cells[5].Style.BackColor = Color.LightCyan;
                }
                else if (DateTime.Compare(simdi, rand) == 0)
                {
                    asirandevulariview.Rows[j].Cells[0].Style.BackColor = Color.LightCoral;
                    asirandevulariview.Rows[j].Cells[1].Style.BackColor = Color.LightCoral;
                    asirandevulariview.Rows[j].Cells[2].Style.BackColor = Color.LightCoral; //eğer randevu günü bugünse yeşile boyuyoruz.
                    asirandevulariview.Rows[j].Cells[3].Style.BackColor = Color.LightCoral;
                    asirandevulariview.Rows[j].Cells[4].Style.BackColor = Color.LightCoral;
                    asirandevulariview.Rows[j].Cells[5].Style.BackColor = Color.LightCoral;
                }
                else
                {
                    asirandevulariview.Rows[j].Cells[0].Style.BackColor = Color.Tomato;
                    asirandevulariview.Rows[j].Cells[1].Style.BackColor = Color.Tomato;
                    asirandevulariview.Rows[j].Cells[2].Style.BackColor = Color.Tomato; // eğer randevu günü geçmişse kırmızıya boyuyoruz.
                    asirandevulariview.Rows[j].Cells[3].Style.BackColor = Color.Tomato;
                    asirandevulariview.Rows[j].Cells[4].Style.BackColor = Color.Tomato;
                    asirandevulariview.Rows[j].Cells[5].Style.BackColor = Color.Tomato;
                }
            }
        }
        private void randevuview1_Sorted(object sender, EventArgs e)
        {
            kontrol();
        }
        private void asirandevulariview_Sorted(object sender, EventArgs e)
        {
            kontrol1();
        }

        private void randevuview1_SelectionChanged(object sender, EventArgs e)
        {
            randevuview1.ClearSelection(); // Her seçimde seçimleri temizler.
        }
        private void asirandevulariview_SelectionChanged(object sender, EventArgs e)
        {
            asirandevulariview.ClearSelection(); // Her seçimde seçimleri temizler.
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            YoneticiMenu YM = new YoneticiMenu();
            YM.Show();                              //Geri dön tuşu ile ana menüye dönüyoruz
            this.Hide();
        }
    }
}
