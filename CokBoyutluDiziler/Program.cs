using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBoyutluDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Çok Boyutlu Diziler
            int[,] sayilar = new int[2, 2]; // burada 2 satır ve 2 sütundan oluştuğunu söyledik.
            sayilar[0, 0] = 10;//burada 0. satır ve 0. sütuna 10 değerini atadık. 
            sayilar[0, 1] = 20;
            sayilar[1, 0] = 30;
            sayilar[1, 1] = 50;
            Console.WriteLine(sayilar[0, 1]); //buradada 0.satırın 1. sütunundaki değeri ekrana yazdırdık.

        }
    }
}
