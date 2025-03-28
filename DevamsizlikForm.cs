using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OBS
{
    public partial class DevamsizlikForm : Form
    {
        private Dictionary<string, string[,]> donemDersler;

        public DevamsizlikForm()
        {
            InitializeComponent();
            DonemleriYukle();
            DevamsizlikBilgileriniYukle();
            cmbDonem.SelectedIndex = 0;
        }

        private void DonemleriYukle()
        {
            cmbDonem.Items.Add("2024-2025 Bahar");
            cmbDonem.Items.Add("2024-2025 Güz");
            cmbDonem.Items.Add("2023-2024 Bahar");
            cmbDonem.Items.Add("2023-2024 Güz");
            cmbDonem.Items.Add("2023-2024 Muaf");
        }

        private void DevamsizlikBilgileriniYukle()
        {
            donemDersler = new Dictionary<string, string[,]>();

            // 2024-2025 Bahar dönemi dersleri
            donemDersler["2024-2025 Bahar"] = new string[,] {
                {"3", "BMT110", "BİLGİSAYAR PROGRAMLAMA", "3+1", "2", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "2"},
                {"1", "BMT206", "SAYISAL ELEKTRONİK DEVRELER", "3+0", "3", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "1"},
                {"1", "BMT210", "VERİ YAPILARI", "2+2", "2", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "3"},
                {"1", "BMT212", "AYRIK MATEMATİK", "3+0", "2", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "0"},
                {"1", "BMT216", "WEB ARAYÜZ GELİŞTİRME", "2+1", "2", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "1"},
                {"2", "BMT218", "VERİ BİLİMİNE GİRİŞ", "2+2", "3", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "2"},
                {"2", "EKO301", "EKONOMİ", "2+0", "2", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "1"},
                {"1", "MAT202", "SAYISAL ANALİZ", "3+0", "3", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "0"}
            };

            // 2024-2025 Güz dönemi dersleri
            donemDersler["2024-2025 Güz"] = new string[,] {
                {"2", "BMT201", "ELEKTRİK VE ELEKTRONİK DEVRELER", "2+2", "3", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "2"},
                {"2", "BMT205", "SAYISAL TASARIM", "3+2", "3", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "1"},
                {"3", "BMT209", "NESNE YÖNELİMLİ PROGRAMLAMA", "2+2", "4", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "3"},
                {"2", "IST201", "OLASILIK VE İSTATİSTİK", "3+0", "3", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "0"},
                {"2", "MAT201", "DİFERANSİYEL DENKLEMLER", "4+0", "4", "2", "BİLGİSAYAR MÜHENDİSLİĞİ", "1"}
            };

            // 2023-2024 Bahar dönemi dersleri
            donemDersler["2023-2024 Bahar"] = new string[,] {
                {"1", "BMT-106", "ELEKTRİK DEVRELERİ", "2+0", "2", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "2"},
                {"2", "BMT-108", "BİLGİSAYAR MÜHENDİSLİĞİNE GİRİŞ", "2+0", "2", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "1"},
                {"1", "FİZ-102", "FİZİK 2", "4+0", "4", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "3"},
                {"2", "KİM-101", "KİMYA", "4+0", "4", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "2"},
                {"2", "KİM-151", "KİMYA LABORATUVARI", "0+2", "1", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "0"},
                {"1", "MAT-102", "MATEMATİK 2", "4+0", "4", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "1"},
                {"2", "TAR-102", "ATATÜRK İLKELERİ VE İNKILAP TARİHİ-II", "2+0", "2", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "0"},
                {"2", "TUR-102", "TÜRK DİLİ 2", "2+0", "2", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "1"}
            };

            // 2023-2024 Güz dönemi dersleri
            donemDersler["2023-2024 Güz"] = new string[,] {
                {"1", "BMT-103", "ALGORİTMA VE PROGRAMLAMAYA GİRİŞ", "3+0", "3", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "2"},
                {"1", "FİZ-101", "FİZİK 1", "4+0", "4", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "3"},
                {"1", "FİZ-156", "FİZİK LABORATUVARI", "0+2", "1", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "1"},
                {"1", "MAT-101", "MATEMATİK 1", "4+0", "4", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "0"},
                {"1", "MAT-103", "LİNEER CEBİR", "3+0", "3", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "2"},
                {"1", "TAR-101", "ATATÜRK İLKELERİ VE İNKILAP TARİHİ-I", "2+0", "2", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "1"},
                {"1", "TUR-101", "TÜRK DİLİ-I", "2+0", "2", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "0"}
            };

            // 2023-2024 Muaf dönemi dersleri
            donemDersler["2023-2024 Muaf"] = new string[,] {
                {"1", "ENG-101", "İNGİLİZCE 1 {İntibak}", "3+0", "3", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "0"},
                {"1", "ENG-102", "İNGİLİZCE 2 {İntibak}", "3+0", "3", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "0"},
                {"1", "ENG-201", "İNGİLİZCE 3 {İntibak}", "3+0", "3", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "0"},
                {"1", "ENG-202", "İNGİLİZCE 4 {İntibak}", "3+0", "3", "1", "BİLGİSAYAR MÜHENDİSLİĞİ", "0"}
            };
        }

        private void cmbDonem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDonem = cmbDonem.SelectedItem.ToString();
            DevamsizlikListesiniGuncelle(secilenDonem);
        }

        private void DevamsizlikListesiniGuncelle(string donem)
        {
            listView1.Items.Clear();
            if (donemDersler.ContainsKey(donem))
            {
                string[,] dersler = donemDersler[donem];
                for (int i = 0; i < dersler.GetLength(0); i++)
                {
                    ListViewItem item = new ListViewItem(dersler[i, 0]);
                    for (int j = 1; j < dersler.GetLength(1); j++)
                    {
                        item.SubItems.Add(dersler[i, j]);
                    }
                    listView1.Items.Add(item);
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 