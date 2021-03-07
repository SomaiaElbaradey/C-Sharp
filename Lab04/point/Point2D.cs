using System;
using System.Collections.Generic;
using System.Text;

namespace point
{
    class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point2D() { X = Y = 0; }
        public Point2D(double _X, double _Y)
        {
            X = _X;
            Y = _Y;
        }
    }
}
