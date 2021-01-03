using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.TusasKazanMyo.SayiTahminOyunu.TarikDemirci
{
    class Program
    {
        static void Main(string[] args)
        {
        BASADON:
            Console.WriteLine("SEVİYE SEÇİNİZ (KOLAY-ORTA-ZOR):");
            string seviye = Console.ReadLine().ToLower();

            for (; ; )
            {
                if (seviye == "kolay")
                {
                    int hak = 4;
                    Random rnd = new Random();
                    int sayi = rnd.Next(1, 10);
                TEKRAR:
                    Console.WriteLine("Bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());
                    if (hak <= 0)
                    {
                        Console.WriteLine("Hakkınız Bitti!");
                        goto BASADON;
                    }
                    else if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler... Bildiniz");
                        goto BASADON;
                    }
                    else
                    {
                        Console.WriteLine("Tekrar Deneyiniz...Kalan Hakkınız:" + hak);
                        hak--;
                        goto TEKRAR;
                    }
                }
                else if (seviye == "orta")
                {
                    int hak = 4;
                    Random rnd = new Random();
                    int sayi = rnd.Next(1, 25);
                TEKRAR:
                    Console.WriteLine("Bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());
                    if (hak <= 0)
                    {
                        Console.WriteLine("Hakkınız Bitti!");
                        goto BASADON;
                    }
                    else if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler... Bildiniz");
                        goto BASADON;
                    }
                    else
                    {
                        Console.WriteLine("Tekrar Deneyiniz...Kalan Hakkınız:" + hak);
                        hak--;
                        goto TEKRAR;
                    }
                }
                else if (seviye == "zor")
                {
                    int hak = 5;
                    Random rnd = new Random();
                    int sayi = rnd.Next(1, 50);
                TEKRAR:
                    Console.WriteLine("Bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());
                    if (hak <= 0)
                    {
                        Console.WriteLine("Hakkınız Bitti!");
                        goto BASADON;
                    }
                    else if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler... Bildiniz");
                        goto BASADON;
                    }
                    else
                    {
                        Console.WriteLine("Tekrar Deneyiniz...Kalan Hakkınız:" + hak);
                        hak--;
                        goto TEKRAR;
                    }
                }
                else
                {
                    Console.WriteLine("Sadece (KOLAY-ORTA-ZOR) seviyelerinden birini yazabilirsiniz");
                    goto BASADON;
                }
            }
        }
    }
}
