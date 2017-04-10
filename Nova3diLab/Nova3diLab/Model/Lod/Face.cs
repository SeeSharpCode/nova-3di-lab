using System;
using System.Collections.Generic;
using FileFormatWavefront.Model;

namespace Nova3diLab.Model.Lod
{
    public class Face
    {
        public Int16 VertexIndex { get; set; }
        public Int16 NormalIndex { get; set; }
        public List<Tuple<int, Int16>> UVCoordinates { get; set; }

        // TODO: dictionary
        public Int16 Vertex1Index { get; set; }
        public Int16 Vertex2Index { get; set; }
        public Int16 Vertex3Index { get; set; }

        // TODO: dictionary
        public Int16 Normal1Index { get; set; }
        public Int16 Normal2Index { get; set; }
        public Int16 Normal3Index { get; set; }

        // Negative value of distance from face to zero point
        public int Distance { get; set; }

        public int XMin { get; set; }
        public int XMax { get; set; }
        public int YMin { get; set; }
        public int YMax { get; set; }
        public int ZMin { get; set; }
        public int ZMax { get; set; }

        public int MaterialIndex { get; set; }

        internal static Face FromObj(FileFormatWavefront.Model.Face Face face)
        {

        }
    }
}