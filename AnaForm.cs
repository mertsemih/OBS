using System;
using System.Windows.Forms;

namespace OBS
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            OgrenciBilgileriniYukle();
        }

        private void OgrenciBilgileriniYukle()
        {
            lblOgrenciAd.Text = "Mert Semih SARIYERLİ";
            lblOgrenciNo.Text = "23181616001";
            lblBolum.Text = "Bilgisayar Mühendisliği";
        }

        private void btnDevamsizlik_Click(object sender, EventArgs e)
        {
            DevamsizlikForm devamsizlikForm = new DevamsizlikForm();
            devamsizlikForm.ShowDialog();
        }

        private void btnNotlar_Click(object sender, EventArgs e)
        {
            NotlarForm notlarForm = new NotlarForm();
            notlarForm.ShowDialog();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            DuyurularForm duyurularForm = new DuyurularForm();
            duyurularForm.ShowDialog();
        }

        private void btnDanisman_Click(object sender, EventArgs e)
        {
            DanismanForm danismanForm = new DanismanForm();
            danismanForm.ShowDialog();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            HesapForm hesapForm = new HesapForm();
            hesapForm.ShowDialog();
        }

        private void btnTranskript_Click(object sender, EventArgs e)
        {
            TranskriptForm transkriptForm = new TranskriptForm();
            transkriptForm.ShowDialog();
        }

        private void btnSinavlar_Click(object sender, EventArgs e)
        {
            SinavlarForm sinavlarForm = new SinavlarForm();
            sinavlarForm.ShowDialog();
        }

        private void btnAkademikTakvim_Click(object sender, EventArgs e)
        {
            AkademikTakvimForm akademikTakvimForm = new AkademikTakvimForm();
            akademikTakvimForm.ShowDialog();
        }
    }
} 