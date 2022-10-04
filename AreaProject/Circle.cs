using System;
using System.Linq;

namespace AreaProject
{
    public class Circle// My first class
    {
        float _pi = 3.141f;
        int _Radius;

        public Circle(int radius)// My constructor
        {
            _Radius = radius;
        }

        public double GetArea()// First method, which calculate area 
        {
            double area = _pi * _Radius * _Radius;
            return area;
        }

        public double GetCircumference()// Third method. which calculate circuit
        {
            double circuit = _pi * (_Radius * 2);
            return circuit;
        }

        public double GetVolume()// Fourth method, which calculate volume
        {
            double volume = (4 * _pi * Math.Pow(_Radius,3) / 3);
            return volume;
        }
    }

}
