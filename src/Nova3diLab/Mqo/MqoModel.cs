using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nova3diLab.Mqo
{
    public class MqoModel
    {
        public List<MqoObject> Objects { get; }
        public List<string> TextureNames { get;  }
        

        public MqoModel(List<MqoObject> objects, List<string> textureNames)
        {
            Objects = objects;
            TextureNames = textureNames;
        }

        public static MqoModel Load(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);

            var objectMatches = Regex.Matches(fileContent, @"Object(?:[^}]*[}]){3}");
            var objects = objectMatches.Cast<Match>().Select(match => match.ToMqoObject()).ToList();

            var textureMatches = Regex.Matches(fileContent, @"tex\(.{1}(.*).{1}\)");
            var textureNames = textureMatches.Cast<Match>().Select(textureMatch => textureMatch.Groups[1].Value).ToList();

            return new MqoModel(objects, textureNames);
        }
    }
}