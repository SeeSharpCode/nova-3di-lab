using Nova3diLab.Model.Bitmap;
using Nova3diLab.Model.Lod;
using System.Collections.Generic;

namespace Nova3diLab.Model
{
    public class Model3D
    {
        public GeneralHeader GeneralHeader { get; set; }
        public List<ModelBitmap> Bitmaps { get; set; }
        public List<ModelLod> Lods { get; set; }

        public Model3D()
        {
            GeneralHeader = new GeneralHeader();
            Bitmaps = new List<ModelBitmap>();
            Lods = new List<ModelLod>();
        }

        public Model3D FromObj(string objFile)
        {
            Model3D model = new Model3D();



            return new Model3D();
        }
    }
}
