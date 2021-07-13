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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G201210057_MUHAMMET_BARIŞ_YILMAZ
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
