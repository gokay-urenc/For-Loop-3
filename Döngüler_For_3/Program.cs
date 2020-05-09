using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_For_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    Console.Write("\nGirdiğiniz sayı: " + sayi + "\n");
                }
                else if (i == 2)
                {
                    Console.Write("\nGirdiğiniz sayı: " + sayi + "\n");
                }
                else
                {
                    Console.Write("\nGirdiğiniz sayı: " + sayi + "\n");
                }
                toplam += sayi;
                Console.WriteLine("\nSayılarınızın toplamı: " + toplam + "\n");
            }
            Console.ReadKey();
        }
    }
}
// Kullanıcıdan 3 adet sayı istenerek yazılan her sayıyı bir öncekiyle toplayan ve sonucunu gösteren program.