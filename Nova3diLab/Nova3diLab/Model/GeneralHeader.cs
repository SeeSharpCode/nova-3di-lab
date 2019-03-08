using System.Runtime.InteropServices;
using System.Text;

namespace Nova3diLab.Model
{
    [StructLayout(LayoutKind.Sequential, Size = 128, Pack = 1)]
    public struct GeneralHeader
    {
        private const uint SIGNATURE = 0x08494433; // 3, D, I, 0x8
        private const uint GENERIC_RENDER_FUNCTION = 0x676E7263; // crng

        // '3', 'D', 'I', 0x8
        private uint version => SIGNATURE;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        private byte[] name;

        public string Name
        {
            get => Encoding.ASCII.GetString(name).Replace("\0", string.Empty);
            set => name = Encoding.ASCII.GetBytes(value.PadRight(12, '\0'));
        }

        private readonly uint GAP_0;

        public uint LodCount { get; set; }
        public uint Lod4Distance { get; set; }
        public uint Lod3Distance { get; set; }
        public uint Lod2Distance { get; set; }
        public uint Lod1Distance { get; set; }

        private uint lod4RenderType => GENERIC_RENDER_FUNCTION;
        private uint lod3RenderType => GENERIC_RENDER_FUNCTION;
        private uint lod2RenderType => GENERIC_RENDER_FUNCTION;
        private uint lod1RenderType => GENERIC_RENDER_FUNCTION;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        private readonly byte[] GAP_1;

        public uint Sphere { get; set; }
        public uint Radius { get; set; }

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        private readonly byte[] GAP_2;

        public int TextureCount { get; set; }
    }
}
