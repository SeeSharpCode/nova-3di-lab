using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.Df2.Lod;
using Xunit;

namespace Nova3diLab.Tests.Df2.Lod
{
    public class NormalTests
    {
        public static List<Normal> Normals => FaceTests.Faces.Select(face => face.Normal).ToList();

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