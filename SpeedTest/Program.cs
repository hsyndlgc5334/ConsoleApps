using System;

namespace SpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const string tempfile = "tempfile.tmp";
            System.Net.WebClient webClient = new System.Net.WebClient();

            Console.WriteLine("Downloading file....");

            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            webClient.DownloadFile("http://dl.google.com/googletalk/googletalk-setup.exe", tempfile);
            sw.Stop();

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(tempfile);
            long speed = fileInfo.Length / sw.Elapsed.Seconds;

            Console.WriteLine("Download duration: {0}", sw.Elapsed);
            Console.WriteLine("File size: {0}", fileInfo.Length.ToString("N0"));
            Console.WriteLine("Speed: {0} bps ", speed.ToString("N0"));

            Console.WriteLine("Press any key to continue...");
        }
    }
}
