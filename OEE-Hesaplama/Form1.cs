using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OEE_Hesaplama {
    public partial class Form1 : Form {

        // 'icon image: Flaticon.com'. This cover has been designed using images from Flaticon.com

        public Form1() {
            InitializeComponent();
        }

        public void Hesapla(){
            try
            {
                // Kullanıcıdan alınan değerleri TextBox'lardan okuyun
                double hatDurusu = Convert.ToDouble(textBoxHatDurusu.Text);
                double reworkAdeti = Convert.ToDouble(textBoxRework.Text);
                double cycleTimeSaniye = Convert.ToDouble(textBoxCycle.Text);
                double cycleTime = cycleTimeSaniye / 60.0;
                double uretimAdedi = Convert.ToDouble(textBoxUretim.Text);
                double planlananZaman = Convert.ToDouble(textBoxPlanlananZaman.Text);

                // Kullanılabilirlik
                double kullanilabilirlik = (planlananZaman - hatDurusu) / planlananZaman;
                // Performans
                double performans = (uretimAdedi * cycleTime) / uretimAdedi;
                // Kalite
                double kalite = ((uretimAdedi - reworkAdeti) * 1.0) / uretimAdedi;
                // OEE
                double oee = kullanilabilirlik * performans * kalite;

                // Sonuçları Label'lara yazdır
                labelKullan.Text = "%" + (kullanilabilirlik * 100).ToString("F2");
                labelKullan.ForeColor = Color.Blue;
                labelPerf.Text = " %" + (performans * 100).ToString("F2");
                labelPerf.ForeColor = Color.Blue;
                labelKalite.Text = "%" + (kalite * 100).ToString("F2");
                labelKalite.ForeColor = Color.Blue;
                labelOEE.Text = "%" + (oee * 100).ToString("F2");
                labelOEE.ForeColor = Color.Green;
            }
            catch (FormatException)
            {
                MessageBox.Show("Geçersiz giriş.\nLütfen sayısal değerleri doğru bir şekilde girin.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            }
        }

        private void textBoxHatDurusu_TextChanged(object sender, EventArgs e) {
            if(!string.IsNullOrEmpty(textBoxHatDurusu.Text) && !string.IsNullOrEmpty(textBoxRework.Text) && 
                !string.IsNullOrEmpty(textBoxCycle.Text) && !string.IsNullOrEmpty(textBoxUretim.Text) &&
                !string.IsNullOrEmpty(textBoxPlanlananZaman.Text)) {
                Hesapla();
            }
        }

        private void textBoxRework_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(textBoxHatDurusu.Text) && !string.IsNullOrEmpty(textBoxRework.Text) &&
                !string.IsNullOrEmpty(textBoxCycle.Text) && !string.IsNullOrEmpty(textBoxUretim.Text) &&
                !string.IsNullOrEmpty(textBoxPlanlananZaman.Text)) {
                Hesapla();
            }
        }

        private void textBoxCycle_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(textBoxHatDurusu.Text) && !string.IsNullOrEmpty(textBoxRework.Text) &&
                !string.IsNullOrEmpty(textBoxCycle.Text) && !string.IsNullOrEmpty(textBoxUretim.Text) &&
                !string.IsNullOrEmpty(textBoxPlanlananZaman.Text)) {
                Hesapla();
            }
        }

        private void textBoxUretim_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(textBoxHatDurusu.Text) && !string.IsNullOrEmpty(textBoxRework.Text) &&
                !string.IsNullOrEmpty(textBoxCycle.Text) && !string.IsNullOrEmpty(textBoxUretim.Text) &&
                !string.IsNullOrEmpty(textBoxPlanlananZaman.Text)) {
                Hesapla();
            }
        }

        private void textBoxPlanlananZaman_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(textBoxHatDurusu.Text) && !string.IsNullOrEmpty(textBoxRework.Text) &&
                !string.IsNullOrEmpty(textBoxCycle.Text) && !string.IsNullOrEmpty(textBoxUretim.Text) &&
                !string.IsNullOrEmpty(textBoxPlanlananZaman.Text)) {
                Hesapla();
            }
        }
    }
}
