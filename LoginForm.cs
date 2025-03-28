using System;
using System.Windows.Forms;

namespace OBS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ogrenciNo = txtOgrenciNo.Text;
            string sifre = txtSifre.Text;

            if (ogrenciNo == "23181616001" && sifre == "semih123")
            {
                AnaForm anaForm = new AnaForm();
                this.Hide();
                anaForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı öğrenci numarası veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 