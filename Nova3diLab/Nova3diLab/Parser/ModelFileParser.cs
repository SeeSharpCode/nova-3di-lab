using BeeSchema;
using Nova3diLab.Model;
using System.IO;
using System.Reflection;

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
            ResultCollection result = GetRawParsingResult();
            Model3D model = BuildModel(result);

            return model;
        }

        private ResultCollection GetRawParsingResult()
        {
            string schemaText;

            string[] things = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Nova3diLab.Schemas.df2.bee"))
            using (StreamReader reader = new StreamReader(resourceStream))
            {
                schemaText = reader.ReadToEnd();
            }

            Schema schema = Schema.FromText(schemaText);
            return schema.Parse(_fileName);
        }

        private Model3D BuildModel(ResultCollection resultCollection)
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
