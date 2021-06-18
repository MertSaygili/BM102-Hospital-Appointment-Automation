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
    public partial class Sikayetİstek : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\veritabani_access.mdb");
        public Sikayetİstek()
        {
            InitializeComponent();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            this.Close(); //paneli kapatır
        }

        private void onaylabutton_Click(object sender, EventArgs e)
        {
            if(SikayetKonu.Text != "" && SikayetSikayet.Text != "")
            {
                //eğer tüm kutucuklar doluysa girilen verileri alıp veritabanına kaydeder.
                baglantı.Open();
                OleDbCommand komut = new OleDbCommand("insert into Sikayetler (Konu,Sikayet) values (@p1,@p2)", baglantı);
                komut.Parameters.AddWithValue("@p1", SikayetKonu.Text);
                komut.Parameters.AddWithValue("@p2", SikayetSikayet.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Talebiniz başarıyla iletilmiştir.\nSağlıklı günler!");
                this.Close();
            }
        }

        private void Sikayetİstek_Load(object sender, EventArgs e)
        {

        }
    }
}
