using System;
using System.Windows.Forms;

namespace OBS
{
    public partial class DuyurularForm : Form
    {
        public DuyurularForm()
        {
            InitializeComponent();
            DuyurulariYukle();
        }

        private void DuyurulariYukle()
        {
            // ListView sütunlarını oluştur
            listView1.Columns.Add("Tarih", 100);
            listView1.Columns.Add("Duyuru", 600);

            // Örnek duyuruyu ekle
            ListViewItem item = new ListViewItem(DateTime.Now.ToShortDateString());
            item.SubItems.Add("Sınav takvimi değişmiştir. Değişen takvimi sınavlar kısmından öğrenebilirsiniz.");
            listView1.Items.Add(item);

            // ListView özelliklerini ayarla
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 