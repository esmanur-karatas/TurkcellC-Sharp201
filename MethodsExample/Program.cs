using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExample
{
    internal class Program
    {
        // Method Tanımmlama
        // console yazı yazdırdık
        public static void yazdir()// geriye değer döndürmeyen metot örneği
        {
            Console.Write("Bu bir metottur.");
            Console.WriteLine(); // bir satır boşluk bırakmak için kullandık.
            Console.Write("Burası metodun başka bir satırıdır.");
            Console.WriteLine();

        }

        //İki sayının toplamını ekrana yazdırdık.
        public static void toplama() // metod oluşturduk.
        {
            int sayi1 = 24, sayi2 = 30; //değişken tanımlayıp değer atadık. 
            int toplam= sayi1 + sayi2;// toplam değişkeninin içine sayi1 ve sayi2 yi topladık
            Console.WriteLine(toplam);// sayi1 ve 2 nin toplamını ekrana bastırdık.
        }

        // console da boşluk bırakmak için metod tanımladık.
        public static void yazıbosluk()
        {
            Console.WriteLine();// boşluk bıraktık.
            Console.Write("******************");
            Console.WriteLine("");
        }

        // 1 den 10 a kadar olan sayıları ekrana yazdırdık
        public static void ardisiksayilar()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i+ " ");
            }
        }

        //GERİYE DEĞER DÖNDÜRMEYEN VOİD METOTLARDA PARAMETRE KULLANIMI

        public static void MetinYaz(string p) // buradaki string p parametredir.
        {
            Console.WriteLine("**********");
            Console.WriteLine();
            Console.WriteLine(p);// parametredeki değeri ekrana yazdırdık
            Console.WriteLine();
            Console.Write("**********");
        }

        // GERİYE DEĞER DÖNDÜRMEYEN METOTLARDA PARAMETRENİN KLAVYEDEN ALINMASI
        public static void MetiYaz2(string parametre)
        {
            Console.Write("---------------");
            Console.WriteLine();
            Console.Write(parametre);
            Console.WriteLine();
            Console.Write("----------------");
            
        }



        //GERİYE DEĞER DÖNDÜREN METOT KULLANIMI:
        public static int top()
        {
            int sayi1, sayi2, sonuc;
            sayi1 = 24;
            sayi2 = 30;
            sonuc = sayi1 + sayi2;
            return sonuc; // burada sonuc değerini döndürdük.
        }

        // PARAMETRELİ GERİYE DEĞER DÖNDÜREN METOT TANIMI
        public static int toplm(int s1, int s2)
        {
            int sonuc;
            sonuc= s1+s2;
            return sonuc;

        }
        static void Main(string[] args)
        {
            //metotları burada çağırırız. öence metodun adını yazarız. sonra da parantez açıp kapatırız.
            yazdir(); // yazdir metodunu çağırdık
            yazıbosluk();// yazıbosluk metodunu çağırdık
            toplama();// toplama metodunu çağırdık
            yazıbosluk();
            ardisiksayilar();
            Console.WriteLine();


            //GERİYE DEĞER DÖNDÜRMEYEN VOİD METOTLARDA PARAMETLİ METOTLARI ÇAĞIRMA
            MetinYaz("Burada p parametresinin string değerini girdik ekranda burası basılacak.");
            Console.WriteLine();


            // GERİYE DEĞER DÖNDÜRMEYEN METOTLARDA PARAMETRENİN KLAVYEDEN ALINMASI ÇAĞIRMA
            Console.Write("Parametrenin içine girecek string değeri yazınız: ");
            string kelime=Console.ReadLine();// buraya parametreyi kullanıcıdan almak için bir değişken tanımladık bunu da metodun içindeki parantezin içine yazıp böylece kullanıcıdan değer almış olacağız.
            MetiYaz2(kelime);
            Console.WriteLine();


            //GERİYE DEĞER DÖNDÜREN METOT ÇAĞRIMI
            // ekrana yazdırmak için cw içine almamız gerekiyor. yoksa çalışır ama ekrana değer dönmez.
            Console.WriteLine(top());


            //PARAMETRELİ GERİYE DEĞER DÖNDÜREN METOT ÇAĞIRMA
            Console.WriteLine($"Toplam {toplm(10,20)}");
            //klavyeden çağırma örneği
            int sa1,sa2;
            Console.Write("1. sayıyı giriniz:");
            sa1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            sa2=Convert.ToInt32(Console.ReadLine());
            Console.Write($"Sonuç: {toplm(sa1,sa2)}");
        


            Console.Read();// entera basana kdr uygulama kapanmasın diye bunu kullanırız.
        }
    }
}
