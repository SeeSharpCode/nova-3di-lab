using FileFormatWavefront.Model;
using Nova3diLab.Model.Lod;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nova3diLab.Model
{
    internal static class Director
    {
        internal static void Construct(ModelBuilder builder)
        {
            builder.BuildLods();
            builder.BuildGeneralHeader();
            builder.BuildBitmaps();
        }
    }

    internal class ModelBuilder
    {
        private readonly Scene _scene;
        private readonly string _name;
        private readonly Model3D _model = new Model3D();

        internal ModelBuilder(Scene scene, string name)
        {
            _scene = scene;
            _name = name;
        }

        internal void BuildBitmaps()
        {
            
        }

        internal void BuildGeneralHeader()
        {
            _model.GeneralHeader = new GeneralHeader
            {
                Name = _name,
                LodCount = 1,
                Radius = _model.Lods.First().CalcuateRadius(),
                BitmapCount = _scene.Materials.Count
            };
        }

        internal void BuildLods()
        {
            _model.Lods = new List<ModelLod>
            {
                new ModelLod
                {
                    Vertices = _scene.Vertices.Select(vertex => Vertex.FromObjVertex(vertex)).Distinct(new VertexComparer()).ToList()
                }
            };
        }

        internal Model3D GetResult()
        {
            return _model;
        }
    }
}
