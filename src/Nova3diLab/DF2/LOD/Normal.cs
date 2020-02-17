using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nova3diLab.DF2.LOD
{
    public class Normal : IModelSerializable
    {
        public short X { get; }
        public short Y { get; }
        public short Z { get; }
        public short Shading { get; }

        // TODO clean this mess up
        public Normal(Face face)
        {
            var Ax = face.Vertices[1].X - face.Vertices[0].X;
            var Bx = face.Vertices[2].X - face.Vertices[0].X;

            var Ay = face.Vertices[1].Y - face.Vertices[0].Y;
            var By = (face.Vertices[2].Y - face.Vertices[0].Y);
            
            var Az = face.Vertices[1].Z - face.Vertices[0].Z;
            var Bz = (face.Vertices[2].Z - face.Vertices[0].Z);

            var Nx = (Ay * Bz) - (By * Az);
            var Ny = (Az * Bx) - (Bz * Ax);
            var Nz = (Ax * By) - (Bx * Ay);

            var NL = Math.Sqrt(Math.Pow(Nx, 2) + Math.Pow(Ny, 2) + Math.Pow(Nz, 2));

            X = (short)((Nx / NL) * 16384);
            Y = (short)((Ny / NL) * 16384);
            Z = (short)((Nz / NL) * 16384);

            var absoluteMax = new List<short>() { Math.Abs(X), Math.Abs(Y), Math.Abs(Z) }.Max();

            Shading = (short)(absoluteMax == Math.Abs(X) ? 4 : (absoluteMax == Math.Abs(Y)) ? 2 : 1);
            Console.WriteLine(Shading);
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
            writer.Write(Shading);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}