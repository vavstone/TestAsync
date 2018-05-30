using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestAsyncConsole
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Waiting for greeting...");
            Console.WriteLine(GetHelloString());
            Console.WriteLine("It's too late!");
            Console.Read();
        }

        static string GetHelloString()
        {
            Thread.Sleep(1000);
            return "Hello, App!";
        }
    }
}
