using System;
using System.Collections.Generic;

namespace Nova3diLab.Df2.Lod
{
    public class Vector
    {
        public Vertex Origin { get; }
        public double Magnitude { get; }

        public Vector(List<Vertex> vertices)
        {
            var Ax = vertices[1].X - vertices[0].X;
            var Bx = vertices[2].X - vertices[0].X;

            var Ay = vertices[1].Y - vertices[0].Y;
            var By = vertices[2].Y - vertices[0].Y;

            var Az = vertices[1].Z - vertices[0].Z;
            var Bz = vertices[2].Z - vertices[0].Z;

            var Nx = (Ay * Bz) - (By * Az);
            var Ny = (Az * Bx) - (Bz * Ax);
            var Nz = (Ax * By) - (Bx * Ay);

            Magnitude = Math.Sqrt(Math.Pow(Nx, 2) + Math.Pow(Ny, 2) + Math.Pow(Nz, 2));

            var x = (short)((Nx / Magnitude) * 16384);
            var y = (short)((Ny / Magnitude) * 16384);
            var z = (short)((Nz / Magnitude) * 16384);
            Origin = new Vertex(x, y, z);
        }
    }
}
