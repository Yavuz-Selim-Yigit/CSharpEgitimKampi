using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If else

            /*
            Console.Write("Lütfen şifreyi giriniz: ");
            string password=Console.ReadLine();

            if (password == "abcd")
            {
                Console.WriteLine("Şifre Doğru!");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış!");
            }
            
            

            string capital, country;

            Console.Write("Başkent giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi giriniz: ");
            country= Console.ReadLine();

            if (capital =="ankara"& country=="türkiye")
            {
                Console.Write("Veriler doğrulandı");
            }
            else
            {
                Console.Write("Veriler hatalı");
            }
            

            int number;
            Console.Write("Sayı giriniz: ");
            number = int.Parse(Console.ReadLine());
            if (number == 5)
            {
                Console.WriteLine("Sayı Doğru");
            }
            else
            {
                Console.WriteLine("Sayı Hatalı");
            }
            


            int exam1, exam2, exam3, avarage;
            string result="";

            Console.Write("Sınav1: ");
            exam1 = int.Parse(Console.ReadLine());

            Console.Write("Sınav2: ");
            exam2 = int.Parse(Console.ReadLine());

            Console.Write("Sınav3: ");
            exam3 = int.Parse(Console.ReadLine());


            avarage = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine($"Sınavların ortalaması: {avarage}");


            if (avarage > 0 & avarage <= 50)
            { 
                result = "vasat";
            }
            if (avarage > 50 & avarage <= 70)
            { 
                result = "orta"; 
            }
            if (avarage > 70 & avarage <= 80)
            { 
                result = "iyi"; 
            }
            if (avarage > 80)
            { 
                result = "çok iyi";
            }

            Console.WriteLine($"Sonuç: {result}");
            

            string city;
            Console.Write("Bir şehir adı giriniz: ");
            city = Console.ReadLine();

            if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            {
                Console.WriteLine("Şehir mevcut");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil");
            }

            

            string userName;
            Console.Write("Bir kullanıcı adı girin: ");
            userName = Console.ReadLine();

            if (userName == "admin")
            {
                Console.WriteLine("Hoş geldiniz");
            }
            else
            { 
                Console.WriteLine("yanlış kullanıcı adı");
            }

                Console.Read();
            */
            #endregion

            #region Mod işlemleri
            /*
            int number = 26;
            int result = number % 5;
                   
            Console.WriteLine(result);



            Console.Write("Lütfen 1. sayıyı giriniz: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen2.sayıyı giriniz: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 % number2;

            Console.WriteLine($"1.sayının 2.sayıya bölümünden kalan: {result}");
            


            Console.Write("Lütfen sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }
            */
            #endregion

            #region Char
            /*
            char team;
            Console.Write("Takımın başharfi: ");
            team =char.Parse(Console.ReadLine());

            if (team == 'b'|team=='B')
            {
                Console.WriteLine("Beşiktaş");
            }
            if (team == 'f' | team == 'F')
            {
                Console.WriteLine("fenerbahçe");
            }
            if (team == 'g' | team == 'f')
            {
                Console.WriteLine("galatasaray");
            }
            */
            #endregion

            #region Örnek Proje Uygulaması
            
            /*

            Console.WriteLine("C# Eğitim Kampı Restorant\n");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("--------------------------\n");
            string menuItem;
            Console.WriteLine("Detayını görmek istediğiniz değeri seçiniz: ");
            menuItem= Console.ReadLine();

            if(menuItem=="1")
            {               
                Console.WriteLine("\n-------Ana Yemekler-------");
                Console.WriteLine("1-Köri Soslu Tavuk\n2-Kızartma Tabağı\n3-Fasülyeli Pilav\n4-Fırında Somon\n5-Patlıcan Musakka");
            }
            if (menuItem == "2")
            {
                Console.WriteLine("\n---------Çorbalar---------");
                Console.WriteLine("1-Mercimek Çorbası\n2-Ezogelin Çorba");
            }
            if (menuItem == "3")
            {
                Console.WriteLine("\n-------Pizzalar-------");
                Console.WriteLine("1-Tavuklu Pizza\n2-Sucuklu Pizza\n3-Kaşarlı Pizza");
            }
            if (menuItem == "4")
            {
                Console.WriteLine("\n-------İçecekler-------");
                Console.WriteLine("1-Kola\n2-Ayran\n3-Su");
            }
            if (menuItem == "1")
            {
                Console.WriteLine("\n-------Tatlılar-------");
                Console.WriteLine("1-Sütlaç\n2-puding\n3-Triliçe\n4-Baklava");
            }
            */

            Console.Read();
            #endregion

            #region Switch Case

            #endregion
        }
    }
}
