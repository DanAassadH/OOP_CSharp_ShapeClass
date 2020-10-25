using OOP_Shapes.Shapes;
using System;

namespace OOP_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- Circle Calculations -----------");
            Circle circle = new Circle();
            Console.WriteLine(circle);
            circle = new Circle(3,"Red");
            Console.WriteLine(circle);



        }
    }
}
