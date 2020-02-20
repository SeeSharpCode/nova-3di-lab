using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nova3diLab.MQO
{
    public class MqoObject
    {
        public List<Vertex> Vertices { get; set; }

        public static MqoObject Load(string filePath)
        {
            List<string> lines = File.ReadAllLines(filePath).Select(line => line.Trim()).ToList();

            var vertexCount = Convert.ToInt32(
                lines.Find(line => line.Contains("vertex")).Split(' ')[1]
            );

            var vertexStart = lines.FindIndex(line => line.Contains("vertex"));
            var vertices = lines.GetRange(vertexStart + 1, vertexCount)
                .Select(line => line.Split(' ').Select(coord => Convert.ToDouble(coord)).ToList())
                .Select(coords => new Vertex(coords[0], coords[1], coords[2]))
                .ToList();

            return null;
        }
    }
}