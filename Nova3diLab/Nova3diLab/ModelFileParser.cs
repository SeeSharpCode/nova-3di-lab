using BeeSchema;
using System.IO;
using System.Reflection;

namespace Nova3diLab
{
    public class ModelFileParser
    {
        public static string Parse(string fileName)
        {
            string schemaText;

            string[] things = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Nova3diLab.Schemas.df2.bee"))
            using (StreamReader reader = new StreamReader(resourceStream))
            {
                schemaText = reader.ReadToEnd();
            }

            Schema schema = Schema.FromText(schemaText);
            ResultCollection result = schema.Parse("sample-files/laptop.3di");


            return result["version"].Value.ToString();
        }

        private ResultCollection GetRawParsing
    }
}
