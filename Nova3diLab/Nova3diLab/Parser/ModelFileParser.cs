using AutoMapper;
using BeeSchema;
using Nova3diLab.Model;
using System.IO;
using System.Reflection;
using System;
using System.Text;

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
            Model3D model = new Model3D();

            foreach (PropertyInfo modelProperty in typeof(Model3D).GetProperties())
            {
                MethodInfo method = typeof(ModelFileParser).GetMethod("ConfigureMapping", BindingFlags.NonPublic | BindingFlags.Instance);
                MethodInfo generic = method.MakeGenericMethod(modelProperty.PropertyType);
                generic.Invoke(this, null);
            }

            GeneralHeader part = new GeneralHeader();

            Mapper.Map(resultCollection, part);

            model.GeneralHeader = part;

            return model;
        }

        private void ConfigureMapping<T>()
        {
            Type type = typeof(T);

            Mapper.Initialize(config =>
            {
                IMappingExpression<ResultCollection, T> mappingExpression = config.CreateMap<ResultCollection, T>();

                foreach (PropertyInfo property in type.GetProperties())
                {
                    if (property.PropertyType == typeof(string))
                        mappingExpression.ForMember(property.Name, option => option.MapFrom(source => Encoding.Default.GetString(source[type.Name].Children[property.Name])));
                    else
                        mappingExpression.ForMember(property.Name, option => option.MapFrom(source => source[type.Name].Children[property.Name]));
                }
            });
        }

        private void ConfigureMoreMapping()
        {
            Mapper.Initialize(config => {
                IMappingExpression<ResultCollection, Model3D> mappingExpression = config.CreateMap<ResultCollection, Model3D>();
            });
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
