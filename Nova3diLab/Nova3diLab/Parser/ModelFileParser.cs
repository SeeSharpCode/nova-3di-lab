using Nova3diLab.Model;
using System.IO;

namespace Nova3diLab.Parser
{
    public class ModelFileParser
    {
        private readonly string _fileName;

        public ModelFileParser(string fileName)
        {
            _fileName = fileName;
        }

        public Model3D Parse()
        {
            return null;
        }

        private byte GetModelVersion()
        {
            using (FileStream stream = new FileStream(_fileName, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(stream))
            {
                reader.BaseStream.Seek(3, SeekOrigin.Begin);
                return reader.ReadByte();
            }
        }
    }
}
