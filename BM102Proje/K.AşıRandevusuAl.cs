using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM102Proje
{
    public partial class AsiRandevusu : Form
    {
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

        private void OnaylaButon_Click(object sender, EventArgs e)
        {
            //*
            if (AsiHastane.Text!= "" && AsiSehir.SelectedIndex >= 0 && AsiSaat.SelectedIndex >= 0)
            {
                MessageBox.Show("aferin");
            }
            else
            {
                MessageBox.Show("Girdilerde eksik var!");
            }
        }

        private void IptalButon_Click(object sender, EventArgs e)
        {
            //*
        }
    }
}
