using System.Collections.Generic;
using Nova3diLab.Model.Lod;
using Nova3diLab.Model.Lod.Tests;

namespace Nova3diLab.Tests.DF2.LOD
{
    public class ModelLodTests
    {
        public static ModelLod ModelLod => new ModelLod
        {
            Header = LodHeaderTests.LodHeader,
            Vertices = VertexTests.Vertices,
            Normals = NormalTests.Normals,
            Faces = FaceTests.Faces,
            SubObjects = new List<SubObject> { SubObjectTests.SubObject },
            Materials = new List<Material> { MaterialTests.Material }
        };
        
        public void SerializeTest()
        {
            
        }
    }
}