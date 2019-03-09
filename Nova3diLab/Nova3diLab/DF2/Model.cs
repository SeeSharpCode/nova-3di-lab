using Nova3diLab.Utility;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nova3diLab.DF2
{
    public class DF2Model
    {
        public GeneralHeader GeneralHeader { get; set; }
        // public List<Texture> Textures;

        public void SaveToFile(string fileName)
        {
            //using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create), Encoding.ASCII))
            //{
            //    
            //    GeneralHeader.WriteBinary(writer);
            //    Textures.ForEach(texture => texture.WriteBinary(writer));
            //}
        }
    }
}
