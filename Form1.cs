/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				  BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1. PROJE
**				ÖĞRENCİ ADI............: MUHAMMET BARIŞ YILMAZ  
**				ÖĞRENCİ NUMARASI.......: G201210057
**              DERSİN ALINDIĞI GRUP...: 2. ÖĞRETİM C GRUBU / CAN YÜZKOLLAR
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G201210057_MUHAMMET_BARIŞ_YILMAZ
{
    public partial class Form1 : Form
    {
        public double[] SiraKontrol(int sira)
        {
            double[] degerler = new double[6];
            if(sira==0)
            {
                Armut meyve = new Armut();
                degerler = meyve.MeyveUret();
            }
            else if(sira==1)
            {
                Cilek meyve = new Cilek();
                degerler = meyve.MeyveUret();
            }
            else if(sira==2)
            {
                Elma meyve = new Elma();
                degerler = meyve.MeyveUret();
            }
            else if(sira==3)
            {
                Greyfurt meyve = new Greyfurt();
                degerler = meyve.MeyveUret();
            }
            else if(sira==4)
            {
                Mandalina meyve = new Mandalina();
                degerler = meyve.MeyveUret();
            }
            else
            {
                Portakal meyve = new Portakal();
                degerler = meyve.MeyveUret();
            }
            return degerler;
        }
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        int meyveSira,zaman_kontrol=0;
        double geciciA, geciciC, geciciSiviPure;
        private void BASLA_button1_Click(object sender, EventArgs e)
        {
            if (sayac_label3.Text=="0")
            {
                a_textBox1.Text = "0";
                c_textBox2.Text = "0";
                pure_textBox4.Text = "0";
                sivi_textBox3.Text = "0";
                meyveSira = rand.Next(0, 6);
                pictureBox1.Image = ımageList1.Images[meyveSira];
                double[] degerler = SiraKontrol(meyveSira);
                if (degerler[5] == 1)
                {
                    BILGILER_label1.Text = "Elma\n";
                }
                else if (degerler[5] == 2)
                {
                    BILGILER_label1.Text = "Armut\n";
                }
                else if (degerler[5] == 3)
                {
                    BILGILER_label1.Text = "Çilek\n";
                }
                else if (degerler[5] == 4)
                {
                    BILGILER_label1.Text = "Portakal\n";
                }
                else if (degerler[5] == 5)
                {
                    BILGILER_label1.Text = "Mandalina\n";
                }
                else if (degerler[5] == 6)
                {
                    BILGILER_label1.Text = "Greyfurt\n";
                }
                BILGILER_label1.Text = BILGILER_label1.Text + "Ağirlik = " + degerler[0] + "\nVerim = " + degerler[1]+ "\nVitamin A = " + degerler[3] + "\nVitamin C = " + degerler[4] + "\nSivi/Püre ağirlik = " + degerler[2];
                geciciSiviPure = degerler[2];
                geciciA = degerler[3];
                geciciC = degerler[4];
                sayac_label3.Text = "60";
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman_kontrol = 1;
            sayac_label3.Text = Convert.ToString(Convert.ToInt32(sayac_label3.Text) + (Convert.ToInt32(sayac_label3.Text)-Convert.ToInt32(sayac_label3.Text) - 1));
            if(sayac_label3.Text == "0")
            {
                zaman_kontrol = 0;
                timer1.Stop();
            }
        }

        private void kati_button1_Click(object sender, EventArgs e)
        {
            if (zaman_kontrol == 1&&meyveSira<3)
            {
                a_textBox1.Text = Convert.ToString(Convert.ToDouble(a_textBox1.Text) + geciciA);
                c_textBox2.Text = Convert.ToString(Convert.ToDouble(c_textBox2.Text) + geciciC);
                pure_textBox4.Text = Convert.ToString(Convert.ToDouble(pure_textBox4.Text) + geciciSiviPure);

                meyveSira = rand.Next(0, 6);
                pictureBox1.Image = ımageList1.Images[meyveSira];
                double[] degerler = SiraKontrol(meyveSira);
                if (degerler[5] == 1)
                {
                    BILGILER_label1.Text = "Elma\n";
                }
                else if (degerler[5] == 2)
                {
                    BILGILER_label1.Text = "Armut\n";
                }
                else if (degerler[5] == 3)
                {
                    BILGILER_label1.Text = "Çilek\n";
                }
                else if (degerler[5] == 4)
                {
                    BILGILER_label1.Text = "Portakal\n";
                }
                else if (degerler[5] == 5)
                {
                    BILGILER_label1.Text = "Mandalina\n";
                }
                else if (degerler[5] == 6)
                {
                    BILGILER_label1.Text = "Greyfurt\n";
                }
                BILGILER_label1.Text = BILGILER_label1.Text + "Ağirlik = " + degerler[0] + "\nVerim = " + degerler[1]  + "\nVitamin A = " + degerler[3] + "\nVitamin C = " + degerler[4] + "\nSivi/Püre ağirlik = " + degerler[2];
                geciciSiviPure = degerler[2];
                geciciA = degerler[3];
                geciciC = degerler[4];
            }
        }

        private void sivi_button2_Click(object sender, EventArgs e)
        {
            if(zaman_kontrol==1&&meyveSira>=3)
            {
                a_textBox1.Text = Convert.ToString(Convert.ToDouble(a_textBox1.Text) + geciciA);
                c_textBox2.Text = Convert.ToString(Convert.ToDouble(c_textBox2.Text) + geciciC);
                sivi_textBox3.Text = Convert.ToString(Convert.ToDouble(sivi_textBox3.Text) + geciciSiviPure);

                meyveSira = rand.Next(0, 6);
                pictureBox1.Image = ımageList1.Images[meyveSira];
                double[] degerler = SiraKontrol(meyveSira);
                if (degerler[5] == 1)
                {
                    BILGILER_label1.Text = "Elma\n";
                }
                else if (degerler[5] == 2)
                {
                    BILGILER_label1.Text = "Armut\n";
                }
                else if (degerler[5] == 3)
                {
                    BILGILER_label1.Text = "Çilek\n";
                }
                else if (degerler[5] == 4)
                {
                    BILGILER_label1.Text = "Portakal\n";
                }
                else if (degerler[5] == 5)
                {
                    BILGILER_label1.Text = "Mandalina\n";
                }
                else if (degerler[5] == 6)
                {
                    BILGILER_label1.Text = "Greyfurt\n";
                }
                BILGILER_label1.Text = BILGILER_label1.Text + "Ağirlik = " + degerler[0] + "\nVerim = " + degerler[1] + "\nVitamin A = " + degerler[3] + "\nVitamin C = " + degerler[4] + "\nSivi/Püre ağirlik = " + degerler[2];
                geciciSiviPure = degerler[2];
                geciciA = degerler[3];
                geciciC = degerler[4];
            }
        }
    }
}