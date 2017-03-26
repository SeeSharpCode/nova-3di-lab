namespace Nova3diLab.Model.Lod
{
    public class SubObject
    {
        public int VertexCount { get; set; }
        public int FacesCount { get; set; }
        public int NormalsCount { get; set; }
        public int CollisionVolumesCount { get; set; }
        public int NegativeZMax { get; set; }
        public int XMinimum { get; set; }
        public int XMaximum { get; set; }
        public int YMinimum { get; set; }
        public int YMaximum { get; set; }
        public int ZMinimum { get; set; }
        public int ZMaximum { get; set; }
        public int XMedian { get; set; }
        public int YMedian { get; set; }
        public int ZMedian { get; set; }
        public int SphereRadius { get; set; }
        public int CircleRadius { get; set; }

        /// <summary>
        /// ZMax - Zmin
        /// </summary>
        public int ZTotal { get; set; }
    }
}