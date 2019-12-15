using Nancy.Hosting.Self;
using System;

namespace NancyStandalone
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new NancyHost(new Uri("http://localhost:80")))
            {
                host.Start();

                Console.WriteLine("NancyFX Stand alone test application.");
                Console.WriteLine("Press enter to exit the application");
                Console.WriteLine("HMMMMMM");
                Console.WriteLine("HMMMMMMX2");
                Console.ReadLine();
            }
        }
    }
}