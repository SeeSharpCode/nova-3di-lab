using AutoMapper;
using FileFormatWavefront.Model;
using System;

namespace Nova3diLab.Model
{
    public static class ModelMappingConfiguration
    {
        private static bool _isConfigured;

        public static void Configure()
        {
            if (_isConfigured)
                return;

            Mapper.Initialize(config =>
            {
                config.CreateMap<Vertex, Lod.Vertex>()
                    .ForMember(dfVertex => dfVertex.X, opt => opt.ResolveUsing(objVertex => (ushort)Math.Round(objVertex.x * 256)))
                    .ForMember(dfVertex => dfVertex.Y, opt => opt.ResolveUsing(objVertex => (ushort)Math.Round(objVertex.z * -256)))
                    .ForMember(dfVertex => dfVertex.Z, opt => opt.ResolveUsing(objVertex => (ushort)Math.Round(objVertex.y * 256)));
            });

            _isConfigured = true;
        }
    }
}
