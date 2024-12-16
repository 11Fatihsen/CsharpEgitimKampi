using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler
            #region For Döngüsü
            //for (x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.Write("c# egitim kampi ");
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <=50; i +=3)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion
            #region For Döngüsü ile Karar yapıları
            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Toplam: "+totalValue);

            // 1-2-4-8-16 (bakterilerin saat saat artışı)
            int bacterium = 1;
            for (int i = 1; i <= 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            }

            #endregion
            #region While Döngüsü
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);
            #endregion
            #region Örnek uygulamalar
            // Klavyeden Girilen 3 basamaklı sayının basamakları toplamını hesaplayan
            //kodu yazınız.

            Console.WriteLine("3 basamaklı bir sayı giriniz : ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum ;

            ones = number % 10;
            tens = (number %100) / 10;
            hundreds = number / 100;
            Console.WriteLine(ones +"-" +tens + "-" +hundreds);
            sum= ones + tens + hundreds;
            Console.WriteLine(sum);
            #endregion




            Console.Read();
        }
    }
}
