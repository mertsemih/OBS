using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace OBS
{
    public partial class NotlarForm : Form
    {
        private Dictionary<string, List<DersNotu>> donemDersler;

        public NotlarForm()
        {
            InitializeComponent();
            DonemleriYukle();
            NotBilgileriniYukle();
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

        private class DersNotu
        {
            public string Sube { get; set; }
            public string DersKodu { get; set; }
            public string DersAdi { get; set; }
            public string Durum { get; set; }
            public string SinavNotlari { get; set; }
            public double Ortalama { get; set; }
            public string HarfNotu { get; set; }
            public string BasariDurumu { get; set; }
        }

        private void NotBilgileriniYukle()
        {
            donemDersler = new Dictionary<string, List<DersNotu>>();

            // 2024-2025 Bahar dönemi notları
            donemDersler["2024-2025 Bahar"] = new List<DersNotu>
            {
                new DersNotu { Sube = "3", DersKodu = "BMT110", DersAdi = "BİLGİSAYAR PROGRAMLAMA", Durum = "Sonuçlandırılmadı", SinavNotlari = "Vize: --  Projeler: --", Ortalama = 0, HarfNotu = "--", BasariDurumu = "--" },
                new DersNotu { Sube = "1", DersKodu = "BMT206", DersAdi = "SAYISAL ELEKTRONİK DEVRELER", Durum = "Sonuçlandırılmadı", SinavNotlari = "Vize: --", Ortalama = 0, HarfNotu = "--", BasariDurumu = "--" },
                new DersNotu { Sube = "1", DersKodu = "BMT210", DersAdi = "VERİ YAPILARI", Durum = "Sonuçlandırılmadı", SinavNotlari = "Vize: --  Ödev: --  Uygulama: --", Ortalama = 0, HarfNotu = "--", BasariDurumu = "--" },
                new DersNotu { Sube = "1", DersKodu = "BMT212", DersAdi = "AYRIK MATEMATİK", Durum = "Sonuçlandırılmadı", SinavNotlari = "Vize: --  Ödev: --  Kısa Sınv: --", Ortalama = 0, HarfNotu = "--", BasariDurumu = "--" },
                new DersNotu { Sube = "1", DersKodu = "BMT216", DersAdi = "WEB ARAYÜZ GELİŞTİRME", Durum = "Sonuçlandırılmadı", SinavNotlari = "Vize: --  Uygulama: --  Projeler: --", Ortalama = 0, HarfNotu = "--", BasariDurumu = "--" },
                new DersNotu { Sube = "2", DersKodu = "BMT218", DersAdi = "VERİ BİLİMİNE GİRİŞ", Durum = "Sonuçlandırılmadı", SinavNotlari = "Vize: --  Projeler: --", Ortalama = 0, HarfNotu = "--", BasariDurumu = "--" },
                new DersNotu { Sube = "2", DersKodu = "EKO301", DersAdi = "EKONOMİ", Durum = "Sonuçlandırılmadı", SinavNotlari = "Vize: --", Ortalama = 0, HarfNotu = "--", BasariDurumu = "--" },
                new DersNotu { Sube = "1", DersKodu = "MAT202", DersAdi = "SAYISAL ANALİZ", Durum = "Sonuçlandırılmadı", SinavNotlari = "Vize: --", Ortalama = 0, HarfNotu = "--", BasariDurumu = "--" }
            };

            // 2024-2025 Güz dönemi notları
            donemDersler["2024-2025 Güz"] = new List<DersNotu>
            {
                new DersNotu { Sube = "2", DersKodu = "BMT201", DersAdi = "ELEKTRİK VE ELEKTRONİK DEVRELER", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 75  Uygulama: 90  Final: 90", Ortalama = 87, HarfNotu = "AA", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "2", DersKodu = "BMT205", DersAdi = "SAYISAL TASARIM", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize : 85  Uygulama : 96  Final : 77    ", Ortalama = 84, HarfNotu = "AA", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "3", DersKodu = "BMT209", DersAdi = "NESNE YÖNELİMLİ PROGRAMLAMA", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize : 60   Ödev : 93   Projeler : 77   Final : 87", Ortalama = 80, HarfNotu = "AA", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "2", DersKodu = "IST201", DersAdi = "OLASILIK VE İSTATİSTİK", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize : 80   Final : 70", Ortalama = 75, HarfNotu = "AA", BasariDurumu = "Geçti" },
                    new DersNotu { Sube = "2", DersKodu = "MAT201", DersAdi = "DİFERANSİYEL DENKLEMLER", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize : 80   Final : 70", Ortalama = 75, HarfNotu = "AA", BasariDurumu = "Geçti" }
            };

            // 2023-2024 Bahar dönemi notları
            donemDersler["2023-2024 Bahar"] = new List<DersNotu>
            {
                new DersNotu { Sube = "1", DersKodu = "BMT-106", DersAdi = "ELEKTRİK DEVRELERİ", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 60  Uygulama: 65  Final: 55", Ortalama = 59, HarfNotu = "BB", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "2", DersKodu = "BMT-108", DersAdi = "BİLGİSAYAR MÜHENDİSLİĞİNE GİRİŞ", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 40  Final: 80", Ortalama = 56, HarfNotu = "CC", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "1", DersKodu = "FİZ-102", DersAdi = "FİZİK 2", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 62  Final: 71", Ortalama = 66, HarfNotu = "BB", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "2", DersKodu = "KİM-101", DersAdi = "KİMYA", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 80  Final: 54", Ortalama = 70, HarfNotu = "BB", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "2", DersKodu = "KİM-151", DersAdi = "KİMYA LABORATUVARI", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 92  Final: 70", Ortalama = 83, HarfNotu = "AA", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "1", DersKodu = "MAT-102", DersAdi = "MATEMATİK 2", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 70  Final: 70", Ortalama = 70, HarfNotu = "BB", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "2", DersKodu = "TAR-102", DersAdi = "ATATÜRK İLKELERİ VE İNKILAP TARİHİ-II", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 100  Final: 100", Ortalama = 100, HarfNotu = "AA", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "2", DersKodu = "TUR-102", DersAdi = "TÜRK DİLİ 2", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 80  Final: 70", Ortalama = 74, HarfNotu = "BB", BasariDurumu = "Geçti" }
            };

            // 2023-2024 Güz dönemi notları
            donemDersler["2023-2024 Güz"] = new List<DersNotu>
            {
                new DersNotu { Sube = "1", DersKodu = "BMT-103", DersAdi = "ALGORİTMA VE PROGRAMLAMAYA GİRİŞ", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 90  Final: 95", Ortalama = 92, HarfNotu = "AA", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "1", DersKodu = "FİZ-101", DersAdi = "FİZİK 1", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 85  Final: 88", Ortalama = 86, HarfNotu = "AA", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "1", DersKodu = "FİZ-156", DersAdi = "FİZİK LABORATUVARI", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 95  Final: 90", Ortalama = 93, HarfNotu = "AA", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "1", DersKodu = "MAT-101", DersAdi = "MATEMATİK 1", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 88  Final: 92", Ortalama = 90, HarfNotu = "AA", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "1", DersKodu = "MAT-103", DersAdi = "LİNEER CEBİR", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 87  Final: 89", Ortalama = 88, HarfNotu = "AA", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "1", DersKodu = "TAR-101", DersAdi = "ATATÜRK İLKELERİ VE İNKILAP TARİHİ-I", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 100  Final: 100", Ortalama = 100, HarfNotu = "AA", BasariDurumu = "Geçti" },
                new DersNotu { Sube = "1", DersKodu = "TUR-101", DersAdi = "TÜRK DİLİ-I", Durum = "Sonuçlandırıldı", SinavNotlari = "Vize: 90  Final: 85", Ortalama = 88, HarfNotu = "AA", BasariDurumu = "Geçti" }
            };

            // 2023-2024 Muaf dönemi notları
            donemDersler["2023-2024 Muaf"] = new List<DersNotu>
            {
                new DersNotu { Sube = "1", DersKodu = "ENG-101", DersAdi = "İNGİLİZCE 1 {İntibak}", Durum = "Muaf", SinavNotlari = "", Ortalama = 100, HarfNotu = "M", BasariDurumu = "Muaf" },
                new DersNotu { Sube = "1", DersKodu = "ENG-102", DersAdi = "İNGİLİZCE 2 {İntibak}", Durum = "Muaf", SinavNotlari = "", Ortalama = 100, HarfNotu = "M", BasariDurumu = "Muaf" },
                new DersNotu { Sube = "1", DersKodu = "ENG-201", DersAdi = "İNGİLİZCE 3 {İntibak}", Durum = "Muaf", SinavNotlari = "", Ortalama = 100, HarfNotu = "M", BasariDurumu = "Muaf" },
                new DersNotu { Sube = "1", DersKodu = "ENG-202", DersAdi = "İNGİLİZCE 4 {İntibak}", Durum = "Muaf", SinavNotlari = "", Ortalama = 100, HarfNotu = "M", BasariDurumu = "Muaf" }
            };
        }

        private void cmbDonem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDonem = cmbDonem.SelectedItem.ToString();
            NotListesiniGuncelle(secilenDonem);
        }

        private void NotListesiniGuncelle(string donem)
        {
            listView1.Items.Clear();
            if (donemDersler.ContainsKey(donem))
            {
                foreach (var ders in donemDersler[donem])
                {
                    ListViewItem item = new ListViewItem(ders.Sube);
                    item.SubItems.Add(ders.DersKodu);
                    item.SubItems.Add(ders.DersAdi);
                    item.SubItems.Add(ders.Durum);
                    item.SubItems.Add(ders.SinavNotlari);
                    item.SubItems.Add(ders.Ortalama.ToString("F2"));
                    item.SubItems.Add(ders.HarfNotu);
                    item.SubItems.Add(ders.BasariDurumu);
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