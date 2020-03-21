using System.Collections.Generic;

namespace Nova3diLab.Mqo
{
    public class MqoObject
    {
        public List<MqoVertex> Vertices { get; }
        public List<MqoFace> Faces { get; }

        public MqoObject(List<MqoVertex> vertices, List<MqoFace> faces)
        {
            Vertices = vertices;
            Faces = faces;
        }
    }
}
