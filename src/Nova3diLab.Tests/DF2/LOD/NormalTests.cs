using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.DF2.LOD.Tests
{
    public class NormalTests
    {
        public static List<Normal> Normals => FaceTests.Faces.Select(face => new Normal(face)).ToList();

        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/normals.3di");
            var actual = Normals.SelectMany(normal => TestUtils.SerializeToBytes(normal)).ToArray();
            File.WriteAllBytes("Resources/normal-test-results.3di", actual);
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}