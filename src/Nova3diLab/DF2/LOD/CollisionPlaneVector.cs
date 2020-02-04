using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class CollisionPlaneVector
    {
        public short X { get; set; }
        public short Z { get; set; }
        public short Y { get; set; }
        public short Distance { get; set; }

        public CollisionPlaneVector(short x, short y, short z, short distance)
        {
            X = x;
            Y = y;
            Z = z;
            Distance = distance;
        }

        public byte[] Serialize()
        {
            using (var buffer = new MemoryStream())
            using (var writer = new BinaryWriter(buffer))
            {
                writer.Write(X);
                writer.Write(Y);
                writer.Write(Z);
                writer.Write(Distance);
                return buffer.ToArray();
            }
        }
    }
}