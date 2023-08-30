using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarClass car = new CarClass(); // araba sınıfına nesne türettik.
            // aşağıda araba sınıfındaki niteliklere değer verdik.
            car.marka = "Honda";
            car.hiz = 180;
            car.model = "2020";
            car.motor = 1.9;
            car.renk = "kırmızı";

            Console.WriteLine("\n ARABA TANITIM KARTI");
            Console.WriteLine($" Marka: {car.marka} " +
                $"\n Hız: {car.hiz}" +
                $"\n Model: {car.model} " +
                $"\n Motor: {car.motor}" +
                $"\n Renk: {car.renk}");

            // MÜŞTERİ SINIFI
            Customer customer = new Customer();
            customer.Id= 1;
            customer.Name = "Esmanur";
            customer.Surname = "Karataş";
            customer.City = "Elazığ";

            Console.WriteLine("\n MÜŞTERİ BİLGİLERİ");
            Console.WriteLine($" Müşteri Numarası: {customer.Id}" +
                $"\n Müşteri Adı Soyadı: {customer.Name} {customer.Surname}" +
                $"\n Müşterinin Yaşadığı Şehir: {customer.City}");

            //Klavyeden değer alarak yapımı 
            Console.Write("\n Müşteri numaranızı giriniz: ");
            customer.Id= Convert.ToInt32( Console.ReadLine() );
            Console.Write(" Adınız: ");
            customer.Name= Console.ReadLine();
            Console.Write(" Soyadınız: ");
            customer.Surname= Console.ReadLine();
            Console.Write(" Şehir: ");
            customer.City= Console.ReadLine();
        }
    }
}
