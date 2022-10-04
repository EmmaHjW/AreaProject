using System;
using System.Linq;

namespace AreaProject
{
    public class Triangle// My second class
    {
        int _base;
        int _height = 8;

        public Triangle(int area)// My constructor
        {
             _base = area;
        }

        public double GetArea()// Method, which calculate the area of Triangle.
        {
            double area2 = 0.5 * (_base * _height);
            return area2;
        }

    }

}
