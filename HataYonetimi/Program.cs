using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iki sayıyı çarpma işlemi yaptık 2. sayı string değer aldığında hata verir. İşte bu hatayı şimdi try catch ile ekrana hata mesajı yazdıracağız
            //yazdığmız kodları try içine aldık.
            try
            {
                int sayi1, sayi2, sonuc;
                Console.Write("1. sayıyı giriniz");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. sayıyı giriniz");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                sonuc = sayi1 * sayi2;
                Console.Write($"sonuç: {sonuc}");
            }
            catch (FormatException)// eğer hatalı değer girersek uyarı verir mesela string değer girdiğimiz zaman
            {
                Console.WriteLine("HATA VAR LÜTFEN FORMATINIZI KONTROL EDİNİZ!");
                //Console.WriteLine(ex);//exception hatanın ne olduğunun detaylarını bize verir. Bunu çağırdık.
            }


            // yukarıdaki catch buluğunun içine başka hata mesajları da yazabiliriz. örneğin FormatException ya da OverflowException gibi. bir try catch buluğunun içinde birden fazla catch kullanabiliriz. bir tane örnek yapalım
            catch (OverflowException)
            {
                Console.WriteLine("Lütfen aralığın dışında değer girmeyin!");
            }
            //Finaly kullanımı
            finally
            {
                Console.WriteLine("hata olmasına rağmen burası çalıştı.");
            }
        }
    }
}
