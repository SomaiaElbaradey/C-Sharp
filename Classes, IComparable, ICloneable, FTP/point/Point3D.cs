using System;
using System.Collections.Generic;
using System.Text;

namespace point
{
    class Point3D : Point2D, IComparable, ICloneable
    {
        public double Z { get; set; }
        public Point3D() : base() { Z = 0; }
        public Point3D(double _X, double _Y, double _Z) : base(_X, _Y)
        {
            Z = _Z;
        }
        public static bool operator ==(Point3D left, Point3D right)
        {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z;
        }
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
        public int CompareTo(object obj)
        {
            Point3D right = obj as Point3D;
            double P01 = Math.Pow(X, 2) + Math.Pow(Y, 2);
            double P02 = Math.Pow(right.X, 2) + Math.Pow(right.Y, 2);
            return P01.CompareTo(P02);
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        public override bool Equals(Object Obj)
        {
            var right = Obj as Point3D;
            if (right == null) return false;
            if (Obj is Point3D)
            {
                if (object.ReferenceEquals(this, right)) return true;
                if (this.GetType() != right.GetType()) return false;
                return X == right.X && Y == right.Y && Z == right.Z;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }
    }
}
