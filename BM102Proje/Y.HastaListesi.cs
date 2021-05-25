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
    public partial class YoneticiHasta : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");
        public YoneticiHasta()
        {
            InitializeComponent();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            YoneticiMenu YM = new YoneticiMenu();
            YM.Show();                              //Geri dön tuşu ile ana menüye dönüyoruz
            this.Hide();
        }

        private void YoneticiHasta_Load(object sender, EventArgs e)
        {
            kullanıcıgoster();
        }
        public void kullanıcıgoster()
        {
            //veritabanından verileri okuyup tabloya yazdırıyoruz
            string tcno = KullanıcıGirişiMenü.ilet;
            baglantı.Open();
            //HastaAdı,HastaSoyadı,HastaKimlikNumarası,HastaEmailAdresi,TelefonNumarası,HastaSifre
            OleDbDataAdapter komut = new OleDbDataAdapter("Select * from HastaBilgileri", baglantı);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            hastaview.DataSource = dt;

            //hücrelerin boyutunu ayarlıyoruz
            hastaview.Columns[0].Width = 72;
            hastaview.Columns[1].Width = 80;
            hastaview.Columns[2].Width = 120;
            hastaview.Columns[3].Width = 230;
            hastaview.Columns[4].Width = 150;
            hastaview.Columns[5].Width = 70;

            //hücrelerin başlıklarını düzenliyoruz
            hastaview.Columns[0].HeaderText = "İsim";
            hastaview.Columns[1].HeaderText = "Soyisim";
            hastaview.Columns[2].HeaderText = "T.C. No";
            hastaview.Columns[3].HeaderText = "Mail Adresi";
            hastaview.Columns[4].HeaderText = "Telefon No";
            hastaview.Columns[5].HeaderText = "Şifre";

            //başlıkların rengini ayarladık.
            hastaview.EnableHeadersVisualStyles = false;
            hastaview.ColumnHeadersDefaultCellStyle.BackColor = Color.Thistle;

            baglantı.Close();
        }

        private void hastaview_SelectionChanged(object sender, EventArgs e)
        {
            hastaview.ClearSelection(); // Her seçimde seçimleri temizler.
        }
    }
}
