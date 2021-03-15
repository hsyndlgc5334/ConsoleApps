using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     System.Console.Write("2'lik sayı girin: ");
            //     string s = Console.ReadLine();
            //     int b = Convert.ToInt32(s, 2);
            //     Console.WriteLine("Onluğa çevrilmiş hali = " + b);
            // }
            // catch (Exception e)
            // {
            //     System.Console.WriteLine(e.Message);
            // }
            var p = StringReverse("hüseyin");
            System.Console.WriteLine();
        }

        static string StringReverse(string number)
        {
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            string s =
            return s;
        }
    }
}
