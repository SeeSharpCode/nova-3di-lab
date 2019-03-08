using Nova3diLab.Model;
using Nova3diLab.Model.Texture;
using System;
using System.Collections.Generic;

namespace Nova3diLab.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writing file...");

            GeneralHeader generalHeader = new GeneralHeader
            {
                Name = "box",
                LodCount = 1,
                Sphere = 0x0001BB67,
                Radius = 0x0001BB67,
                TextureCount = 1,
            };

            DF2Model model = new DF2Model();
            model.GeneralHeader = generalHeader;
           // model.Textures = new DF2Texture[] { new DF2Texture() };
            model.SaveToFile(@"G:\Games\Novalogic\Delta Force 2\Tools\Modding\3di\Box (Tutorial)\test.3di");

            Console.WriteLine("Finished!");

            Console.Read();
        }
    }
}
