using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================== Homework 1 (a) ===============");
            int PriceIphone = 1000;
            double ProcentSells = 50;

            double DiscountAmount = (ProcentSells / 100) * PriceIphone;

            double LastPriveIphone = PriceIphone - DiscountAmount;


            Console.WriteLine($"Цiна Айфону: {PriceIphone}");
            Console.WriteLine($"Знижка: {ProcentSells}");
            Console.WriteLine($"Велечина знижки: {DiscountAmount}");
            Console.WriteLine($"Цена пiсля знижки: {LastPriveIphone}");


            Console.WriteLine("================ Homework 2 (b) ================");

            int Hour = 1;
            int Minutes = 30;
            int Seconds = 20;

            int FullTimeInSeconds = (Hour * 3600) + (Minutes * 60) + Seconds;
            Console.WriteLine($"-Iнформацiя: \n-Час - {Hour} час \n-Мiнути - {Minutes} \n-Секунди - {Seconds}");

            Console.WriteLine($"Загальний час у секундах: {FullTimeInSeconds}");

            Console.WriteLine("================ Homework 3 (v) ================");
            string NameOfBook = "Институт";
            string Autor = "Стивен Кинг";
            int YearOfDrop = 2023;
            int Price = 60;

            Console.WriteLine($"Параметры книги: \n-Название книги: {NameOfBook}\n-Автор: {Autor}\n-Год выпуска:{YearOfDrop}\n-Цена:{Price}$");

            Console.ReadLine();
        }
    }
}
