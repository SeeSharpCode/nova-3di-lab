namespace Nova3diLab.Model
{
    public class GeneralHeader
    {
        public string Name { get; set; }

        public int LodCount { get; set; }
        public int Lod4Distance { get; set; }
        public int Lod3Distance { get; set; }
        public int Lod2Distance { get; set; }
        public int Lod1Distance { get; set; }

        public string RenderFunction { get; set; } = "crng";

        public int Radius { get; set; }

        public int BitmapCount { get; set; }
    }
}
