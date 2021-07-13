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
    interface IVitamin
    {
        double VitaminHesaplaA(double miktarPure, double id);
        double VitaminHesaplaC(double miktarPure, double id);
    }
}
