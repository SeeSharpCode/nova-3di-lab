using Nova3diLab.Model.Lod;
using System.Collections.Generic;

namespace Nova3diLab.DF2
{
    public class Model : IBinaryFileStructure
    {
        public ModelHeader Header { get; set; }
        public List<Texture> Textures;
        public List<ModelLod> Lods;

        public Model(string name, List<Texture> textures, List<ModelLod> lods)
        {
            Header = new ModelHeader
            {
                Name = name,
                LodCount = lods.Count,
                TextureCount = textures.Count,
                BoundingSphereRadius = lods[0].CalcuateBoundingSphereRadius()
            };

            Textures = textures;
            Lods = lods;
        }

        public byte[] Serialize()
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize()
        {
            throw new System.NotImplementedException();
        }
    }
}
