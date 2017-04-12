using Nova3diLab.Model;
using System;

namespace Nova3diLab.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Model3D model = Model3D.FromWavefrontObj(@"C:\Users\jisatd1\Downloads\cube.obj", "test");
            
            Console.Read();
        }
    }
}
