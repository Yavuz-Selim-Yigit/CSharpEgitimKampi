using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Yazdırma Komutları

namespace _01_MainSubjects
{
    internal class Program//Programın çalışacağı sınıf
    {
        static void Main(string[] args)
        {
            #region Yazdırma komutları

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Merhaba Dünya");


            //Console.WriteLine("****Yemek Katagorileri****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemek");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("");
            //Console.WriteLine("****Yemek Katagorileri****");

            #endregion

            #region Değişlenler

            /*String*/
            /*değişkenTürü değişkanAdı*/

            /*
            string name;
            name = "Yavuz";

            Console.WriteLine(name);
            */

            /*
            string costumerName;
            string costumerSurname;
            string costumerPhone;
            string costumerEmail, district, city;

            costumerName = "Yavuz Selim";
            costumerSurname = "Yiğit";
            costumerPhone = "+90 500 400 30 20";
            costumerEmail = "ysy@mail.com";
            district = "Selçuklu";
            city = "Konya";

            Console.WriteLine("----Müşteri Bilgisi----");
            Console.WriteLine($"-----------------------\nAdı Soyadı: {costumerName} {costumerSurname}\n--------İletişim-------\nTelefon: {costumerPhone}, Email: {costumerEmail}\n---------Adres---------\nİlçe: {district}, Şehir: {city}\n-----------------------");

            costumerName = "Yiğit Selim";
            costumerSurname = "Yavuz";
            costumerPhone = "+90 500 100 20 30";
            costumerEmail = "ysy@mail.com";
            district = "Etimesgut";
            city = "Ankara";

            Console.WriteLine($"-----------------------\nAdı Soyadı: {costumerName} {costumerSurname}\n--------İletişim-------\nTelefon: {costumerPhone}, Email: {costumerEmail}\n---------Adres---------\nİlçe: {district}, Şehir: {city}\n-----------------------");
            */

            #endregion

            #region Int Değişkenler

            /*
            //int
            int number = 24;
            Console.WriteLine(number);
            */

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonatePrice = 30;

            Console.WriteLine("----------Restoran Menü Fiyatı---------\n");
            Console.WriteLine($"----------Hamburger: {hamburgerPrice}TL\n----------Pizza: {pizzaPrice}TL\n----------Kola: {cokePrice}TL\n----------Limonata: {lemonatePrice}TL\n----------Kızartma: {friesPrice}TL\n----------Su: {waterPrice}TL\n");
            Console.WriteLine("----------Restoran Menü Fiyatı---------\n");

            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 0;
            int lemonateCount = 0;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonatePrice = 0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonatePrice = lemonatePrice * lemonateCount;

            int total;
            total=totalHamburgerPrice+totalCokePrice+totalWaterPrice+totalFriesPrice+totalPizzaPrice+totalLemonatePrice;

            Console.WriteLine($"Hamburger Tutarı: {totalHamburgerPrice}TL\nPizza Tutarı: {totalPizzaPrice}TL\nKola Tutarı: {totalCokePrice}TL\nLimonata Tutarı: {totalLemonatePrice}TL\nKızartma Tutarı: {totalFriesPrice}TL\nSu Tutarı: {totalWaterPrice}TL\n");


            Console.WriteLine($"Toplam Tutar: {total}TL");
            #endregion

            Console.Read();
        }
    }
}




