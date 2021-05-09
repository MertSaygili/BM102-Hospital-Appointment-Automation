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
    public partial class AsiRandevusu : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");
        static int adet;
        public AsiRandevusu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //*
        }

        private void temizle()
        {
            AsiSehir.SelectedIndex = -1;
            AsiSaat.SelectedIndex = -1;
            AsiHastane.Text = "";
        }
        private void GeriDon_Click(object sender, EventArgs e)
        {
            KullanıcıMenü KM = new KullanıcıMenü();
            KM.Show();
            this.Hide();
        }

        private void AsiSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            //*
        }

        private void AsiHastane_TextChanged(object sender, EventArgs e)
        {
            //*
        }

        private void AsiSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //*
        }

        private int kontrolsagla()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("SELECT count (KimlikNumarası) from AsiRandevulari", baglantı);
            adet = System.Convert.ToInt32(komut.ExecuteScalar());
            baglantı.Close();
            return adet;
        }
        private void bilgileriyaz() {
            baglantı.Open();
            string tcno = KullanıcıGirişiMenü.ilet;
            OleDbCommand komut = new OleDbCommand("insert into AsiRandevulari (KimlikNumarası,Sehir,Hastane,Saat,Tarih) values (@p1,@p2,@p3,@p4,@p5)", baglantı);
            komut.Parameters.AddWithValue("@p1", tcno);
            komut.Parameters.AddWithValue("@p2", AsiSehir.SelectedItem);
            komut.Parameters.AddWithValue("@p3", AsiHastane.Text);
            komut.Parameters.AddWithValue("@p4", AsiSaat.SelectedItem);
            komut.Parameters.AddWithValue("@p5", AsiTarih.Value);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }
        private void OnaylaButon_Click(object sender, EventArgs e)
        {
            //*
            if (AsiHastane.Text!= "" && AsiSehir.SelectedIndex >= 0 && AsiSaat.SelectedIndex >= 0)
            {
                if (kontrolsagla() < 1) { 
                bilgileriyaz();
                MessageBox.Show("Randevunuz oluşturulmuştur.");
                temizle();
                }
                else
                {
                    MessageBox.Show("Sistemde daha önceden alınmış bir randevunuz zaten var.");
                }
            }
            else
            {
                MessageBox.Show("Girdilerde eksik var!");
            }
        }

        private void IptalButon_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
