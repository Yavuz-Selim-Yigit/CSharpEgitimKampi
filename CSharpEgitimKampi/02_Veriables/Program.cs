using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double
            /*
            double number;

            number = 4.85;
            Console.WriteLine(number);
            
            

            Console.WriteLine("FİYAT LİSTESİ\n");

            double applePrice, orangePrice, strawberrtPrice, patatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberrtPrice = 45;
            patatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine($"Elma Birim Fiyat: {applePrice}TL\nPortakal Birim Fiyatı: {orangePrice}TL\nÇilek Birim Fiyat: {strawberrtPrice}TL\nPatates Birim Fiyatı: {patatoPrice}TL\nDomates Birim Fiyatı: {tomatoPrice}TL\n");

            double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            patatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawberryTotalPrice = strawberrtPrice * strawberryGram;
            double patatoTotalPrice = patatoPrice * patatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;

            Console.WriteLine($"Alınan ürün: Elma\n     Birim fiyat: {applePrice}TL\n          Gramaj: {appleGram}gr\n               Toplam Fiyat: {appleTotalPrice}TL\n");
            Console.WriteLine($"Alınan ürün: Portakal\n     Birim fiyat: {orangePrice}TL\n          Gramaj: {orangeGram}gr\n               Toplam Fiyat: {orangeTotalPrice}TL\n");
            Console.WriteLine($"Alınan ürün: Çilek\n     Birim fiyat: {strawberrtPrice}TL\n          Gramaj: {strawberryGram}gr\n               Toplam Fiyat: {strawberryTotalPrice}TL\n");
            Console.WriteLine($"Alınan ürün: Patates\n     Birim fiyat: {patatoPrice}TL\n          Gramaj: {patatoGram}gr\n               Toplam Fiyat: {patatoTotalPrice}TL\n");
            Console.WriteLine($"Alınan ürün: Domates\n     Birim fiyat: {tomatoPrice}TL\n          Gramaj: {tomatoGram}gr\n               Toplam Fiyat: {tomatoTotalPrice}TL\n");

            double shoppingTotalPrice = appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+patatoTotalPrice+tomatoTotalPrice;
            Console.WriteLine($"\nToplam Tutar: {shoppingTotalPrice}TL\n");
            
            */

            #endregion

            #region Char
            /*
            char symbol;
            symbol = 'Y';

            Console.WriteLine(symbol);

             */
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            /*
            Console.WriteLine("CSharp Hava Yolları Yolcu Bilgisi\n");

            string passergerName, passergerSurname, passergerDistrict, passergerCity, passergerAge, passergerID;

            Console.Write("Yolcu Adı:");
            passergerName = Console.ReadLine();
            Console.Write("Yoldu Soyadı: ");
            passergerSurname = Console.ReadLine();

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Adı: {passergerName}\tSoyadı: {passergerSurname}\n");

            Console.Write("Yolcu Yaşı:");
            passergerAge = Console.ReadLine();
            Console.Write("TC No: ");
            passergerID = Console.ReadLine();

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Yaş: {passergerAge}\t\tTC No: {passergerID}\n");

            Console.Write("İlçe Bilgisi:");
            passergerDistrict = Console.ReadLine();
            Console.Write("Şehir Bilgisi: ");
            passergerCity = Console.ReadLine();

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"İlçe: {passergerDistrict}\t\tŞehir: {passergerCity}\n");

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Yolcu Bilgisi");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Adı: {passergerName}\tSoyadı: {passergerSurname}\n");
            Console.WriteLine($"Yaş: {passergerAge}\t\t\tTC No: {passergerID}\n");
            Console.WriteLine($"İlçe: {passergerDistrict}\t\tŞehir: {passergerCity}\n");
            Console.WriteLine("---------------------------------------------------");
            */

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            /*
            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız Ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız Bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız Sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız Televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = (shoesCount * shoesPrice) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvCount * tvPrice);


            Console.WriteLine($"Toplam ücret: {totalPrice}");

            */
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            /*

            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine($"\nSınav Ortalamanız: {result}\n");
            */

            #endregion

            #region Klavyeden Karakter Girişleri

            /*
            
            char gender;
            Console.Write("k = Kız\te = Erkek\nLütfen Cinsiyet Seçiniz: ");
            
            gender=char.Parse(Console.ReadLine());
            Console.Write($"Seçtiğiniz Cinsiyet: {gender}");

            */

            #endregion

            Console.Read();

        }
    }
}
