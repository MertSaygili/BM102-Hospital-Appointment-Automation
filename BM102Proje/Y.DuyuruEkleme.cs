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
    public partial class DuyuruEkle : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");
        public DuyuruEkle()
        {
            InitializeComponent();
        }

        private void onaylabutton_Click(object sender, EventArgs e)
        {
            //onayla butonuna basılınca girdileri veritabanına kaydeder. Ardından panlei kapatır.
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("insert into Duyurular (Duyuru) values (@p1)", baglantı);
            komut.Parameters.AddWithValue("@p1", DuyuruEkleText.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Duyuru sisteme başarıyla eklenmiştir.");
            this.Close();
        }

        private void DuyuruEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
