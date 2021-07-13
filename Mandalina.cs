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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G201210057_MUHAMMET_BARIŞ_YILMAZ
{
    class Mandalina : Olustur, IMeyveSik
    {
        private double _id;
        private double _agirlik;
        private double _verim;

        public override void AgirlikOlustur()
        {
            Random rand = new Random();
            _agirlik = rand.Next(70, 120);
        }
        public override void VerimOlustur()
        {
            Random rand = new Random();
            _verim = rand.Next(30, 70);
        }
        public double SiviPureUret(double agirlik, double verim)
        {
            return (agirlik * verim) / 100;
        }

        public double[] MeyveUret()
        {
            double[] veri = new double[6];
            _id = 5;
            AgirlikOlustur(); veri[0] = _agirlik;
            VerimOlustur(); veri[1] = _verim;
            veri[2] = SiviPureUret(_agirlik, _verim);
            veri[3] = VitaminHesaplaA(veri[2], _id);
            veri[4] = VitaminHesaplaC(veri[2], _id);
            veri[5] = _id;
            return veri;
        }
    }
}
