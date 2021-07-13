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
    abstract class Olustur : IVitamin
    {
        public abstract void AgirlikOlustur();
        public abstract void VerimOlustur();

        public double VitaminHesaplaA(double miktarPure,double id)
        {
            if(id==1)
            {
                return (miktarPure * 54) / 100;
            }
            else if(id==2)
            {
                return (miktarPure * 25) / 100;
            }
            else if(id==3)
            {
                return (miktarPure * 12) / 100;
            }
            else if(id==4)
            {
                return (miktarPure * 225) / 100;
            }
            else if(id==5)
            {
                return (miktarPure * 681) / 100;
            }
            else
            {
                return (miktarPure * 3) / 100;
            }
        }

        public double VitaminHesaplaC(double miktarPure,double id)
        {
            if (id == 1)
            {
                return (miktarPure * 5) / 100;
            }
            else if (id == 2)
            {
                return (miktarPure * 5) / 100;
            }
            else if (id == 3)
            {
                return (miktarPure * 60) / 100;
            }
            else if (id == 4)
            {
                return (miktarPure * 45) / 100;
            }
            else if (id == 5)
            {
                return (miktarPure * 26) / 100;
            }
            else
            {
                return (miktarPure * 44) / 100;
            }
        }
    }
}
