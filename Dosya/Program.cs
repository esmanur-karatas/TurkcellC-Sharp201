using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\DELL\\Desktop\\deneme.txt"); // burada parantez den önceki streamde hata verir çünkü adres ister masaüstündeki bir dosyanın
            // bulunduğu konumu buraya yazarsak sorun ortadan kalkar.
            // c# da dosya uzantılarının arasına tek değil 2 tane / koyulur. Tek koyarsak hata verir. ya da tırnaktan önce @ işareti koyabiliriz.
            // bunu yapıp console u çalıştırdığımız da konsol açıldıktan sonra enter a basınca masaüstünde ya da konumu neredeyse artık orada deneme adında dosya oluşturur.
            //Console dan aldığımız veriyi dosyanın içine yerleştirmek.
            string metin;
            Console.WriteLine("Metni Giriniz:");
            metin = Console.ReadLine();
            sw.Write(metin);// dosyanın içine yazdık metnimizi.
            sw.Close();// bununla enter basınca dosyanın içine ekledik.


            //DOSYA OKUMA İŞLEMLERİ:
            FileStream fs = new FileStream("C:\\Users\\DELL\\Desktop\\İSİM-SOYİSİM[1].docx", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs); //fs nin içindeki dosyayı okutmak için kullanırız.
            string metinn= sr.ReadLine();
            while (metinn != null)
            {
                Console.WriteLine(metinn);
                metinn = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
    }
}
