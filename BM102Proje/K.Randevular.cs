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
    public partial class Randevular : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");
        public Randevular()
        {
            InitializeComponent();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            KullanıcıMenü KM = new KullanıcıMenü();
            KM.Show();                              //Geri dön tuşu ile ana menüye dönüyoruz
            this.Hide();
        }

        private void Randevular_Load(object sender, EventArgs e)
        {
            randevugoster();
        }
        public void randevugoster()
        {
            //veritabanından verileri okuyup tabloya yazdırıyoruz
            string tcno = KullanıcıGirişiMenü.ilet;
            baglantı.Open();
            OleDbDataAdapter komut = new OleDbDataAdapter("Select Sehir,Hastane,Polikinlik,DoktorAdi,Tarih,Saat from Randevular where KimlikNumarası=@a1", baglantı);
            komut.SelectCommand.Parameters.AddWithValue("@a1", tcno);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            randevuview.DataSource = dt;

            //hücrelerin boyutunu ayarlıyoruz
            randevuview.Columns[0].Width = 80;
            randevuview.Columns[1].Width = 150;
            randevuview.Columns[2].Width = 150;
            randevuview.Columns[3].Width = 150;
            randevuview.Columns[4].Width = 92;
            randevuview.Columns[5].Width = 60;

            //hücrelerin başlıklarını düzenliyoruz
            randevuview.Columns[0].HeaderText = "Şehir";
            randevuview.Columns[1].HeaderText = "Hastane";
            randevuview.Columns[2].HeaderText = "Polikinlik";
            randevuview.Columns[3].HeaderText = "Doktor Adı";
            randevuview.Columns[4].HeaderText = "Tarih";
            randevuview.Columns[5].HeaderText = "Saat";

            //başlıkların rengini ayarladık.
            randevuview.EnableHeadersVisualStyles = false;
            randevuview.ColumnHeadersDefaultCellStyle.BackColor = Color.Thistle;

            baglantı.Close();
            kontrol();
        }
        public void kontrol()
        {
            DateTime simdi = DateTime.Now.Date; // bugünü gün ay yıl olarak alıyoruz.
            for (int j = 0; j < randevuview.Rows.Count; j++)
            {
                string[] tarih_dizi = new string[3];
                tarih_dizi = randevuview.Rows[j].Cells[4].Value.ToString().Split('.');
                int ay = Convert.ToInt32(tarih_dizi[1]);
                int yil = Convert.ToInt32(tarih_dizi[2]);
                int gun = Convert.ToInt32(tarih_dizi[0]);
                DateTime rand = new DateTime(yil,ay,gun);

                //her satırdaki tarihi bugünle kıyaslayarak ileri mi geçmiş mi bugün mü randevu var diye sorguluyoruz.
                if (DateTime.Compare(simdi, rand) < 0)
                {
                    randevuview.Rows[j].Cells[0].Style.BackColor = Color.LightCyan;
                    randevuview.Rows[j].Cells[1].Style.BackColor = Color.LightCyan;
                    randevuview.Rows[j].Cells[2].Style.BackColor = Color.LightCyan; //eğer tarih ilerki bir günse hücreleri bu renge boyuyoruz.
                    randevuview.Rows[j].Cells[3].Style.BackColor = Color.LightCyan;
                    randevuview.Rows[j].Cells[4].Style.BackColor = Color.LightCyan;
                    randevuview.Rows[j].Cells[5].Style.BackColor = Color.LightCyan;
                }
                else if (DateTime.Compare(simdi, rand) == 0)
                {
                    randevuview.Rows[j].Cells[0].Style.BackColor = Color.LightCoral;
                    randevuview.Rows[j].Cells[1].Style.BackColor = Color.LightCoral;
                    randevuview.Rows[j].Cells[2].Style.BackColor = Color.LightCoral; //eğer randevu günü bugünse yeşile boyuyoruz.
                    randevuview.Rows[j].Cells[3].Style.BackColor = Color.LightCoral;
                    randevuview.Rows[j].Cells[4].Style.BackColor = Color.LightCoral;
                    randevuview.Rows[j].Cells[5].Style.BackColor = Color.LightCoral;
                }
                else
                {
                    randevuview.Rows[j].Cells[0].Style.BackColor = Color.Tomato;
                    randevuview.Rows[j].Cells[1].Style.BackColor = Color.Tomato;
                    randevuview.Rows[j].Cells[2].Style.BackColor = Color.Tomato; // eğer randevu günü geçmişse kırmızıya boyuyoruz.
                    randevuview.Rows[j].Cells[3].Style.BackColor = Color.Tomato;
                    randevuview.Rows[j].Cells[4].Style.BackColor = Color.Tomato;
                    randevuview.Rows[j].Cells[5].Style.BackColor = Color.Tomato;
                }                   
            }
        }

        private void randevuview_SelectionChanged(object sender, EventArgs e)
        {
            randevuview.ClearSelection(); // Her seçimde seçimleri temizler.
        }

        private void randevuview_Sorted(object sender, EventArgs e)
        {
            kontrol(); // Sıraladığı zaman da renkler bozulmasın diye sıralandığında tekrar kontrol eder.
        }
    }
}
