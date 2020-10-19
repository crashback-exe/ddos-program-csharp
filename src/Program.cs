using System;
using System.Threading;


namespace csharp_hello_world
{
    class Program
    {

        private static int percentage = 0;


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            Console.Write("Insert ip to DDoS: ");
            string ip = Console.ReadLine();

            Console.Write($"\nDDoS Attacking {ip}");
            

            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);

            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Write("\b");
            Thread.Sleep(1000);

            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(5000);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNote: This attack will take about 10 seconds");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for(int i = 0; i<11; i++){

                Console.WriteLine($"DDoS attack {percentage}%");
                percentage += 10;
                Thread.Sleep(1000);
                
                }
            Thread.Sleep(10000);
            Console.WriteLine($"DDoS to {ip} complete");
        }
    }
}
