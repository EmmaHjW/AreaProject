namespace AreaProject
{
    public class Triangle//My second class
    {
        public int _base;
        int _height = 8;

        public Triangle(int secondArea)//My constructor
        {
             _base = secondArea;
        }

        public double GetArea()//Method, which should calculate my area of Triangle, but it does not work.
        {
            double area2 = 0.5 * (_base * _height);
            return area2;
        }

    }

}
