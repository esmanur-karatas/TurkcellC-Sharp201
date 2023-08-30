using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaplikProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat = 0;
            string secim;
            Console.WriteLine("--------------------------------------------------------------------------\n");
            Console.WriteLine("--  Türkçe Kitaplar Kategorisi    --  Yabancı Kitaplar Kategorisi       --\n");
            Console.WriteLine("--  1-Çalıkuşu: Reşat Nuri        --  7-Tuna Kılavuzu: Jules Verne      --\n");
            Console.WriteLine("--  2-Yaban: Yakup Kadri          --  8-Bir Kuzey Macerası: Jack London --\n");
            Console.WriteLine("--  3-Sinekli Bakkal: Halide Edip --  9-Altıncı Koğuş: Anton Çehov      --\n");
            Console.WriteLine("--  4-Tehlikeli Oyunlar: O.Atay   --  10-Kumarbaz: Dostoyevski          --\n");
            Console.WriteLine("--  5-Geçtiğim Günlerden: S.Ali   --  11-İki Şehrin Hikayesi: C.Dickens --\n");
            Console.WriteLine("--  6-Kuyucaklı Yusuf: S.Ali      --  12-Vişne Bahçesi: Anton Çehov     --\n");
            Console.WriteLine("--------------------------------------------------------------------------\n");

            Console.WriteLine("----- İşlemler Menüsü -----\n");
            Console.WriteLine("1-Fiyat Sorgulama \n2-Yeni Okur Kaydı \n3-Günün Kitabı \n4-Yeni Kitap Satın Al \n5-Oyun\n");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '1')
            {
                Console.WriteLine("\nLütfen Fiyatını Öğrenmek İstediğiniz Kitabın Numarasını Giriniz:");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.Write("Çalıkuşu: 12Tl"); break;
                    case "2": Console.Write("Yaban: 14Tl"); break;
                    case "3": Console.Write("Sinekli Bakkal: 15Tl"); break;
                    case "4": Console.Write("Tehlikeli Oyunlar: 18Tl"); break;
                    case "5": Console.Write("Geçtiğim Gümlerden: 11Tl"); break;
                    case "6": Console.Write("Kuyucaklı Yusuf: 15Tl"); break;
                    case "7": Console.Write("Tuna Kılavuzu: 23Tl"); break;
                    case "8": Console.Write("Bir Kuzey Macerası: 34Tl"); break;
                    case "9": Console.Write("Altıncı Koğuş: 21Tl"); break;
                    case "10": Console.Write("Kumarbaz: 34Tl"); break;
                    case "11": Console.Write("İki Şehrin Hikayesi: 54Tl"); break;
                    case "12": Console.Write("Vişne Bahçesi: 34Tl"); break;
                    default: Console.WriteLine("Böyle Bir Kitap Numarası Bulunmamaktadır.Lütfen Kitabın Numarasını Kontrol Ediniz"); break;
                }
            }
            if (islem == '2')
            {
                Console.WriteLine("\n----- Yeni Okur Kaydı -----");
                string ad, soyad, universite;
                Console.Write($"Adınız: ");
                ad = Console.ReadLine();
                Console.Write($"Soyadınız:");
                soyad = Console.ReadLine();
                Console.Write($"Universiyeniz:");
                universite = Console.ReadLine();
                // // kullanıcı bilgilerini masaüstünde yeni dosya açıp içine ekledik.
                //// string dosya = @"C: \Users\DELL\Desktop\deneme.txt";
                // StreamWriter sw= new StreamWriter(@"C: \Users\DELL\Desktop\kullanici.txt"  );
                // sw.WriteLine( ad );
                //// sw.Write($"Adınız: {ad}\nSoyadınız: {soyad}\nÜniversiteniz: {universite}");
                // sw.Close();
                Console.WriteLine("Kaydınız Başarıyla Oluşturuldu.");
            }

            if (islem == '3')
            {
                Console.WriteLine("------------------------------------\n");
                Console.WriteLine("----- Bugünün Kitabı: Çalıkuşu -----");
                Console.WriteLine("\n------------------------------------");
            }
            //if (islem == '4')
            //{
            //    Console.WriteLine("------------------------------------\n");
            //    FileStream fs = new FileStream(@"‪C:\Users\DELL\Desktop\kitaplar.txt", FileMode.Open, FileAccess.Read);
            //    StreamReader sr = new StreamReader(fs);
            //    string metin = sr.ReadLine();
            //    while ( metin != null )
            //    {
            //        Console.WriteLine( metin );
            //        metin = sr.ReadLine();
            //    }
            //    sr.Close();
            //    fs.Close();
            //    Console.WriteLine("\n------------------------------------");

            //}
            if (islem == '4')
            {
                Console.Write("\nAlacağınız Kitabın Numarası: ");
                secim = Console.ReadLine();
                if (secim == "1")
                {
                    toplamfiyat = toplamfiyat + 12;
                }
                else if (secim == "2")
                {
                    toplamfiyat = toplamfiyat + 14;
                }
                else if (secim == "3")
                {
                    toplamfiyat = toplamfiyat + 15;
                }
                else if (secim == "4")
                {
                    toplamfiyat = toplamfiyat + 18;
                }
                else if (secim == "5")
                {
                    toplamfiyat = toplamfiyat + 11;
                }
                else if (secim == "6")
                {
                    toplamfiyat = toplamfiyat + 15;
                }
                else if (secim == "7")
                {
                    toplamfiyat = toplamfiyat + 23;
                }
                else if (secim == "8")
                {
                    toplamfiyat = toplamfiyat + 34;
                }
                else if (secim == "9")
                {
                    toplamfiyat = toplamfiyat + 21;
                }
                else if (secim == "10")
                {
                    toplamfiyat = toplamfiyat + 34;
                }
                else if (secim == "11")
                {
                    toplamfiyat = toplamfiyat + 54;
                }
                else if (secim == "12")
                {
                    toplamfiyat = toplamfiyat + 34;
                }
                else
                {
                    Console.WriteLine("Böyle Bir Kitap Numarası Yok.\n");
                }
                Console.WriteLine($"Toplam Tutar: {toplamfiyat}");
            }

            if (islem == '5')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                while (sayi!= tahmin)
                {
                    Console.WriteLine("Sayi Giriniz:");
                    tahmin=Convert.ToInt16(Console.ReadLine());
                    if (tahmin>sayi)
                    {
                        Console.Write("Daha Küçük");
                    }if (tahmin<sayi)
                    {
                        Console.Write("Daha Büyük");
                    }
                    if(tahmin == sayi)
                    {
                        Console.Write("Bildiniz!");
                        break;
                    }
                }
            }
            Console.Read();

        }
    }
}