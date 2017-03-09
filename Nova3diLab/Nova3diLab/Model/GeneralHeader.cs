namespace Nova3diLab.Model
{
    public class GeneralHeader
    {
        public string FileType { get; set; }
        public byte Version { get; set; }
        public string Name { get; set; }

        public int LodCount { get; set; }
        public int Lod4Distance { get; set; }
        public int Lod3Distance { get; set; }
        public int Lod2Distance { get; set; }
        public int Lod1Distance { get; set; }

        public string RenderFunction1 { get; set; }
        public string RenderFunction2 { get; set; }
        public string RenderFunction3 { get; set; }
        public string RenderFunction4 { get; set; }

        public int SphereRadius { get; set; }
        public int CircleRadius { get; set; }

        public int BitmapCount { get; set; }
    }
}
