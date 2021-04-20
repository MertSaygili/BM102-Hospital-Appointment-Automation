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
using System.Threading;

namespace BM102Proje
{
    public partial class SifremiUnuttumPaneli : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=BM102Proje;Integrated Security=True");
        public SifremiUnuttumPaneli()
        {
            InitializeComponent();
        }

        private void gradiantPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SifremiUnuttumPaneli_Load(object sender, EventArgs e)  
        {
            // textboxlardaki alt çizgilerin gözükmesini kapatıyor

            TxtKimlikNo.PromptChar = ' ';
            TxtSifre.PromptChar = ' ';
            TxtSifreTekrar.PromptChar = ' ';

        }
        private void Temizle()  //temizleme
        {
            TxtKimlikNo.Text = " ";
            TxtSifre.Text = " ";
            TxtSifreTekrar.Text = " ";
        }

        private void Onayla_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand kmt1 = new SqlCommand("Select * From HastaBilgileri where HastaKimlikNumarası=@a1 ", baglanti);  //ilk önce kimlik kontrolünü yapıyorum
            kmt1.Parameters.AddWithValue("@a1", TxtKimlikNo.Text);
            SqlDataReader dr1 = kmt1.ExecuteReader();
            if (dr1.Read()) //kimlik sql'deki kodlarla eşleşiyorsa
            {
                baglanti.Close();
                baglanti.Open();

                //Buranın devamı email atımı veya telefona sms atımı şeklinde bir şey geliştirelibilir.-madem kullanıcıdan telefon alıyoruz kullanalım-

                SqlCommand kmt2 = new SqlCommand("Update HastaBilgileri set HastaSifre=@a2 where HastaKimlikNumarası=@a3",baglanti);    //ikinci olarak kimlik numarasına ait sifreyi değiştiriyorum
                if(TxtSifre.Text == TxtSifreTekrar.Text && TxtSifre.Text != null)   //şifreler birbiriyle işleşiyor mu? şifre null değil mi? Kontrol
                {
                    kmt2.Parameters.AddWithValue("@a3", TxtKimlikNo.Text);
                    kmt2.Parameters.AddWithValue("@a2", TxtSifre.Text);
                    kmt2.ExecuteNonQuery();     // Şifre'yi değiştirdi
                }
                else
                {
                    MessageBox.Show("Birbiriyle uyuşmayan şifreler!");
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Sistemde kayıtlı olmayan kimlik numarası!");
                //-Threading(uyutma koyup - sayaç ile farklı bir şeyler yapabilirim)
                Temizle();
            }




            baglanti.Close();
        }
    }
}
