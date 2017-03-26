using System.Collections.Generic;

namespace Nova3diLab.Model.Lod
{
    public class ModelLod
    {
        public LodHeader Header { get; set; }
        public List<Vertex> Vertices { get; set; }
        public List<Normal> Normals { get; set; }
        public List<Face> Faces { get; set; }
        public List<SubObject> SubObjects { get; set; }
        public List<PartAnimation> PartAnimations { get; set; }
        public List<CollisionPlaneVector> CollisionPlaneVectors { get; set; }
        public List<CollisionVolume> CollisionVolumes { get; set; }
        public List<Material> Materials { get; set; }

        public ModelLod()
        {
            Header = new LodHeader();
            Vertices = new List<Vertex>();
            Normals = new List<Normal>();
            Faces = new List<Face>();
            SubObjects = new List<SubObject>();
            PartAnimations = new List<PartAnimation>();
            CollisionPlaneVectors = new List<CollisionPlaneVector>();
            CollisionVolumes = new List<CollisionVolume>();
            Materials = new List<Material>();
        }
    }
}
