using System.Runtime.InteropServices;

namespace Nova3diLab.Model.Texture
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 1)]
    public struct DF2Texture
    {
        public int Foo => 1;
        //public TextureHeader BitmapHeader { get; set; }
        //public byte[] BitmapData { get; set; }
        //public byte[] BitmapPalette { get; set; }
    }
}
