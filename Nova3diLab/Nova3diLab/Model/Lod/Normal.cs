using System;

namespace Nova3diLab.Model.Lod
{
    public class Normal
    {
        public Int16 X { get; set; }
        public Int16 Y { get; set; }
        public Int16 Z { get; set; }

        /// <summary>
        /// Value describing the vector component with the largest absolute value.
        /// </summary>
        public Int16 Descriptor { get; set; }
    }
}