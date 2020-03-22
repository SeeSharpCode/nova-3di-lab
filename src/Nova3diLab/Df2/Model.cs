using Nova3diLab.Df2.Lod;
using System.Collections.Generic;
using System.IO;

namespace Nova3diLab.Df2
{
    public class Model : IModelSerializable
    {
        public ModelHeader Header { get; }
        public List<Texture> Textures { get; }
        public List<ModelLod> Lods { get; }

        public Model(string name, List<Texture> textures, List<Vertex> vertices, List<Face> faces)
            : this(name, textures, vertices, faces, new List<CollisionPlaneVector>(), new List<CollisionVolume>())
        {
        }

        public Model(string name, List<Texture> textures, List<Vertex> vertices, List<Face> faces, List<CollisionPlaneVector> collisionPlanes, List<CollisionVolume> collisionVolumes)
        {
            Header = new ModelHeader(name, vertices.CalculateBoundingSphereRadius(), textures.Count);
            Textures = textures;
            Lods = new List<ModelLod> { new ModelLod(vertices, faces, textures, collisionPlanes, collisionVolumes) };
        }

        public void SaveToFile(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                Serialize(writer);
            }
        }

        public void Serialize(BinaryWriter writer)
        {
            Header.Serialize(writer);
            Textures.ForEach(texture => texture.Serialize(writer));
            Lods.ForEach(lod => lod.Serialize(writer));
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new System.NotImplementedException();
        }
    }
}
