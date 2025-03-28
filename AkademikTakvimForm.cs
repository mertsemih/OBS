using System;
using System.Windows.Forms;

namespace OBS
{
    public partial class AkademikTakvimForm : Form
    {
        public AkademikTakvimForm()
        {
            InitializeComponent();
            AkademikTakvimYukle();
        }

        private void AkademikTakvimYukle()
        {
            // ListView sütunlarını oluştur
            listView1.Columns.Add("Tarih", 200);
            listView1.Columns.Add("Açıklama", 600);

            // Akademik takvim verilerini ekle
            ListViewItem[] items = new ListViewItem[]
            {
                new ListViewItem(new string[] { "23 Eylül 2024", "GÜZ YARIYILI DERSLERİNİN BAŞLAMASI" }),
                new ListViewItem(new string[] { "23-25 Eylül 2024", "Yeni kayıt olan öğrenciler için uyum etkinlikleri" }),
                new ListViewItem(new string[] { "29 Ekim 2024", "Cumhuriyet Bayramı" }),
                new ListViewItem(new string[] { "10 Kasım 2024", "Atatürk'ü Anma Günü" }),
                new ListViewItem(new string[] { "1 Ocak 2025", "Yılbaşı tatili" }),
                new ListViewItem(new string[] { "19 Ocak 2025", "GÜZ YARIYILI DERSLERİNİN SON GÜNÜ" }),
                new ListViewItem(new string[] { "20-31 Ocak 2025", "Güz yarıyılı dönem sonu sınavları" }),
                new ListViewItem(new string[] { "12 Şubat 2025", "BAHAR YARIYILI DERSLERİNİN BAŞLAMASI" }),
                new ListViewItem(new string[] { "30 Mart-1 Nisan 2025", "Ramazan Bayramı" }),
                new ListViewItem(new string[] { "23 Nisan 2025", "Ulusal Egemenlik ve Çocuk Bayramı" }),
                new ListViewItem(new string[] { "1 Mayıs 2025", "Emek ve Dayanışma Günü" }),
                new ListViewItem(new string[] { "19 Mayıs 2025", "Atatürk'ü Anma, Gençlik ve Spor Bayramı" }),
                new ListViewItem(new string[] { "23 Mayıs 2025", "BAHAR YARIYILI DERSLERİNİN SON GÜNÜ" }),
                new ListViewItem(new string[] { "24 Mayıs-4 Haziran 2025", "Dönem sonu sınavları" }),
                new ListViewItem(new string[] { "6-9 Haziran 2025", "Kurban Bayramı" }),
                new ListViewItem(new string[] { "15 Temmuz 2025", "Demokrasi ve Millî Birlik Günü" }),
                new ListViewItem(new string[] { "30 Ağustos 2025", "Zafer Bayramı" })
            };

            listView1.Items.AddRange(items);

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