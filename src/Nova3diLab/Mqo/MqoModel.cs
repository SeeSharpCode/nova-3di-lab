using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nova3diLab.Mqo
{
    public class MqoModel
    {
        public List<MqoVertex> Vertices { get; set; }

        public static MqoModel Load(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);

            var vertexMatches = Regex.Matches(fileContent, @"\t\t(-?[\d.]+) (-?[\d.]+) (-?[\d.]+)");
            var vertices = vertexMatches.Cast<Match>().ToList()
                .Select(match => new MqoVertex(
                    Convert.ToDouble(match.Groups[1].Value),
                    Convert.ToDouble(match.Groups[2].Value),
                    Convert.ToDouble(match.Groups[3].Value)
                ));

            return null;
        }
    }
}