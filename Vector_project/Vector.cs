using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_project
{
    class Vector
    {
        int X { get; set; }
        int Y { get; set; }
        int Z { get; set; }

       public Vector() { 
        }
        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double GetLenght()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public double ScalarSumm(Vector vector, Vector vector1)
        {
            return vector.X * vector1.X + vector.Y * vector1.Y + vector.Z * vector1.Z;
        }

        public Vector CrossProduct(Vector vector, Vector vector1)
        {
            return new Vector
            {
                X = vector.Y * vector1.Z - vector.Z * vector1.Y,
                Y = vector.Z * vector1.X - vector.X * vector1.Z,
                Z = vector.X * vector1.Y - vector.Y * vector1.X
            };
        }

        public double GetCos(Vector vector, Vector vector1)
        {
            return ScalarSumm(vector,vector1)/ vector.GetLenght() * vector1.GetLenght();
        }

        public Vector GetSumm(Vector vector, Vector vector1)
        {
            return new Vector
            {
                X = vector.X + vector1.X,
                Y = vector.Y + vector1.Y,
                Z = vector.Z + vector1.Z
            };
        }

        public Vector GetMinus(Vector vector, Vector vector1)
        {

            return new Vector
            {
                X = vector.X - vector1.X,
                Y = vector.Y - vector1.Y,
                Z = vector.Z - vector1.Z
            };

        }
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", X, Y, Z);
        }
    }
}