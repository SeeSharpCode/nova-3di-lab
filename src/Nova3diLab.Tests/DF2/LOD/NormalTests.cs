using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.Model.Lod.Tests
{
    public class NormalTests
    {
        public static List<Normal> Normals => new List<Normal>
        {
            new Normal(0, 0, -16384, 1),
            new Normal(0, 0, -16384, 1),
            new Normal(0, 0, 16384, 1),
            new Normal(0, 0, 16384, 1),
            new Normal(0, -16384, 0, 2),
            new Normal(0, -16384, 0, 2),
            new Normal(0, 16384, 0, 2),
            new Normal(0, 16384, 0, 2),
            new Normal(-16384, 0, 0, 4),
            new Normal(-16384, 0, 0, 4),
            new Normal(16384, 0, 0, 4),
            new Normal(16384, 0, 0, 4),
        };

        [Fact]
        public void SerializeTest()
        {

            var expected = File.ReadAllBytes("Resources/normals.3di");
            var actual = Normals.SelectMany(normal => TestUtils.SerializeToBytes(normal)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}