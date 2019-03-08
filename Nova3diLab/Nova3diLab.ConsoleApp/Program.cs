using Nova3diLab.Model;
using Nova3diLab.ModelNew;
using System;

namespace Nova3diLab.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Model3D model = Model3D.FromWavefrontObj(@"D:\Games\Novalogic\Delta Force 2\Tools\Modding\3di\Cube\box object.obj", "test");

            GeneralHeader2 generalHeader2 = new GeneralHeader2();
            generalHeader2.Signature = FileVersion.V8;
            generalHeader2.Name = "aaa";
            generalHeader2.Write();
            
            Console.Read();
        }
    }
}
