using System;
using System.Collections.Generic;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            var prime = new Prime(sayi);
            prime.DivisorNumberList();

            
        }
    }
    public class Prime
    {
        public Prime(int number)
        {
            this.ControlList = new List<int>();
            if(IsPrime(number))
            {
                System.Console.WriteLine($"{number} sayısı asaldır.");
            }
            else
            {
                System.Console.WriteLine($"{number} sayısı asal değildir.");
            }
        }
        private List<int> ControlList { get; set; }
        private int Control { get; set; }
        private bool IsPrime(int number) 
        {
            Control = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    ControlList.Add(i);
                    Control++;
                }
            }
            if(Control==2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DivisorNumberList()
        {
            foreach(var item in ControlList)
            {
                System.Console.Write($"Çarpanları: {item} ");
            }
        }
    }

}
