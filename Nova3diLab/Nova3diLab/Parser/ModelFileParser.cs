using Nova3diLab.Model;
using Nova3diLab.Utility;
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
            using (FileStream fileStream = new FileStream(_fileName, FileMode.Open))
            using (BinaryReader _binaryReader = new BinaryReader(fileStream))
            {
                _binaryReader.BaseStream.Seek(3, SeekOrigin.Begin);
                Model3D model = new Model3D()
                {
                    GeneralHeader = new GeneralHeader() { Name = _binaryReader.ReadCleanedString() }
                };

                return model;
            }
        }
    }
}
