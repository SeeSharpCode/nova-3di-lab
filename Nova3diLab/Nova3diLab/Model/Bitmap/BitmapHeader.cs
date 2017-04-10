namespace Nova3diLab.Model.Bitmap
{
    public class BitmapHeader
    {
        public string Name { get; set; }
        public string TransparentName { get; set; }
        public int BitmapSize { get; set; }
        public ushort BitmapIndex { get; set; }
        public ushort BitmapWidth { get; set; }
        public ushort BitmapHeight { get; set; }
    }
}
