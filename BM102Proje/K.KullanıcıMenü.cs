using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace BM102Proje
{
    public partial class KullanıcıMenü : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\veriler\\veritabani_access.mdb");
        SqlConnection baglanti = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=BM102Proje;Integrated Security=True");
        public KullanıcıMenü()
        {
            InitializeComponent();
        }

        private void KullanıcıMenü_Load(object sender, EventArgs e)
        {
            string a = KullanıcıGirişiMenü.ilet;
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select HastaAdı, HastaSoyadı from HastaBilgileri where HastaKimlikNumarası=@a1", baglantı);
            komut.Parameters.AddWithValue("@a1", a);
            OleDbDataReader dr = komut.ExecuteReader();
           /* baglanti.Open();
            SqlCommand kmt = new SqlCommand("Select HastaAdı, HastaSoyadı from HastaBilgileri where HastaKimlikNumarası=@a1",baglanti);
            kmt.Parameters.AddWithValue("@a1", a);
            SqlDataReader dr = kmt.ExecuteReader(); */
            while (dr.Read())
            {
                AdSoyad.Text = "Merhaba, " + dr.GetString(0) + " "  + dr.GetString(1);
            }
            baglanti.Close();
            
        }
      
    }
}
