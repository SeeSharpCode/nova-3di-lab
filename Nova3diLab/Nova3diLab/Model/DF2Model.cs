using Nova3diLab.Model.Texture;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Nova3diLab.Model
{
    [StructLayout(LayoutKind.Sequential, Size = 128, Pack = 1)]
    public unsafe struct DF2Model
    {
        public GeneralHeader GeneralHeader { get; set; }
        public fixed DF2Texture Textures[];

        public void SaveToFile(string fileName)
        {
            int fileSize = Marshal.SizeOf(this);
            byte[] buffer = new byte[fileSize];

            IntPtr pointer = Marshal.AllocHGlobal(fileSize);
            Marshal.StructureToPtr(this, pointer, true);
            Marshal.Copy(pointer, buffer, 0, fileSize);
            Marshal.FreeHGlobal(pointer);

            File.WriteAllBytes(fileName, buffer);
        }
    }
}
