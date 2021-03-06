﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nova3diLab.Mqo
{
    internal static class MatchExtensions
    {
        internal static MqoObject ToMqoObject(this Match match)
        {
            var objectContent = match.Value;

            var vertexMatches = Regex.Matches(objectContent, @"\t\t(-?[\d.]+) (-?[\d.]+) (-?[\d.]+)");
            var vertices = vertexMatches.Cast<Match>().Select(vertexMatch => vertexMatch.ToMqoVertex()).ToList();

            var faceMatches = Regex.Matches(objectContent, @"V\((\d+) (\d+) (\d+)[\s\d]*\) M\((\d+)\) UV\(([\d.]+) ([\d.]+) ([\d.]+) ([\d.]+) ([\d.]+) ([\d.]+)[\s\d.]*\)");
            var faces = faceMatches.Cast<Match>().Select(faceMatch => faceMatch.ToMqoFace()).ToList();

            return new MqoObject(vertices, faces);
        }

        internal static MqoVertex ToMqoVertex(this Match match)
        {
            var x = Convert.ToDouble(match.Groups[1].Value);
            var y = Convert.ToDouble(match.Groups[2].Value);
            var z = Convert.ToDouble(match.Groups[3].Value);
            return new MqoVertex(x, y, z);
        }

        internal static MqoFace ToMqoFace(this Match match)
        {
            var vertexIndices = new List<int>
            {
                Convert.ToInt32(match.Groups[1].Value),
                Convert.ToInt32(match.Groups[2].Value),
                Convert.ToInt32(match.Groups[3].Value)
            };

            var materialIndex = Convert.ToInt32(match.Groups[4].Value);

            var uvCoordinates = new List<Tuple<double, double>>
            {
                Tuple.Create(Convert.ToDouble(match.Groups[5].Value), Convert.ToDouble(match.Groups[6].Value)),
                Tuple.Create(Convert.ToDouble(match.Groups[7].Value), Convert.ToDouble(match.Groups[8].Value)),
                Tuple.Create(Convert.ToDouble(match.Groups[9].Value), Convert.ToDouble(match.Groups[10].Value)),
            };

            return new MqoFace(vertexIndices, uvCoordinates, materialIndex);
        }
    }
}
