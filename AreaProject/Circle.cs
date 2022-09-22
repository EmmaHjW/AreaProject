using System;

namespace AreaProject
{
    public class Circle//My first class (under the second one) or my choise of word blueprint
    {
        float _pi = 3.141f;
        int _Radius;

        public Circle(int secondRadius)//My constructor
        {
            _Radius = secondRadius;
        }

        public double GetArea()//First method, which calculate area 
        {
            double area = _pi * _Radius * _Radius;
            return area;
        }

        public double GetCircuit()//My second method. which calculate circuit
        {
            double circuit = _pi * (_Radius * 2);
            return circuit;
        }

        public double GetVolume()//My third method, which calculate volume
        {
            double volume = (4 * _pi * Math.Pow(_Radius,3) / 3);
            return volume;
        }
    }

}
