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
            randevuview.Columns[5].HeaderText = "R.Saati";

            baglantı.Close();
            kontrol();
        }
        public void kontrol()
        {
            string[] simdi = Convert.ToString(tarih.Value).Split('.');
            for(int i = 0; i<randevuview.Rows.Count; i++)
            {
                int j = 2;
                Console.WriteLine(randevuview.Rows[i].Cells[4]);
                string[] rand = Convert.ToString(randevuview.Rows[i].Cells[4]).Split('.');
                Console.WriteLine(randevuview.Rows[i].Cells[4]); 
                Console.WriteLine(rand[0]);
                    if (Convert.ToInt32(simdi[j])>= Convert.ToInt32(rand[j]))
                    {

                    }
                    else if (Convert.ToInt32(simdi[j-1]) > Convert.ToInt32(rand[j-1]))
                    {
                        randevuview.Rows[i].Cells[0].Style.BackColor = Color.Green;
                        randevuview.Rows[i].Cells[1].Style.BackColor = Color.Green;
                        randevuview.Rows[i].Cells[2].Style.BackColor = Color.Green;
                        randevuview.Rows[i].Cells[3].Style.BackColor = Color.Green;
                        randevuview.Rows[i].Cells[4].Style.BackColor = Color.Green;
                        randevuview.Rows[i].Cells[5].Style.BackColor = Color.Green;
                    }
                    else if (Convert.ToInt32(simdi[j - 2]) > Convert.ToInt32(rand[j - 2]))
                    {
                        randevuview.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        randevuview.Rows[i].Cells[1].Style.BackColor = Color.Red;
                        randevuview.Rows[i].Cells[2].Style.BackColor = Color.Red;
                        randevuview.Rows[i].Cells[3].Style.BackColor = Color.Red;
                        randevuview.Rows[i].Cells[4].Style.BackColor = Color.Red;
                        randevuview.Rows[i].Cells[5].Style.BackColor = Color.Red;
                    }
            }
        }
    }
}
