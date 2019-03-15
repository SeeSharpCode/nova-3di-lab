using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nova3diLab.Tests.Properties;
using System.Collections.Generic;
using System.Linq;

namespace Nova3diLab.Model.Lod.Tests
{
    [TestClass()]
    public class VertexTests
    {
        [TestMethod()]
        public void SerializeTest()
        {
            List<Vertex> vertices = new List<Vertex>
            {
                new Vertex(0, 256, 256),
                new Vertex(0, 0, 256),
                new Vertex(256, 0, 256),
                new Vertex(256, 256, 256),
                new Vertex(0, 256, 0),
                new Vertex(256, 256, 0),
                new Vertex(256, 0, 0),
                new Vertex(0, 0, 0),
            };

            byte[] vertexBytes = vertices.SelectMany(vertex => vertex.Serialize()).ToArray();
            Assert.IsTrue(Resources.vertices.SequenceEqual(vertexBytes));
        }

        [TestMethod()]
        public void DeserializeTest()
        {
        }
    }
}