using System;

namespace FindPercentage
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("sayı: ");
            double number = double.Parse(Console.ReadLine());
            System.Console.Write("Yüzde kaçı: ");
            double percent = double.Parse(Console.ReadLine());
            double result = number * percent / 100;
            System.Console.WriteLine($"{number} sayısının %{percent}'si {result}'dir");
        }
    }
}
