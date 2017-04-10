using FileFormatWavefront;
using FileFormatWavefront.Model;
using Nova3diLab.Model.Bitmap;
using Nova3diLab.Model.Lod;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nova3diLab.Model
{
    public class Model3D
    {
        public GeneralHeader GeneralHeader { get; set; }
        public List<ModelBitmap> Bitmaps { get; set; }
        public List<ModelLod> Lods { get; set; }

        public Model3D(GeneralHeader generalHeader, List<ModelBitmap> bitmaps, List<ModelLod> lods)
        {
            GeneralHeader = generalHeader;
            Bitmaps = bitmaps;
            Lods = lods;
        }

        public static Model3D FromObj(string objFile, string name)
        {
            Scene obj = FileFormatObj.Load(objFile, false).Model;

            ModelLod lod = new ModelLod()
            {
                Vertices = obj.Vertices.Select(vertex => Lod.Vertex.FromObjVertex(vertex)).Distinct(new VertexComparer()).ToList(),
            };

            GeneralHeader generalHeader = new GeneralHeader()
            {
                Name = name,
                LodCount = 1,
                Radius = lod.CalcuateRadius(),
                BitmapCount = obj.Materials.Count
            };

            using (BinaryWriter writer = new BinaryWriter(new FileStream($"{name}.3di", FileMode.Create)))
            {
                writer.Write(generalHeader.Radius);
                //// versioning
                //writer.Write("3DI".ToCharArray());
                //writer.Write((byte)8);
                //writer.Write(name.ToByteArray(8)); // name
                //writer.Write(0x000000010012FCD0); // gap
                //writer.Write(1); // LOD count

                //// LOD distances
                //writer.Write(0);
                //writer.Write(0);
                //writer.Write(0);
                //writer.Write(0);

                //// render codes
                //writer.Write("crng".ToCharArray());
                //writer.Write("crng".ToCharArray());
                //writer.Write("crng".ToCharArray());
                //writer.Write("crng".ToCharArray());

                //// gaps
                //writer.Write((Int64)0);
                //writer.Write((Int64)0);
                //writer.Write((Int64)0);
                //writer.Write((Int64)0);
                //writer.Write((Int64)0);

                //writer.Write((ushort)65152);
            }

            return new Model3D(generalHeader, new List<ModelBitmap>(), new List<ModelLod>());
        }
    }
}
