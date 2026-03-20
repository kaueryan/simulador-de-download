using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimuladordeDownloads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread d1 = new Thread(() => Download("Arquivo 1"));
            Thread d2 = new Thread(() => Download("Arquivo 2"));
            Thread d3 = new Thread(() => Download("Arquivo 3"));

            d1.Start();
            d2.Start();
            d3.Start();

            d1.Join();
            d2.Join();
            d3.Join();

        }

        static void Download(string Arquivo)
        {
            for (int i = 0; i <= 100; i += 10)
            {
                Console.WriteLine($"{Arquivo}: {i}%");
                Thread.Sleep(200);
            }

            Console.WriteLine($"{Arquivo} finalizado!");
        }
    }
}
