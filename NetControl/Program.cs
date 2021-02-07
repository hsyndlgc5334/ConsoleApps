using System;
using System.Net;
using System.Net.NetworkInformation;

namespace NetControl
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ping ping = new Ping();
            PingReply pingReply = ping.Send(IPAddress.Parse("93.89.238.98"));
            System.Console.WriteLine($"Ping: {pingReply.RoundtripTime} ms");
            System.Console.WriteLine($"Pinglenen Adres: {pingReply.Address}");
            if(pingReply.Status==IPStatus.Success)
            {
                System.Console.WriteLine("İnternet bağlantısı var");
            }
            else
            {
                System.Console.WriteLine("İnternet bağlantısı yok");
            }
        }
    }
}
