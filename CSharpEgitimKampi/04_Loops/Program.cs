﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For
            /*
            for (int i = 0; i < 5; i++) 
            {
            Console.WriteLine("C# Eğitim Kampı");
            }
            

            for (int i = 1; i <= 20; i++)
            { Console.WriteLine(i); }

            

            for (int i = 3; i<=50; i+=3) 
            { 
            Console.WriteLine(i); 
            }

            


            Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            int finishValue=int.Parse(Console.ReadLine());
            for (int i = 0; i <=finishValue; i++)
            {  
                Console.WriteLine("Yaşasın Cumhuriyet");
            }

            */
            #endregion

            #region For Döngüsü ile Karar Yapıları
            /*
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            

            int totalValue = 0;
            for (int i = 0; i <= 10; i++)
            {
                totalValue += i;
                Console.WriteLine($"totalValue = {totalValue}");
            }
            Console.WriteLine($"-----------------\nToplam: {totalValue}");

            

            int count = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 7 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"7ye bölünen sayısı {count}");

            

            int bacterium = 1;
            for (int i = 1; i <= 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine($"{i}. saatin sonunda {bacterium} tane bakteri");
            }
            
             
            */


            #endregion

            #region While

            /*
            int i = 1;
            while (i<=10)
            {
                Console.WriteLine("Merhaba Dünya!");
                i++;
            }
            

            int i = 1;
            while (i <= 10)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            

            int i = 1;
            int sum = 0;
            while (i <= 10)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);

            */

            #endregion

            #region Örnek Sınav Sorusu
            /*
            Console.Write("Sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundred, sum;

            hundred = number / 100;
            ones = number % 10;
            tens = (number % 100)/10;

            Console.Write($"Birler basamağı: {ones}\nOnlar basamağı: {tens}\nYüzler basamağı: {hundred}");
            */
            #endregion

            Console.Read();
        }
    }
}
