using System;

namespace FirstApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(0x00A);
            Console.WriteLine("\t Привет мир");
            Console.WriteLine("\t Мне 22 лет");
            Console.WriteLine("\t MyName name is \n Jane");
            Console.WriteLine('\u0040');
            Console.WriteLine('\x23');
            Console.ReadKey();
        }
    }

}