using System;
using System.Linq;

namespace AreaProject
{
    class Program
    {
        static void Main(string[] args)
         {
 
            bool continueProgram = true; // Doing a do-while loop for my menu

            do 
            {
                Console.Clear();
                // A Simple presentation on what is going on in this program
                Console.WriteLine();
                Console.WriteLine(" ☼ Hej, här ska jag presentera några uträkningar ☼ \n");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Console.WriteLine("* Tryck 1 och 'enter' för arean av en cirkel med radie 5\n");
                Console.WriteLine("* Tryck 2 och 'enter' för arean av en cirkel med radie 6\n");
                Console.WriteLine("* Tryck 3 och 'enter' för omkretsen på en cirkel med radie 5\n");
                Console.WriteLine("* Tryck 4 och 'enter' för volymen av en sfär/boll med radie 5\n");
                Console.WriteLine("* Tryck 5 och 'enter' för arean av en triangel med höjden 8 och basen 5\n");
                Console.WriteLine("* Tryck 'enter' för att komma tillbaka till menyn, eller väl en siffra  < och tryck 'enter' för att avsluta programmet.\n");
            
                int tal = int.Parse(Console.ReadLine());
                switch (tal) // And there i did a switch case inside the loop with the different options
                {
                    case 1:
                        Circle Calc = new Circle(5);
                        Console.WriteLine("\n = \n");
                        Console.WriteLine(Calc.GetArea());
                        break;
                    case 2:
                        Circle Calc2 = new Circle(6);
                        Console.WriteLine("\n = \n");
                        Console.WriteLine(Calc2.GetArea());
                        break;
                    case 3:
                        Circle Calc3 = new Circle(5);
                        Console.WriteLine("\n = \n");
                        Console.WriteLine(Calc3.GetCircumference());
                        break;
                    case 4:
                        Circle Calc4 = new Circle(5);
                        Console.WriteLine("\n = \n");
                        Console.WriteLine(Calc4.GetVolume());
                        break;
                    case 5:
                        Triangle Calc5 = new Triangle(5);
                        Console.WriteLine("\n = \n");
                        Console.WriteLine(Calc5.GetArea());
                        break;
                    default:
                        continueProgram = false;
                        Console.Write("\n");// Ending my program with a polite text
                        Console.WriteLine("Tack för du var inne och besökte mitt program ☺, tryck enter för att avsluta!");
                        break;
                }

                Console.ReadKey();

            } while (continueProgram);
      
            //Console.WriteLine("Tack för du var inne och besökte mitt program ☺, tryck enter för att avsluta!");
            //Console.ReadKey();
            
        }

    }

}
