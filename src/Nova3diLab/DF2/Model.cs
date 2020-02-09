using Nova3diLab.Model.Lod;
using System.Collections.Generic;
using System.IO;

namespace Nova3diLab.DF2
{
    public class Model
    {
        public ModelHeader Header { get; set; }
        public List<Texture> Textures;
        public List<ModelLod> Lods;

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
