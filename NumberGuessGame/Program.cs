using System;
using System.Timers;
namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 10;
            var rand = new Random();
            int sayi = rand.Next(1,100);
            int tahminHakki = 10;
            int sayac = 0;
            System.Console.WriteLine("\n\n***********************************");
            do
            {
                sayac++;
                tahminHakki--;
                System.Console.Write("1 ile 100 arasında tahmin ediniz: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                if(tahmin<sayi)
                {
                    System.Console.WriteLine($"Daha büyük bir sayı girin.\nKalan Tahmin Hakkı: {tahminHakki}");
                    score--;
                }
                else if(sayi==tahmin){
                    System.Console.WriteLine($"Tebrikler\nSayı: {sayi}\n{sayac} defada bildiniz.");
                    System.Console.WriteLine($"Skor: {score}");
                    break;
                }
                else
                {
                    System.Console.WriteLine($"Daha küçük bir sayı girin.\nKalan Tahmin Hakkı: {tahminHakki}");
                    score--;
                }
                
            } while (tahminHakki>0);
            
        }
    }
}
