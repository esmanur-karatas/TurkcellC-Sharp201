using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // burada papağan sınıfından nesne oluşturup niteliklerini çağırdık. ve bu papağan kuslar sınıfından kalıtım aldığı için de kuslar sınıfındaki nitelikleri de buraya tanımlayabiliriz.
            papagan papagann = new papagan();
            Console.WriteLine("Papağanın Özellikleri:");
            papagann.tur = "Papağan";
            papagann.hiz = 50;
            papagann.isim = "Sultan";
            papagann.renk = "Sarı - Kırmızı"; ;
            papagann.agirlik = 1650;
            papagann.Sescikar(); // override ettiğimiz ses çıkar metodunu çağırdık ve aşağıda da ekrana bastırdık.
            Console.WriteLine($"Tür: {papagann.tur} " +
                $"\nHız: {papagann.hiz}" +
                $"\nİsim: {papagann.isim}" +
                $"\nRenk: {papagann.renk}" +
                $"\nSes: {papagann.Sescikar()}" + // burada override ettiğimiz metodun sonuna parantez koymazsak hata verir.
                $"\nAğırlık: {papagann.agirlik}");


            // karga sınıfını çağırdık.
            Karga karga = new Karga();
            Console.WriteLine("\nKarganın Özellikleri: ");
            karga.tur = "Karga";
            karga .hiz = 500;
            karga.isim = "Alacakarga";
            karga.renk = "Siyah - Beyaz";
            karga.agirlik = 1780;
            karga.Sescikar();

            Console.WriteLine($"Tür: {karga.tur} " +
               $"\nHız: {karga.hiz}" +
               $"\nİsim: {karga.isim}" +
               $"\nRenk: {karga.renk}" +
               $"\nSes: {karga.Sescikar()}" + // burada override ettiğimiz metodun sonuna parantez koymazsak hata verir.
               $"\nAğırlık: {karga.agirlik}");

        }
    }
}
