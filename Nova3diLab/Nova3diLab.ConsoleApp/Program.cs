using System;

namespace Nova3diLab.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ModelFileParser.Parse("sample-files/laptop.3di"));
            Console.Read();
        }
    }
}
