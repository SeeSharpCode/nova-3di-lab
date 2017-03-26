namespace Nova3diLab.Model.Bitmap
{
    public class ModelBitmap
    {
        public BitmapHeader BitmapHeader { get; set; }
        public byte[] BitmapData { get; set; }
        public byte[] BitmapPalette { get; set; }

        public ModelBitmap()
        {
            BitmapHeader = new BitmapHeader();
        }
    }
}
