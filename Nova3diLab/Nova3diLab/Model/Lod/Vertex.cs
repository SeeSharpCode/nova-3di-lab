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
    }
}