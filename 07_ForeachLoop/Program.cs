using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Foreach(1;2;3;4)

            // 1: Değişken Türü
            // 2: Değişken Adı
            // 3: In
            // 4: Liste, Koleksiyon, Dizi
            #region Foreach Döngüsü
            //string[] cities = { "Milano", "Roma", "Budapeşte", "İstanbul" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}


            //string word = "Merhaba";
            //foreach (var c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            Console.WriteLine("Eğitim Kampı Sınav Uygulaması");
            Console.WriteLine();
            Console.WriteLine();

            //Sınıfta ki öğrencilerin sayısını kullanıcıdan alma
            Console.WriteLine("----------------------");
            Console.WriteLine("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");

            // Öğrenci isimleri ve not ortalamalırını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine();
                studentNames[i] = Console.ReadLine();
            }

            #endregion
            Console.ReadLine();
        }
    }
}
