using System;
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
            urunler[] urun = new urunler[20];

            urun[0] = new urunler();
            urun[0].adı = "Metal Araba";
            urun[0].kategorisi = "OYUNCAK";
            urun[0].fiyat = 124.90;
            urun[0].marka = "Hot Wheels";
            urun[0].stok = 15;

            urun[1] = new urunler();
            urun[1].adı = "Peluş Ayı";
            urun[1].kategorisi = "OYUNCAK";
            urun[1].fiyat = 299.90;
            urun[1].marka = "Birlik Oyuncak";
            urun[1].stok = 8;

            urun[2] = new urunler();
            urun[2].adı = "Oyuncak Tren Seti";
            urun[2].kategorisi = "OYUNCAK";
            urun[2].fiyat = 449.90;
            urun[2].marka = "Dede";
            urun[2].stok = 5;

            urun[3] = new urunler();
            urun[3].adı = "Bebek";
            urun[3].kategorisi = "OYUNCAK";
            urun[3].fiyat = 199.90;
            urun[3].marka = "Sevimli Dostlar";
            urun[3].stok = 12;

            urun[4] = new urunler();
            urun[4].adı = "Uzaktan Kumandalı Araba";
            urun[4].kategorisi = "OYUNCAK";
            urun[4].fiyat = 599.90;
            urun[4].marka = "Pilsan";
            urun[4].stok = 6;

            urun[5] = new urunler();
            urun[5].adı = "Lego Seti";
            urun[5].kategorisi = "OYUNCAK";
            urun[5].fiyat = 849.90;
            urun[5].marka = "LEGO";
            urun[5].stok = 10;

            urun[6] = new urunler();
            urun[6].adı = "Tahta Bloklar";
            urun[6].kategorisi = "OYUNCAK";
            urun[6].fiyat = 179.90;
            urun[6].marka = "Toyzz Shop";
            urun[6].stok = 20;

            urun[7] = new urunler();
            urun[7].adı = "Puzzle";
            urun[7].kategorisi = "OYUNCAK";
            urun[7].fiyat = 89.90;
            urun[7].marka = "Anatolian";
            urun[7].stok = 15;

            urun[8] = new urunler();
            urun[8].adı = "Oyun Hamuru Seti";
            urun[8].kategorisi = "OYUNCAK";
            urun[8].fiyat = 159.90;
            urun[8].marka = "Play-Doh";
            urun[8].stok = 25;

            urun[9] = new urunler();
            urun[9].adı = "Barbie Bebek";
            urun[9].kategorisi = "OYUNCAK";
            urun[9].fiyat = 399.90;
            urun[9].marka = "Barbie";
            urun[9].stok = 7;

            urun[10] = new urunler();
            urun[10].adı = "Spiralli Defter";
            urun[10].kategorisi = "KIRTASİYE";
            urun[10].fiyat = 24.90;
            urun[10].marka = "Gıpta";
            urun[10].stok = 50;

            urun[11] = new urunler();
            urun[11].adı = "Kurşun Kalem Seti";
            urun[11].kategorisi = "KIRTASİYE";
            urun[11].fiyat = 49.90;
            urun[11].marka = "Faber-Castell";
            urun[11].stok = 30;

            urun[12] = new urunler();
            urun[12].adı = "Keçeli Kalem 12'li";
            urun[12].kategorisi = "KIRTASİYE";
            urun[12].fiyat = 89.90;
            urun[12].marka = "Stabilo";
            urun[12].stok = 25;

            urun[13] = new urunler();
            urun[13].adı = "Okul Çantası";
            urun[13].kategorisi = "KIRTASİYE";
            urun[13].fiyat = 299.90;
            urun[13].marka = "Herlitz";
            urun[13].stok = 15;

            urun[14] = new urunler();
            urun[14].adı = "Silgi";
            urun[14].kategorisi = "KIRTASİYE";
            urun[14].fiyat = 12.90;
            urun[14].marka = "Rotring";
            urun[14].stok = 100;

            urun[15] = new urunler();
            urun[15].adı = "Kalemlik";
            urun[15].kategorisi = "KIRTASİYE";
            urun[15].fiyat = 69.90;
            urun[15].marka = "Mikro";
            urun[15].stok = 20;

            urun[16] = new urunler();
            urun[16].adı = "Sunum Dosyası";
            urun[16].kategorisi = "KIRTASİYE";
            urun[16].fiyat = 34.90;
            urun[16].marka = "Globox";
            urun[16].stok = 40;

            urun[17] = new urunler();
            urun[17].adı = "Boya Seti";
            urun[17].kategorisi = "KIRTASİYE";
            urun[17].fiyat = 159.90;
            urun[17].marka = "Artline";
            urun[17].stok = 18;

            urun[18] = new urunler();
            urun[18].adı = "A4 Fotokopi Kağıdı";
            urun[18].kategorisi = "KIRTASİYE";
            urun[18].fiyat = 129.90;
            urun[18].marka = "Navigator";
            urun[18].stok = 45;

            urun[19] = new urunler();
            urun[19].adı = "Yapıştırıcı";
            urun[19].kategorisi = "KIRTASİYE";
            urun[19].fiyat = 19.90;
            urun[19].marka = "Pritt";
            urun[19].stok = 60;
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
                    Console.Clear();
                    Console.WriteLine("Oyuncak Kategorisindeki Ürünler:");

                    for (int i = 0; i < urun.Length; i++)
                    {
                        if (urun[i].kategorisi.ToUpper() == "OYUNCAK")
                        {
                            Console.WriteLine($"{urun[i].adı} - {urun[i].fiyat} TL - {urun[i].marka} - Stok: {urun[i].stok}");
                        }
                    }
                }
            }
            #endregion
        }
    }
}
