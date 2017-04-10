using System.Collections.Generic;

namespace Nova3diLab.Model.Lod
{
    internal class VertexComparer : IEqualityComparer<Vertex>
    {
        public bool Equals(Vertex x, Vertex y)
        {
            return x.X == y.X && x.Y == y.Y && x.Z == y.Z;
        }

        public int GetHashCode(Vertex obj)
        {
            return obj.X + obj.Y + obj.Z;
        }
    }
}
