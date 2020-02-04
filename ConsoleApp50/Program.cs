
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            sayi = Sayigir();
            YazıylaYaz(sayi);
            Console.ReadLine();
        }
        static int Sayigir()
        {
            string s;
            Console.WriteLine("Bir Sayı gir");
            s = Console.ReadLine();

            int b = int.Parse(s);
            return b;
        }
        static void YazıylaYaz(int sy)
        {
            if (sy < 10)
                birlik(sy);
            else if (sy < 10000)
            {
                yüzlük((sy % 1000) / 100);
                onluk((sy % 100) / 10);
                birlik((sy % 10));

            }
            if (sy == 0) Console.WriteLine("Sıfır");
        }
        static void birlik(int b)
        {
            switch (b)
            {
                case 9: Console.Write("Dokuz"); break;
                case 8: Console.Write("Sekiz"); break;
                case 7: Console.Write("Yedi"); break;
                case 6: Console.Write("Altı"); break;
                case 5: Console.Write("Beş"); break;
                case 4: Console.Write("Dört"); break;
                case 3: Console.Write("Üç"); break;
                case 2: Console.Write("İki"); break;
                case 1: Console.Write("Bir"); break;
                default:
                    break;
            }
        }

        static void yüzlük(int b)
        {
            switch (b)
            {
                case 9: Console.Write("Dokuzyüz "); break;
                case 8: Console.Write("Sekizyüz "); break;
                case 7: Console.Write("Yediyüz "); break;
                case 6: Console.Write("Altıyüz "); break;
                case 5: Console.Write("Beşyüz "); break;
                case 4: Console.Write("Dörtyüz "); break;
                case 3: Console.Write("Üçyüz "); break;
                case 2: Console.Write("İkiyüz "); break;
                case 1: Console.Write("Yüz "); break;
                default:
                    break;
            }
        }
        static void onluk(int b)
        {
            switch (b)
            {
                case 9: Console.Write("Doksan "); break;
                case 8: Console.Write("Seksen "); break;
                case 7: Console.Write("Yetmiş "); break;
                case 6: Console.Write("Altmış "); break;
                case 5: Console.Write("Elli "); break;
                case 4: Console.Write("Kırk "); break;
                case 3: Console.Write("Otuz "); break;
                case 2: Console.Write("Yirmi "); break;
                case 1: Console.Write("On "); break;
                default:
                    break;
            }
        }


    }
}
