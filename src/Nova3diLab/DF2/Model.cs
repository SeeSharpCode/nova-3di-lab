using Nova3diLab.Model.Lod;
using System;
using System.Collections.Generic;

namespace Nova3diLab.DF2
{
    public class Model
    {
        public ModelHeader Header { get; set; }
        public List<Texture> Textures;
        public List<ModelLod> Lods;

        public void SaveToFile(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
