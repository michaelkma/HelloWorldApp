using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This change will trigger a build on TeamCity!");
            Console.Read();
        }
    }
}
