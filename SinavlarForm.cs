using System;
using System.Windows.Forms;

namespace OBS
{
    public partial class SinavlarForm : Form
    {
        public SinavlarForm()
        {
            InitializeComponent();
            SinavlariYukle();
        }

        private void SinavlariYukle()
        {
            // ListView sütunlarını oluştur
            listView1.Columns.Add("Gün", 100);
            listView1.Columns.Add("Tarih", 100);
            listView1.Columns.Add("Saat", 100);
            listView1.Columns.Add("Ders Kodu", 100);
            listView1.Columns.Add("Ders Adı", 250);

            // Sınav verilerini ekle
            ListViewItem item1 = new ListViewItem("Pazartesi");
            item1.SubItems.Add("07.04.2025");
            item1.SubItems.Add("13:30");
            item1.SubItems.Add("MAT-202");
            item1.SubItems.Add("Sayısal Analiz");
            listView1.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Salı");
            item2.SubItems.Add("08.04.2025");
            item2.SubItems.Add("14:00");
            item2.SubItems.Add("BMT-212");
            item2.SubItems.Add("Ayrık Matematik");
            listView1.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Salı");
            item3.SubItems.Add("08.04.2025");
            item3.SubItems.Add("17:30");
            item3.SubItems.Add("BMT-216");
            item3.SubItems.Add("Web Arayüz");
            listView1.Items.Add(item3);

            ListViewItem item4 = new ListViewItem("Perşembe");
            item4.SubItems.Add("10.04.2025");
            item4.SubItems.Add("16:30");
            item4.SubItems.Add("EKO-301");
            item4.SubItems.Add("Ekonomi");
            listView1.Items.Add(item4);

            ListViewItem item5 = new ListViewItem("Cuma");
            item5.SubItems.Add("11.04.2025");
            item5.SubItems.Add("14:00");
            item5.SubItems.Add("BMT-218");
            item5.SubItems.Add("Veri Bilimi");
            listView1.Items.Add(item5);

            ListViewItem item6 = new ListViewItem("Cuma");
            item6.SubItems.Add("11.04.2025");
            item6.SubItems.Add("17:00");
            item6.SubItems.Add("BMT-206");
            item6.SubItems.Add("Sayısal Elektronik");
            listView1.Items.Add(item6);

            ListViewItem item7 = new ListViewItem("Cumartesi");
            item7.SubItems.Add("12.04.2025");
            item7.SubItems.Add("10:30");
            item7.SubItems.Add("BMT-110");
            item7.SubItems.Add("C#");
            listView1.Items.Add(item7);

            ListViewItem item8 = new ListViewItem("Cumartesi");
            item8.SubItems.Add("12.04.2025");
            item8.SubItems.Add("13:30");
            item8.SubItems.Add("BMT-210");
            item8.SubItems.Add("Veri Yapıları");
            listView1.Items.Add(item8);

            // ListView özelliklerini ayarla
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAkademikTakvim_Click(object sender, EventArgs e)
        {
            AkademikTakvimForm akademikTakvimForm = new AkademikTakvimForm();
            akademikTakvimForm.ShowDialog();
        }
    }
} 