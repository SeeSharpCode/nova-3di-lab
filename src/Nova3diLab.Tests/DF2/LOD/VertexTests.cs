using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.Model.Lod.Tests
{
    public class VertexTests
    {
        [Fact]
        public void SerializeTest()
        {
            var vertices = new List<Vertex>
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

            var expected = File.ReadAllBytes("Resources/vertices.3di");
            var actual = vertices.SelectMany(vertex => TestUtils.SerializeToBytes(vertex)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}