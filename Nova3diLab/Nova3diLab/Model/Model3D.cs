namespace Nova3diLab.Model
{
    public class Model3D
    {
        public GeneralHeader GeneralHeader { get; set; }

        internal Model3D()
        {
            GeneralHeader = new GeneralHeader();
        }
    }
}
