using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.WriteLine("Lütfen Şifrenizi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "1234")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //};

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 49)
            //{
            //    result = "Dersten Kaldınız.";
            //}
            //if (average >= 50 & average <= 100)
            //{
            //    result = "Dersten Geçtiniz.";
            //}
            //Console.WriteLine(result);

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin") {
            //    Console.Write("Kullanıcı Adı Hatalı!");
            //}
            //else {
            //    Console.Write("Hoş Geldiniz.");
            //};

            #endregion
            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir.");
            //}

            #endregion
            #region Char ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen takım sembolü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team =='f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            #endregion
            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menüyü seçin: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("****** Ana Yemekler ******");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine("1-Köri Tavuk");
            //    Console.WriteLine("2- Kızartma");
            //    Console.WriteLine("3- Musakka");
            //    Console.WriteLine("4- Köfte");
            //    Console.WriteLine("5- Nohut Pilav");
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine();


            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("****** Çorbalar ******");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine("1- Mercimek");
            //    Console.WriteLine("2- Ezogelin");
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("****** Pizzalar ******");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine("1- Pizza Turco");
            //    Console.WriteLine("2- Margaritha");
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("****** İçecekler ******");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine("1- Ayran");
            //    Console.WriteLine("2- Kola");
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine();
            //}
            #endregion
            #region Switch Case
            //Console.WriteLine("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break;
            //}
            #endregion
            #region Hesap Makinesi Switc-Case

            int number1, number2, result;
            char symbol;

            Console.Write("1. Sayıyı giriniz: ");
            number1=int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Yapmak İstediğiniz işlemi seçiniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            { 
                case '+':
                    result = number1+number2;
                    Console.Write("Toplam" + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.Write("Fark" + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.Write("Çarpım" + result);
                     break;
                case '/':
                    result = number1 / number2;
                    Console.Write("Bölüm" + result);
                    break;



            }
            #endregion
            Console.Read();

        }


    }
}
