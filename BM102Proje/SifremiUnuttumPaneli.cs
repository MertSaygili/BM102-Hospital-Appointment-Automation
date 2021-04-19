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
using System.Net.Mail;

namespace BM102Proje
{
    public partial class SifremiUnuttumPaneli : Form
    {
        //SqlConnection baglanti = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=BM102Proje;Integrated Security=True");
        //MailMessage mesajım1 = new MailMessage();
        //public SifremiUnuttumPaneli()
        //{
        //    InitializeComponent();
        //}

        //private void SifremiUnuttumPaneli_Load(object sender, EventArgs e)
        //{
        //    TxtKimlikNumarası.PromptChar = ' ';
        //    TxtSifre.PromptChar = ' ';
        //}
        //static string kimlikNo;
        //private void Mail()
        //{
        //    string email;
        //    baglanti.Open();
        //    SqlCommand komut = new SqlCommand("Select * from HastaBilgiler where HastaKimlikNumarası=kimlikNo and HastaEmailAdresi=@a2",baglanti);
        //    label3.Text = @a3;
        //    //mesajım1.From = new MailAddress("csmk_csmk@outlook.com");
        //    //mesajım1.To.Add("@a2");
        //    //mesajım1.Subject = "Şifreyi paneldeki boşluğa giriniz";
        //    //mesajım1.Body = " ";

        //    //SmtpClient smtp = new SmtpClient();
        //    //smtp.Credentials = new System.Net.NetworkCredential("csmk_csmk@outlook.com", "CSharpmail");
        //    //smtp.Host = "smtp.live.com"; //  smtp.gmail.com -> gmail için
        //    //smtp.EnableSsl = true;
        //    //smtp.Port = 587;

        //    //smtp.Send(mesajım1);


        //    baglanti.Close();

        //}
        //private void gönder_Click(object sender, EventArgs e)
        //{
        //    kimlikNo = TxtKimlikNumarası.Text;
        //    baglanti.Open();

        //    SqlCommand komut = new SqlCommand("Select * from HastaBilgileri where HastaKimlikNumarası=@a1 and HastaEmailAdresi=@a2",baglanti);
        //    komut.Parameters.AddWithValue("@a1", TxtKimlikNumarası.Text);
        //    SqlDataReader dr1 = komut.ExecuteReader();
        //    if (dr1.Read())
        //    {
        //        baglanti.Close();
        //        Mail();
        //    }
        //    else
        //    {

        //    }



        //    baglanti.Close();
        }
    }
//}
