using System;

namespace Nova3diLab.Model.Lod
{
    public class Vertex
    {
        public ushort X { get; }
        public ushort Y { get; }
        public ushort Z { get; }

        internal Vertex(ushort x, ushort y, ushort z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        internal static Vertex FromObjVertex(FileFormatWavefront.Model.Vertex vertex)
        {
            ushort x = (ushort)Math.Round(vertex.x * 256);
            ushort y = (ushort)Math.Round(vertex.z * -256);
            ushort z = (ushort)Math.Round(vertex.y * 256);

            return new Model.Lod.Vertex(x, y, z);
        }
    }
}