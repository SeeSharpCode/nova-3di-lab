using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.Df2.Lod;
using Xunit;

namespace Nova3diLab.Tests.Df2.Lod
{
    public class VertexTests
    {
        public static List<Vertex> Vertices => new List<Vertex>
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

        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/vertices.3di");
            var actual = Vertices.SelectMany(vertex => TestUtils.SerializeToBytes(vertex)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}