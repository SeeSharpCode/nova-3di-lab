using AutoMapper;
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

        public string Parse()
        {
            return GetRawParsingResult();
        }

        private Model3D MapRawParsingResultsToModel(ResultCollection resultCollection)
        {
            Model3D model = new Model3D();
            GeneralHeader generalHeader = new GeneralHeader();

            Mapper.Initialize(config => 
            {
                config.CreateMap<ResultCollection, Model3D>().ForMember(dest => dest.GeneralHeader.Version, option => option.MapFrom(source => source["version"].Value));
                config.CreateMap<ResultCollection, Model3D>().ForMember(dest => dest.Version, option => option.MapFrom(source => source["version"].Value));
            });

            Mapper.Map(resultCollection, model);

            return model;
        }

        private string GetRawParsingResult()
        {
            string schemaText;

            string[] things = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Nova3diLab.Schemas.df2.bee"))
            using (StreamReader reader = new StreamReader(resourceStream))
            {
                schemaText = reader.ReadToEnd();
            }

            Schema schema = Schema.FromText(schemaText);
            ResultCollection result = schema.Parse(_fileName);

            

            return model.Version;
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
