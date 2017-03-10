using Nova3diLab.Parser;
using System;

namespace Nova3diLab.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelFileParser parser = new ModelFileParser("sample-files/laptop.3di");

            Console.WriteLine(parser.Parse());
            Console.Read();
        }
    }
}
