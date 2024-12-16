using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Geriye Değer Döndürmeyen (Void) Metotlar
            //void HelloWorld()
            //{
            //    Console.WriteLine("Hello World");
            //}
            //HelloWorld();

            //void Sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //} 
            //Sum();
            #endregion
            #region Geriye Değer Döndürmeyen String Parametreli (Void) Metotlar
            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: "+ name+" "+surName);
            //}
            //CustomerCard("Mehmet","Demirel");
            #endregion
            #region Geriye Değer Döndürmeyen Int Parametreli (Void) Metotlar
            //void Sum(int number1, int number2, int number3)
            //{ 
            //    int result=number1+ number2+ number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4,5,6);
            #endregion
            //------------------------------------------
            #region Geriye Değer Döndüren Metotlar
            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name ="Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion
            #region Geriye Değer Döndüren String Parametreli Metotlar
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName+ " - Başkent: "+ capital+ " - Bayrak Rengi: "+flagColor;
            //    return cardInfo;
            //}
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            #endregion
            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int Sum(int number1, int number2)
            //{
            //    int result = number1+number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(12,345));
            #endregion
            Console.Read();
        }
    }
}
