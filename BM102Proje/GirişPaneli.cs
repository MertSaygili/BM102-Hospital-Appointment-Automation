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
    public partial class GirişPaneli : Form
    {
        public GirişPaneli()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GradiantPanel grp = new GradiantPanel();
            
            
        }

        private void KullanıcıGirişi_Click(object sender, EventArgs e)
        {
            KullanıcıGirişiMenü KGM = new KullanıcıGirişiMenü();
            KGM.Show();
            
            this.Hide();
            
        }

        private void YöneticiGirişi_Click(object sender, EventArgs e)
        {
            YöneticiGirişiMenü YGM = new YöneticiGirişiMenü();
            YGM.Show();
            this.Hide();
        }
    }
}
