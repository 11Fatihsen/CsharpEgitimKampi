using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] cities = new string[3];

            //cities[0] = "Milano";
            //cities[1] = "İstanbul";
            //cities[2] = "Kuwait";

            //int[] numbers = new int[3];
            //numbers[0] = 1589654;
            //numbers[1] = 1254668;
            //numbers[2] = 1255455;

            //string[] nationality = {"Turkish","Other"};


            //Console.WriteLine(cities[2]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(nationality[1]);
            #endregion
            #region Dizideki Tüm Elemanları listeleme
            //string[] colors = { "Sarı", "Mavi", "Siyah", "Kırmızı", "Gri" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] myArray = { 47, 58, 23, 85, 158, 654, 111, 12 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length ; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);


            //int[] numbers = { 47, 58, 23, 85, 158, 654, 111, 12 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion
            #region Dizi Metotlar
            //string[] customers = { "Ali","Buse","AyşeGül","Çınar" };
            //int index = Array.IndexOf(customers, "Çınar");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 89, 152, 659, 555, 12 };
            //Console.WriteLine("Dizinin En büyük Elemanı: "+ numbers.Max() +
            //    " Dizinin En Küçük Elemanı : " + numbers.Min());

            #endregion
            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[3];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen  {i + 1}. Şehri Giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
            #endregion
            Console.ReadLine(); 
        }
    }
}
