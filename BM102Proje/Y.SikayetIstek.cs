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
    public partial class Sikayet : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\veritabani_access.mdb");
        public Sikayet()
        {
            InitializeComponent();
        }

        private void Sikayet_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbDataAdapter komut = new OleDbDataAdapter("Select * from Sikayetler", baglantı);
            DataTable DT = new DataTable();
            komut.Fill(DT);                     //veritabanından verileri çekiyoruz.
            sikayetlerview.DataSource = DT;
            baglantı.Close();

            sikayetlerview.Columns[0].Width = 150;
            sikayetlerview.Columns[1].Width = 572;
                                                                           //Tablomuzun görünümünde küçük düzenlemeler yapıyoruz.
            sikayetlerview.Columns[0].HeaderText = "Konu";
            sikayetlerview.Columns[1].HeaderText = "Şikayet/İstek";

            sikayetlerview.EnableHeadersVisualStyles = false;
            sikayetlerview.ColumnHeadersDefaultCellStyle.BackColor = Color.Thistle;

        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            YoneticiMenu YM = new YoneticiMenu();
            YM.Show();                              //Geri dön tuşu ile ana menüye dönüyoruz
            this.Close();
        }

        private void sikayetlerview_SelectionChanged(object sender, EventArgs e)
        {
            sikayetlerview.ClearSelection();
        }
    }
}
