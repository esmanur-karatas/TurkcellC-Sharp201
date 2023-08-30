using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizlarlaSekilOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //Yıldızlarla Dikdörtgen Oluşturma
            //    for (int i =1 ; i <=10; i++)
            //    {
            //        Console.WriteLine("********");            }
            //}

            // Yıldızlarla Dik Üçgen Yapma
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

