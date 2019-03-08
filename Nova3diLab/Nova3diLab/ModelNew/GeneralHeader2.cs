using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nova3diLab.ModelNew
{
    [StructLayout(LayoutKind.Sequential, Size = STRUCT_SIZE, Pack = 1)]
    public struct GeneralHeader2
    {
        public const int STRUCT_SIZE = 128;

        public FileVersion Signature { get; set;  }

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        private byte[] name;

        public string Name
        {
            get => Encoding.ASCII.GetString(name).Replace("\0", String.Empty);
            set => name = Encoding.ASCII.GetBytes(value.PadRight(12, '\0'));
        }

        private readonly uint GAP_0;

        // public HeaderLodInfo LodInfo { get; }

        // [MarshalAs(UnmanagedType.ByValArray, SizeConst = 17 * 4)] private readonly byte[] GAP_1;

        // public int TextureCount { get; }

        public void Write()
        {
            int size = Marshal.SizeOf(this);
            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(this, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);

            File.WriteAllBytes(@"G:\Games\Novalogic\Delta Force 2\Tools\Modding\3di\Box (Tutorial)\test.3di", arr);
        }
    }

    public enum FileVersion : uint
    {
        ERROR = 0,
        V8 = 0x08494433 //{ '3', 'D', 'I', 0x8 }
    }
}
