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
            var vertices = mqo.Vertices.Select(vertex => 
                new Vertex(
                    (short)Math.Round(vertex.X * 256),
                    (short)Math.Round(vertex.Z * -256),
                    (short)Math.Round(vertex.Y * 256)
                ))
                .ToList();

            var faces = new List<Face>();
            for (int i = 0; i < mqo.Faces.Count; i++)
            {
                var face = mqo.Faces[i];

                faces.Add(new Face(
                    (short)i,
                    new List<Tuple<double, double>>
                    {
                        Tuple.Create(face.UVCoordinates[0].Item1, face.UVCoordinates[0].Item2),
                        Tuple.Create(face.UVCoordinates[2].Item1, face.UVCoordinates[2].Item2),
                        Tuple.Create(face.UVCoordinates[1].Item1, face.UVCoordinates[1].Item2)
                    },
                    //face.VertexIndices.Select(index => Tuple.Create(index, vertices[index])).ToList(),
                    new List<Tuple<int, Vertex>>
                    {
                        Tuple.Create(face.VertexIndices[0], vertices[face.VertexIndices[0]]),
                        Tuple.Create(face.VertexIndices[2], vertices[face.VertexIndices[2]]),
                        Tuple.Create(face.VertexIndices[1], vertices[face.VertexIndices[1]])
                    },
                    face.MaterialIndex
                ));
            }

            return new Model(name, textures, vertices, faces);
        }
    }
}