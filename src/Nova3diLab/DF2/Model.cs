using Nova3diLab.Model.Lod;
using Nova3diLab.Utility;
using System.Collections.Generic;
using System.IO;

namespace Nova3diLab.DF2
{
    public class Model
    {
        public ModelHeader Header { get; set; }
        public List<Texture> Textures;
        public List<ModelLod> Lods;

        public Model(string name, List<Texture> textures, List<Vertex> vertices, List<Face> faces)
        {
            Header = new ModelHeader(name, vertices.CalculateBoundingSphereRadius(), textures.Count);
            Textures = textures;
            Lods = new List<ModelLod> { new ModelLod(vertices, faces, textures) };
        }

        public void SaveToFile(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                Header.Serialize(writer);
                Textures.ForEach(texture => texture.Serialize(writer));
                Lods.ForEach(lod => lod.Serialize(writer));
            }
        }
    }
}
