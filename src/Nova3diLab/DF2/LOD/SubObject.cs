using Nova3diLab.Utility;
using System;
using System.Collections.Generic;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class SubObject : IModelSerializable
    {
        private List<Vertex> _vertices;

        public int FacesCount { get; set; }
        public int CollisionVolumesCount { get; set; }

        public SubObject(List<Vertex> vertices, int facesCount, int collisionVolumeCount)
        {
            _vertices = vertices;
            FacesCount = facesCount;
            CollisionVolumesCount = collisionVolumeCount;
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(0);
            writer.Write(_vertices.Count);
            writer.Write(0);
            writer.Write(FacesCount);
            writer.Write(0);
            writer.Write(FacesCount);
            writer.Write(0);
            writer.Write(CollisionVolumesCount);
            writer.Write(0);
            writer.Write(new byte[28]);
            writer.WriteFixedPoint(_vertices.GetXMin());
            writer.WriteFixedPoint(_vertices.GetXMax());
            writer.WriteFixedPoint(_vertices.GetYMin());
            writer.WriteFixedPoint(_vertices.GetYMax());
            writer.WriteFixedPoint(_vertices.GetZMin());
            writer.WriteFixedPoint(_vertices.GetZMax());
            writer.WriteFixedPoint(_vertices.GetXMedian());
            writer.WriteFixedPoint(_vertices.GetYMedian());
            writer.WriteFixedPoint(_vertices.GetZMedian());
            writer.WriteFixedPoint(_vertices.CalculateBoundingSphereRadius());
            writer.WriteFixedPoint(_vertices.CalculateBoundingSphereRadius());
            writer.WriteFixedPoint(_vertices.GetZLength());
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
