using System;
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

        public MqoModel(List<MqoVertex> vertices, List<MqoFace> faces)
        {
            Vertices = vertices;
            Faces = faces;
        }

        public static MqoModel Load(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);

            var vertexMatches = Regex.Matches(fileContent, @"\t\t(-?[\d.]+) (-?[\d.]+) (-?[\d.]+)");
            var vertices = vertexMatches.Cast<Match>().ToList()
                .Select(match => new MqoVertex(
                    Convert.ToDouble(match.Groups[1].Value),
                    Convert.ToDouble(match.Groups[2].Value),
                    Convert.ToDouble(match.Groups[3].Value)
                ))
                .ToList();

            var faceMatches = Regex.Matches(fileContent, @"(\d) V\((\d+) (\d+) (\d+)\) M\((\d+)\) UV\(([\d.]+) ([\d.]+) ([\d.]+) ([\d.]+) ([\d.]+) ([\d.]+)\)");
            var faces = faceMatches.Cast<Match>().ToList()
                .Select(match => new MqoFace(
                    new List<int> {
                        Convert.ToInt32(match.Groups[2].Value),
                        Convert.ToInt32(match.Groups[3].Value),
                        Convert.ToInt32(match.Groups[4].Value)
                    },
                    new List<Tuple<double, double>> {
                        Tuple.Create(Convert.ToDouble(match.Groups[6].Value), Convert.ToDouble(match.Groups[7].Value)),
                        Tuple.Create(Convert.ToDouble(match.Groups[8].Value), Convert.ToDouble(match.Groups[9].Value)),
                        Tuple.Create(Convert.ToDouble(match.Groups[10].Value), Convert.ToDouble(match.Groups[11].Value)),
                    },
                    Convert.ToInt32(match.Groups[5].Value)
                ))
                .ToList();

            return new MqoModel(vertices, faces);
        }
    }
}