using Nova3diLab.Model;
using Nova3diLab.Parser;
using System;

namespace Nova3diLab.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelFileParser parser = new ModelFileParser("sample-files/laptop.3di");

            Model3D model = parser.Parse();
            
            Console.WriteLine(model.GeneralHeader.Name);
            Console.WriteLine(model.GeneralHeader.Name.Length);
            Console.Read();
        }
    }
}
