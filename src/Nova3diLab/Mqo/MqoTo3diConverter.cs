using System;
using System.Collections.Generic;
using System.Linq;
using Nova3diLab.Df2;
using Nova3diLab.Df2.Lod;

namespace Nova3diLab.Mqo
{
    public static class MqoTo3diConverter
    {
        public static Model Convert(string name, MqoModel mqo, List<Texture> textures)
        {
            var vertices = mqo.Vertices.Select(vertex => ConvertVertex(vertex)).ToList();

            var faces = new List<Face>();
            for (short i = 0; i < mqo.Faces.Count; i++)
            {
                var face = mqo.Faces[i];
                faces.Add(ConvertFace(face, vertices, i));
            }

            return new Model(name, textures, vertices, faces);
        }

        private static Vertex ConvertVertex(MqoVertex mqoVertex)
        {
            var x = (short)Math.Round(mqoVertex.X * 256);
            var y = (short)Math.Round(mqoVertex.Z * -256);
            var z = (short)Math.Round(mqoVertex.Y * 256);
            return new Vertex(x, y, z);
        }

        private static Face ConvertFace(MqoFace mqoFace, List<Vertex> df2Vertices, short index)
        {
            var uvCoordinates = new List<Tuple<double, double>>
            {
                Tuple.Create(mqoFace.UVCoordinates[0].Item1, mqoFace.UVCoordinates[0].Item2),
                Tuple.Create(mqoFace.UVCoordinates[2].Item1, mqoFace.UVCoordinates[2].Item2),
                Tuple.Create(mqoFace.UVCoordinates[1].Item1, mqoFace.UVCoordinates[1].Item2)
            };

            var vertices = new List<Tuple<int, Vertex>>
            {
                Tuple.Create(mqoFace.VertexIndices[0], df2Vertices[mqoFace.VertexIndices[0]]),
                Tuple.Create(mqoFace.VertexIndices[2], df2Vertices[mqoFace.VertexIndices[2]]),
                Tuple.Create(mqoFace.VertexIndices[1], df2Vertices[mqoFace.VertexIndices[1]])
            };

            return new Face(index, uvCoordinates, vertices, mqoFace.MaterialIndex);
        }
    }
}