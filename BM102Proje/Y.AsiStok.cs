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
    public partial class AsiStok : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");  //OleDb bağlantısı
        public double biontech_adet = 0;
        public double sinovac_adet = 0;
        public double biontech_yuzde;
        public double sinovac_yuzde;
        public AsiStok()
        {
            InitializeComponent();
        }

        private void AsiStok_Load(object sender, EventArgs e)
        {
            BiontechBar.ProgressColor = System.Drawing.Color.FromArgb(188,204,53);
            SinovacBar.ProgressColor = System.Drawing.Color.FromArgb(198, 26, 13);
            sayacayarlari();
            asi_update();   
        }
        private void asi_update()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select Biontech,Sinovac from AsiStok", baglantı); // Elimizdeki Asi Stogu Sistemden Cekildi
            OleDbDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                biontech_adet = Convert.ToInt32(dr.GetString(0));
                sinovac_adet = Convert.ToInt32(dr.GetString(1));
            }


            OleDbCommand komut2 = new OleDbCommand("Select count(AsiTipi) from AsiRandevulari where AsiTipi=@a1", baglantı);
            komut2.Parameters.AddWithValue("@a1", "Biontech");                                                                  // Randevulardan Alınan Biontech Çekildi
            double yapilan_biontech = System.Convert.ToDouble(komut2.ExecuteScalar());


            OleDbCommand komut3 = new OleDbCommand("Select count(AsiTipi) from AsiRandevulari where AsiTipi=@a1", baglantı);
            komut3.Parameters.AddWithValue("@a1", "Sinovac");                       // Randevulardan Alınan Sinovac çekilidi
            double yapilan_sinovac = System.Convert.ToDouble(komut3.ExecuteScalar());
            baglantı.Close();


            double kalan_biontech_adet = biontech_adet - yapilan_biontech;
            double kalan_sinovac_adet = sinovac_adet - yapilan_sinovac;                  // En son 2 değer çıkartılarak eldeki stok bulundu.
            Console.WriteLine("{0} {1}", biontech_adet, sinovac_adet);
            biontech_yuzde = (kalan_biontech_adet / biontech_adet) * 100;
            sinovac_yuzde = (kalan_sinovac_adet / sinovac_adet) * 100;
        }
        private void sayacayarlari()
        {
            timer1.Interval = 25;
            timer2.Interval = 25;
            timer1.Start();
            timer2.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BiontechBar.Value < Math.Floor(biontech_yuzde))
            {
                BiontechBar.Value += 1;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (SinovacBar.Value < Math.Floor(sinovac_yuzde))
            {
                SinovacBar.Value += 1;
            }
            else
            {
                timer2.Stop();
            }
        }
    }
}
