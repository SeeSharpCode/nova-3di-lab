using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.Df2;
using Nova3diLab.Mqo;
using Xunit;

namespace Nova3diLab.Tests.Mqo
{
    public class MqoTo3diConverterTests
    {
        [Fact]
        public void HeaderTest()
        {
            var expected = File.ReadAllBytes("Resources/general-header.3di");
            var model = Convert();
            var actual = TestUtils.SerializeToBytes(model.Header);
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void TexturesTest()
        {
            var expected = File.ReadAllBytes("Resources/texture.3di");
            var model = Convert();
            var actual = TestUtils.SerializeToBytes(model.Textures[0]);
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void LodHeaderTest()
        {
            var expected = File.ReadAllBytes("Resources/lod-header-no-collision.3di");
            var model = Convert();
            var actual = TestUtils.SerializeToBytes(model.Lods[0].Header);
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void VerticesTest()
        {
            var expected = File.ReadAllBytes("Resources/vertices.3di");
            var model = Convert();
            var actual = model.Lods[0].Vertices.SelectMany(vertex => TestUtils.SerializeToBytes(vertex));
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void FacesTest()
        {
            var expected = File.ReadAllBytes("Resources/faces.3di");
            var model = Convert();
            var actual = model.Lods[0].Faces.SelectMany(face => TestUtils.SerializeToBytes(face)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void NormalsTest()
        {
            var expected = File.ReadAllBytes("Resources/normals.3di");
            var model = Convert();
            var actual = model.Lods[0].Normals.SelectMany(normal => TestUtils.SerializeToBytes(normal)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void SubObjectTest()
        {
            var expected = File.ReadAllBytes("Resources/sub-object-no-collision.3di");
            var model = Convert();
            var actual = model.Lods[0].SubObjects.SelectMany(subObject => TestUtils.SerializeToBytes(subObject)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void MaterialTest()
        {
            var expected = File.ReadAllBytes("Resources/material.3di");
            var model = Convert();
            var actual = model.Lods[0].Materials.SelectMany(material => TestUtils.SerializeToBytes(material)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void CollisionPlanesTest()
        {
            var mqo = MqoModel.Load("Resources/box-object.mqo");
            var collision = MqoModel.Load("Resources/box-collision.mqo");
            var df2 = MqoTo3diConverter.Convert("box", mqo, new List<Texture> { new Texture("box", 0, 512, 512) }, collision);
            var expected = File.ReadAllBytes("Resources/collision-planes.3di");
            var actual = df2.Lods[0].CollisionPlaneVectors.SelectMany(collisionPlane => TestUtils.SerializeToBytes(collisionPlane)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void CollisionVolumesTest()
        {
            var mqo = MqoModel.Load("Resources/box-object.mqo");
            var collision = MqoModel.Load("Resources/box-collision.mqo");
            var df2 = MqoTo3diConverter.Convert("box", mqo, new List<Texture> { new Texture("box", 0, 512, 512) }, collision);
            var expected = File.ReadAllBytes("Resources/collision-volume.3di");
            var actual = df2.Lods[0].CollisionVolumes.SelectMany(volume => TestUtils.SerializeToBytes(volume)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void ModelTest()
        {
            var expected = File.ReadAllBytes("Resources/box-no-collision.3di");
            var model = Convert();
            var actual = TestUtils.SerializeToBytes(model);
            Assert.True(expected.SequenceEqual(actual));
        }

        private Model Convert()
        {
            var mqo = MqoModel.Load("Resources/box-object.mqo");
            return MqoTo3diConverter.Convert("box", mqo, new List<Texture> { new Texture("box", 0, 512, 512) });
        }
    }
}