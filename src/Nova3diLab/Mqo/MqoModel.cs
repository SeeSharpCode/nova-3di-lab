using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Nova3diLab.Mqo
{
    public class MqoModel
    {
        public List<MqoVertex> Vertices { get; set; }

        public static MqoModel Load(string filePath)
        {
            string fileContent = File.ReadAllText(filePath).

            var match = Regex.Match(fileContent, @"vertex\s(?<count>\d)\s{([\\r\\n\\t]*|(?<vertices>[\d\.\s-]*))*}");

            return null;
        }
    }
}