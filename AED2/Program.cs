﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1

            //ogrenci[] ogrenciler = new ogrenci[3];
            //ogrenciler[0] = new ogrenci();
            //ogrenciler[0].Isim = "Meltem";
            //ogrenciler[0].OgrenciNo = "123456";
            //ogrenciler[0].Not = 85;
            //ogrenciler[1] = new ogrenci();
            //ogrenciler[1].Isim = "Berkay";
            //ogrenciler[1].OgrenciNo = "123457";
            //ogrenciler[1].Not = 78;
            //ogrenciler[2] = new ogrenci();
            //ogrenciler[2].Isim = "Ömer";
            //ogrenciler[2].OgrenciNo = "123458";
            //ogrenciler[2].Not = 45;
            //string devammi = "E";
            //while (devammi.ToUpper() == "E")
            //{
            //    Console.WriteLine("Lütfen Arama Yöntemini Seçiniz");
            //    Console.WriteLine("1- İsim İle Arama");
            //    Console.WriteLine("2- Öğrenci No İle Arama");
            //    int secim = Convert.ToInt16(Console.ReadLine());
            //    if (secim == 1)
            //    {
            //        Console.WriteLine("Lütfen İsim Giriniz");
            //        string isim = Console.ReadLine();
            //        for (int i = 0; i < ogrenciler.Count(); i++)
            //        {
            //            if (isim == ogrenciler[i].Isim)
            //            {
            //                Console.WriteLine($"{ogrenciler[i].Isim} öğrencimizin öğrenci no {ogrenciler[i].OgrenciNo} olup sınav sonucu {ogrenciler[i].Not} olarak iletilmiştir.");
            //                if (ogrenciler[i].Not >= 50)
            //                {
            //                    Console.WriteLine("Tebrikler Geçtiniz");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Ne Yazık ki Kaldınız");
            //                }
            //            }
            //        }
            //    }
            //    else if (secim == 2)
            //    {
            //        Console.WriteLine("Lütfen Öğrenci No Giriniz");
            //        string no = Console.ReadLine();
            //        for (int i = 0; i < ogrenciler.Count(); i++)
            //        {
            //            if (no == ogrenciler[i].OgrenciNo)
            //            {
            //                Console.WriteLine($"{ogrenciler[i].Isim} öğrencimizin öğrenci no {ogrenciler[i].OgrenciNo} olup sınav sonucu {ogrenciler[i].Not} olarak iletilmiştir.");
            //                if (ogrenciler[i].Not >= 50)
            //                {
            //                    Console.WriteLine("Tebrikler Geçtiniz");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Ne Yazık ki Kaldınız");
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ya 1 Ya 2'ye basacaksın bari buna şaşırma ");
            //    }
            //    Console.WriteLine("Arama Yapmaya Devam Etmek İster misiniz E/H");
            //    devammi = Console.ReadLine();
            //    Console.Clear();
            //}

            #endregion

            #region urunler
            urunler [] urun = new urunler[19];
            urun[0] = new urunler();
            urun[0].adı = "Metal Araba";
            urun[0].kategorisi = "Oyuncak";
            urun[0].fiyat = 124.90;
            urun[0].marka = "Hot Wheels";
            urun[0].stok = 5;

            urun[1] = new urunler();
            urun[1].adı = "Metal Araba";
            urun[1].kategorisi = "Oyuncak";
            urun[1].fiyat = 3999;
            urun[1].marka = "AUDİ DİECAST 1.24";
            urun[1].stok = 2;

            urun[2] = new urunler();
            urun[2].adı = "Sesli Bebek";
            urun[2].kategorisi = "Oyuncak";
            urun[2].fiyat = 2900;
            urun[2].marka = "Cry Babies";
            urun[2].stok = 3;

            urun[3] = new urunler();
            urun[3].adı = "Metal Araba";
            urun[3].kategorisi = "Oyuncak";
            urun[3].fiyat = 124.90;
            urun[3].marka = "Hot Wheels";
            urun[3].stok = 5;

            urun[4] = new urunler();
            urun[4].adı = "Metal Araba";
            urun[4].kategorisi = "Oyuncak";
            urun[4].fiyat = 124.90;
            urun[4].marka = "Hot Wheels";
            urun[4].stok = 5;

            urun[5] = new urunler();
            urun[5].adı = "Metal Araba";
            urun[5].kategorisi = "Oyuncak";
            urun[5].fiyat = 124.90;
            urun[5].marka = "Hot Wheels";
            urun[5].stok = 5;

            urun[6] = new urunler();
            urun[6].adı = "Metal Araba";
            urun[6].kategorisi = "Oyuncak";
            urun[6].fiyat = 124.90;
            urun[6].marka = "Hot Wheels";
            urun[6].stok = 5;

            urun[7] = new urunler();
            urun[7].adı = "Metal Araba";
            urun[7].kategorisi = "Oyuncak";
            urun[7].fiyat = 124.90;
            urun[7].marka = "Hot Wheels";
            urun[7].stok = 5;

            urun[8] = new urunler();
            urun[8].adı = "Metal Araba";
            urun[8].kategorisi = "Oyuncak";
            urun[8].fiyat = 124.90;
            urun[8].marka = "Hot Wheels";
            urun[8].stok = 5;

            urun[9] = new urunler();
            urun[9].adı = "Metal Araba";
            urun[9].kategorisi = "Oyuncak";
            urun[9].fiyat = 124.90;
            urun[9].marka = "Hot Wheels";
            urun[9].stok = 5;

            urun[10] = new urunler();
            urun[10].adı = "Metal Araba";
            urun[10].kategorisi = "Oyuncak";
            urun[10].fiyat = 124.90;
            urun[10].marka = "Hot Wheels";
            urun[10].stok = 5;

            urun[11] = new urunler();
            urun[11].adı = "Metal Araba";
            urun[11].kategorisi = "Oyuncak";
            urun[11].fiyat = 124.90;
            urun[11].marka = "Hot Wheels";
            urun[11].stok = 5;

            urun[12] = new urunler();
            urun[12].adı = "Metal Araba";
            urun[12].kategorisi = "Oyuncak";
            urun[12].fiyat = 124.90;
            urun[12].marka = "Hot Wheels";
            urun[12].stok = 5;

            urun[13] = new urunler();
            urun[13].adı = "Metal Araba";
            urun[13].kategorisi = "Oyuncak";
            urun[13].fiyat = 124.90;
            urun[13].marka = "Hot Wheels";
            urun[13].stok = 5;

            urun[14] = new urunler();
            urun[14].adı = "Metal Araba";
            urun[14].kategorisi = "Oyuncak";
            urun[14].fiyat = 124.90;
            urun[14].marka = "Hot Wheels";
            urun[14].stok = 5;

            urun[15] = new urunler();
            urun[15].adı = "Metal Araba";
            urun[15].kategorisi = "Oyuncak";
            urun[15].fiyat = 124.90;
            urun[15].marka = "Hot Wheels";
            urun[15].stok = 5;

            urun[16] = new urunler();
            urun[16].adı = "Metal Araba";
            urun[16].kategorisi = "Oyuncak";
            urun[16].fiyat = 124.90;
            urun[16].marka = "Hot Wheels";
            urun[16].stok = 5;

            urun[17] = new urunler();
            urun[17].adı = "Metal Araba";
            urun[17].kategorisi = "Oyuncak";
            urun[17].fiyat = 124.90;
            urun[17].marka = "Hot Wheels";
            urun[17].stok = 5;

            urun[18] = new urunler();
            urun[18].adı = "Metal Araba";
            urun[18].kategorisi = "Oyuncak";
            urun[18].fiyat = 124.90;
            urun[18].marka = "Hot Wheels";
            urun[18].stok = 5;

            urun[19] = new urunler();
            urun[19].adı = "Metal Araba";
            urun[19].kategorisi = "Oyuncak";
            urun[19].fiyat = 124.90;
            urun[19].marka = "Hot Wheels";
            urun[19].stok = 5;

            
            #endregion

            #region AED
            Console.WriteLine("YENİ KİTAP KIRTASİYE HOŞGELDİNİZ...");
            string devammi = "e";
            while (devammi.ToUpper() == "E")
            {
                Console.WriteLine("Lütfen hangi kategoride alışveriş yapmak istediğiniz seçiniz.");
                Console.WriteLine("1- OYUNCAK");
                Console.WriteLine("2- KIRTASİYE");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("");
                    for (int i = 0; i < urunler.Count(); i++)
                    {

                    }
                }

                
            }
            
            


            #endregion
        }
    }
}
