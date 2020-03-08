using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nova3diLab.Mqo
{
    public class MqoModel
    {
        public List<MqoVertex> Vertices { get; }
        public List<MqoFace> Faces { get; }
        public List<string> TextureNames { get; }

        public MqoModel(List<MqoVertex> vertices, List<MqoFace> faces, List<string> textureNames)
        {
            Vertices = vertices;
            Faces = faces;
            TextureNames = textureNames;
        }

        public static MqoModel Load(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);

            var vertexMatches = Regex.Matches(fileContent, @"\t\t(-?[\d.]+) (-?[\d.]+) (-?[\d.]+)");
            var vertices = vertexMatches.Cast<Match>().Select(match => match.ToMqoVertex()).ToList();

            var faceMatches = Regex.Matches(fileContent, @"(\d) V\((\d+) (\d+) (\d+)\) M\((\d+)\) UV\(([\d.]+) ([\d.]+) ([\d.]+) ([\d.]+) ([\d.]+) ([\d.]+)\)");
            var faces = faceMatches.Cast<Match>().Select(match => match.ToMqoFace()).ToList();

            var textureMatches = Regex.Matches(fileContent, @"tex\(.{1}(.*).{1}\)");
            var textureNames = textureMatches.Cast<Match>().Select(match => match.Groups[1].Value).ToList();

            return new MqoModel(vertices, faces, textureNames);
        }
    }
}