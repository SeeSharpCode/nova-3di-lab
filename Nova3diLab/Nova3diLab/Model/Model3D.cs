using AutoMapper;
using FileFormatWavefront;
using FileFormatWavefront.Model;
using Nova3diLab.Model.Bitmap;
using Nova3diLab.Model.Lod;
using System.Collections.Generic;
using System.Linq;

namespace Nova3diLab.Model
{
    public class Model3D
    {
        public GeneralHeader GeneralHeader { get; set; }
        public List<ModelBitmap> Bitmaps { get; set; }
        public List<ModelLod> Lods { get; set; }

        public static Model3D FromWavefrontObj(string objFile, string name)
        {
            ModelMappingConfiguration.Configure();

            Scene obj = FileFormatObj.Load(objFile, false).Model;

            ModelLod lod = new ModelLod
            {
                Vertices = obj.Vertices.Select(vertex => Mapper.Map<Lod.Vertex>(vertex)).Distinct(new VertexComparer()).ToList()
            };

            return new Model3D { Lods = new List<ModelLod> { lod } };

            //using (BinaryWriter writer = new BinaryWriter(new FileStream($"{name}.3di", FileMode.Create)))
            //{
            //    //writer.Write(generalHeader.Radius);
            //    //// versioning
            //    //writer.Write("3DI".ToCharArray());
            //    //writer.Write((byte)8);
            //    //writer.Write(name.ToByteArray(8)); // name
            //    //writer.Write(0x000000010012FCD0); // gap
            //    //writer.Write(1); // LOD count

            //    //// LOD distances
            //    //writer.Write(0);
            //    //writer.Write(0);
            //    //writer.Write(0);
            //    //writer.Write(0);

            //    //// render codes
            //    //writer.Write("crng".ToCharArray());
            //    //writer.Write("crng".ToCharArray());
            //    //writer.Write("crng".ToCharArray());
            //    //writer.Write("crng".ToCharArray());

            //    //// gaps
            //    //writer.Write((Int64)0);
            //    //writer.Write((Int64)0);
            //    //writer.Write((Int64)0);
            //    //writer.Write((Int64)0);
            //    //writer.Write((Int64)0);

            //    //writer.Write((ushort)65152);
            //}
        }
    }
}
