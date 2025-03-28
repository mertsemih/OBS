using System;
using System.Drawing;
using System.Windows.Forms;

namespace OBS
{
    public partial class TranskriptForm : Form
    {
        public TranskriptForm()
        {
            InitializeComponent();
            TranskriptYukle();
        }

        private void TranskriptYukle()
        {
            // Öğrenci bilgilerini doldur
            lblAdSoyad.Text = "MERT SEMİH SARIYERLI";
            lblOgrenciNo.Text = "23181616001";
            lblFakulte.Text = "Teknoloji Fakültesi";
            lblProgram.Text = "Bilgisayar Mühendisliği";
            lblOgrenimDurumu.Text = "Aktif (E-Devletten Kayıt Yapan)";
            lblKayitTarihi.Text = "29.08.2023";
            lblOrtTipi.Text = "AKTS";

            // ListView'leri yapılandır ve doldur
            ConfigureListView(lvGuz2023);
            ConfigureListView(lvBahar2024);
            ConfigureListView(lvGuz2024);

            // 2023-2024 Güz Dönemi
            DoldurGuz2023();

            // 2023-2024 Bahar Dönemi
            DoldurBahar2024();

            // 2024-2025 Güz Dönemi
            DoldurGuz2024();

            // Dönem ortalamalarını güncelle
            UpdateDonemOrtalamalari();
        }

        private void ConfigureListView(ListView listView)
        {
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;

            listView.Columns.Add("Ders Kodu", 80);
            listView.Columns.Add("Ders Adı", 250);
            listView.Columns.Add("Krd", 40);
            listView.Columns.Add("AKTS", 50);
            listView.Columns.Add("T-AKTS", 50);
            listView.Columns.Add("Harf Notu", 70);
        }

        private void DoldurGuz2023()
        {
            string[,] dersler = {
                {"ENG-101", "İNGİLİZCE 1 {İntibak}", "3", "2", "8", "AA"},
                {"ENG-102", "İNGİLİZCE 2 {İntibak}", "3", "2", "8", "AA"},
                {"ENG-201", "İNGİLİZCE 3 {İntibak}", "3", "2", "8", "AA"},
                {"ENG-202", "İNGİLİZCE 4 {İntibak}", "3", "2", "8", "AA"},
                {"ANO", "4,00", "", "28,00", "32,00", ""},
                {"AGNO", "4,00", "", "87", "265,50", ""}
            };

            for (int i = 0; i < dersler.GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(dersler[i, 0]);
                for (int j = 1; j < dersler.GetLength(1); j++)
                {
                    item.SubItems.Add(dersler[i, j]);
                }
                if (dersler[i, 0] == "ANO" || dersler[i, 0] == "AGNO")
                {
                    item.BackColor = Color.LightGray;
                }
                lvGuz2023.Items.Add(item);
            }
        }

        private void DoldurBahar2024()
        {
            string[,] dersler = {
                {"BMT-103", "ALGORİTMA VE PROGRAMLAMAYA GİRİŞ", "3", "5", "7,5", "AA"},
                {"FİZ-101", "FİZİK 1", "4", "6", "12", "AA"},
                {"FİZ-156", "FİZİK LABORATUVARI", "1", "2", "6", "AA"},
                {"MAT-101", "MATEMATİK 1", "4", "6", "24", "AA"},
                {"MAT-103", "LİNEER CEBİR", "3", "5", "12,5", "AA"},
                {"TAR-101", "ATATÜRK İLKELERİ VE İNKILAP TARİHİ-I", "2", "2", "8", "AA"},
                {"TUR-101", "TÜRK DİLİ-I", "2", "2", "6", "AA"},
                {"ANO", "4,00", "", "28,00", "83,00", ""},
                {"AGNO", "4,00", "", "87", "265,50", ""}
            };

            for (int i = 0; i < dersler.GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(dersler[i, 0]);
                for (int j = 1; j < dersler.GetLength(1); j++)
                {
                    item.SubItems.Add(dersler[i, j]);
                }
                if (dersler[i, 0] == "ANO" || dersler[i, 0] == "AGNO")
                {
                    item.BackColor = Color.LightGray;
                }
                lvBahar2024.Items.Add(item);
            }
        }

        private void DoldurGuz2024()
        {
            string[,] dersler = {
                {"BMT-106", "ELEKTRİK DEVRELERİ", "2", "2", "6", "AA"},
                {"BMT-108", "BİLGİSAYAR MÜHENDİSLİĞİNE GİRİŞ", "2", "2", "6", "AA"},
                {"FİZ-102", "FİZİK 2", "4", "6", "12", "AA"},
                {"KİM-101", "KİMYA", "4", "6", "18", "AA"},
                {"KİM-151", "KİMYA LABORATUVARI", "1", "2", "8", "AA"},
                {"MAT-102", "MATEMATİK 2", "4", "6", "18", "AA"},
                {"TAR-102", "ATATÜRK İLKELERİ VE İNKILAP TARİHİ-II", "2", "2", "8", "AA"},
                {"TUR-102", "TÜRK DİLİ 2", "2", "2", "6", "AA"},
                {"ANO", "4,00", "", "28,00", "80,00", ""},
                {"AGNO", "4,00", "", "87", "265,50", ""}
            };

            for (int i = 0; i < dersler.GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(dersler[i, 0]);
                for (int j = 1; j < dersler.GetLength(1); j++)
                {
                    item.SubItems.Add(dersler[i, j]);
                }
                if (dersler[i, 0] == "ANO" || dersler[i, 0] == "AGNO")
                {
                    item.BackColor = Color.LightGray;
                }
                lvGuz2024.Items.Add(item);
            }
        }

        private void UpdateDonemOrtalamalari()
        {
            // Bu metod dönem ortalamalarını günceller
            // Gerçek uygulamada bu değerler veritabanından gelecektir
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 