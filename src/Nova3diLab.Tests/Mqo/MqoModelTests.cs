using System;
using System.Collections.Generic;
using System.Linq;
using Nova3diLab.Mqo;
using Xunit;

namespace Nova3diLab.Tests.Mqo
{
    public class MqoObjectTests
    {
        [Fact]
        public void LoadTest()
        {
            var mqo = MqoModel.Load("Resources/box-object.mqo");

            Assert.Equal(8, mqo.Vertices.Count);
            Assert.Equal(12, mqo.Faces.Count);

            var vertex = mqo.Vertices[0];
            Assert.Equal(0, vertex.X);
            Assert.Equal(1, vertex.Y);
            Assert.Equal(-1, vertex.Z);

            var face = mqo.Faces[0];
            Assert.Equal(0, face.MaterialIndex);
            Assert.True(new List<int> { 5, 4, 6 }.SequenceEqual(face.VertexIndices));

            var expectedUVCoordinates = new List<Tuple<double, double>> 
            { 
                Tuple.Create(1.0, 1.0), 
                Tuple.Create(0.0, 1.0), 
                Tuple.Create(1.0, 0.0) 
            };
            Assert.True(expectedUVCoordinates.SequenceEqual(face.UVCoordinates));

            var expectedTextures = new List<string> { "Box.bmp" };
            Assert.True(expectedTextures.SequenceEqual(mqo.TextureNames));
        }
    }
}