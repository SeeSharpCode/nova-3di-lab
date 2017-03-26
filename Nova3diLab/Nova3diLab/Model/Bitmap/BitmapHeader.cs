using System;

namespace Nova3diLab.Model.Bitmap
{
    public class BitmapHeader
    {
        public string Name { get; set; }
        public string TransparentName { get; set; }
        public int BitmapSize { get; set; }
        public Int16 BitmapIndex { get; set; }
        public Int16 BitmapWidth { get; set; }
        public Int16 BitmapHeight { get; set; }
    }
}
