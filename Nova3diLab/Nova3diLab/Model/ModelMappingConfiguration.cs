using AutoMapper;

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
                config.CreateMap<FileFormatWavefront.Model.Vertex, Lod.Vertex>()
                    .ForMember(dfVertex => dfVertex.X, opt => opt.ResolveUsing(objVertex => (ushort)objVertex.x))
                    .ForMember(dfVertex => dfVertex.Y, opt => opt.ResolveUsing(objVertex => (ushort)objVertex.z))
                    .ForMember(dfVertex => dfVertex.Z, opt => opt.ResolveUsing(objVertex => (ushort)objVertex.y));
            });

            _isConfigured = true;
        }
    }
}
