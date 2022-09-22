using System;
using System.Linq;

namespace AreaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Här kommer uträkning av area nummer 1\n");//I call on all the different methods and also the class.
            Circle Calc = new Circle(5);
            Console.WriteLine(Calc.GetArea());
            Console.WriteLine();
            Console.WriteLine("Här kommer uträkning av area nummer 2\n");
            Circle Calc2 = new Circle(6);
            Console.WriteLine(Calc2.GetArea());
            Console.WriteLine();
            Console.WriteLine("Här kommer uträkningen av omkretsen\n");
            Circle Calc3 = new Circle(5);
            Console.WriteLine(Calc3.GetCircuit());
            Console.WriteLine();
            Console.WriteLine("Här kommer uträkningen av volymen\n");
            Circle Calc4 = new Circle(5);
            Console.WriteLine(Calc4.GetVolume());
            Console.WriteLine();
            Console.WriteLine("Här kommer uträkningen av arean på en triangel\n");
            Triangle Calc5 = new Triangle(5);
            Console.WriteLine(Calc5.GetArea());
        }

    }

}
