using System;
using System.Collections.Generic;

namespace Nova3diLab.Mqo
{
    public class MqoFace
    {
        public List<int> VertexIndices { get; }
        public List<Tuple<double, double>> UVCoordinates { get; }
        public int MaterialIndex { get; set; }

        public MqoFace(List<int> vertexIndices, List<Tuple<double, double>> uvCoordinates, int materialIndex)
        {
            VertexIndices = vertexIndices;
            UVCoordinates = uvCoordinates;
            MaterialIndex = materialIndex;
        }
    }
}