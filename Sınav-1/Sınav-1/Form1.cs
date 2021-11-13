using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> kahveler = new List<string>() { "Misto", "Americano", "Bianco","Cappucino" , "Macchiato", "Con Panna", "Mocha"};
        List<decimal> kahveFiyat = new List<decimal>() {4.5m,5.75m,6m,7.5m,6.75m,8m,7.75m };

        List<string> sogukIcecek = new List<string>() {"Kola","Fanta","Sprite" };
        decimal sogukIcecekFiyat = 5;

        List<string> sicakIcecek = new List<string>() { "Çay", "Hot Chocolate", "Chai Tea Latte" };
        List<decimal> sicakIcecekFiyat = new List<decimal>() {3m,4.5m,6.5m};

        decimal ToplamFiyat=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void FillForm()
        {
            foreach (var item in kahveler)
            {
                cmbKahve.Items.Add(item);
            }
            foreach (var item in sogukIcecek)
            {
                cmbSoguk.Items.Add(item);
            }
            foreach (var item in sicakIcecek)
            {
                cmbSicak.Items.Add(item);
            }

            rbVenti.Checked = true;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal partialToplam = 0;
            decimal sogukToplam = 0;
            decimal sicakToplam = 0;

            string boy = "";
            string süt = "";
            string shot1x = "";
            string shot2x = "";

            try
            {
                if (cmbKahve.SelectedIndex > -1)
                {
                    switch (cmbKahve.SelectedIndex)
                    {
                        case 0:
                            partialToplam = nudKahve.Value * kahveFiyat[0];
                            break;
                        case 1:
                            partialToplam = nudKahve.Value * kahveFiyat[1];
                            break;
                        case 2:
                            partialToplam = nudKahve.Value * kahveFiyat[2];
                            break;
                        case 3:
                            partialToplam = nudKahve.Value * kahveFiyat[3];
                            break;
                        case 4:
                            partialToplam = nudKahve.Value * kahveFiyat[4];
                            break;
                        case 5:
                            partialToplam = nudKahve.Value * kahveFiyat[5];
                            break;
                        case 6:
                            partialToplam = nudKahve.Value * kahveFiyat[6];
                            break;
                        default:
                            partialToplam = 0;
                            break;
                    }
                    if (rbVenti.Checked)
                    {
                        partialToplam = partialToplam * 1.75m;
                        boy = "Venti";
                    }
                    else if (rbGrande.Checked)
                    {
                        partialToplam = partialToplam * 1.25m;
                        boy = "Grande";
                    }
                    else if (rbTall.Checked)
                    {
                        partialToplam = partialToplam * 1m;
                        boy = "Tall";
                    }
                    else
                    {
                        if (cmbKahve.SelectedIndex > -1)
                        {
                            MessageBox.Show("Bir kahve boyutu seçmelisiniz");
                        }
                    }
                    if (cb1x.Checked == true)
                    {
                        partialToplam += 0.75m;
                        shot1x = "1x shot";

                    }
                    if (cb2x.Checked == true)
                    {
                        partialToplam += 1.5m;
                        shot2x = "2x shot";
                    }
                    if (rbSoya.Checked)
                    {
                        partialToplam += 0.5m;
                        süt = "Soyalı";
                    }
                    if (rbYagsiz.Checked)
                    {
                        partialToplam += 0.5m;
                        süt = "Yağsız";
                    }

                    ToplamFiyat += partialToplam;
                }

                if (cmbSoguk.SelectedIndex > -1)
                {
                    sogukToplam = nudSoguk.Value * sogukIcecekFiyat;
                    ToplamFiyat += sogukToplam;
                }
                if (cmbSicak.SelectedIndex > -1)
                {
                    switch (cmbSicak.SelectedIndex)
                    {
                        case 0:
                            sicakToplam = nudSicak.Value * sicakIcecekFiyat[0];
                            break;
                        case 1:
                            sicakToplam = nudSicak.Value * sicakIcecekFiyat[1];
                            break;
                        case 2:
                            sicakToplam = nudSicak.Value * sicakIcecekFiyat[2];
                            break;
                    }
                    ToplamFiyat += sicakToplam;
                }

                string siparisKahve = "";
                string sogukIcecek = "";
                string sicakIcecek = "";
                if (cmbKahve.SelectedIndex > -1)
                {
                    siparisKahve = boy + "," + cmbKahve.SelectedItem.ToString() + "," + süt + "," + shot1x + "," + shot2x + " : " + partialToplam + "TL";
                    lstSiparis.Items.Add(siparisKahve);
                }
                if (cmbSoguk.SelectedIndex > -1)
                {
                    sogukIcecek = cmbSoguk.SelectedItem.ToString() + " : " + sogukToplam + "TL";
                    lstSiparis.Items.Add(sogukIcecek);
                }
                if (cmbSicak.SelectedIndex > -1)
                {
                    sicakIcecek = cmbSicak.SelectedItem.ToString() + " : " + sicakToplam + "TL";
                    lstSiparis.Items.Add(sicakIcecek);
                }

                lblTutar.Text = "Toplam Sipariş Tutarı: " + ToplamFiyat.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }   
            
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            string mesaj = lstSiparis.Items.Count.ToString() + " adet siparişiniz " + ToplamFiyat + " TL Tutarındadır.";
            MessageBox.Show(mesaj);
        }

        private void KahveSiparis()
        {

        }
    }
}
