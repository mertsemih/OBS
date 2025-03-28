using System;
using System.Windows.Forms;

namespace OBS
{
    public partial class HesapForm : Form
    {
        public HesapForm()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            if (txtEskiSifre.Text == "semih123")
            {
                if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreniz başarıyla değiştirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Yeni şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eski şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 