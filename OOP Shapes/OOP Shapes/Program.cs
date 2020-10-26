using OOP_Shapes.Shapes;
using System;

namespace OOP_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            Console.WriteLine("------- Circle Calculations -----------");
                        Circle circle = new Circle();
                        Console.WriteLine(circle);
                        circle = new Circle(3,"Red");
                        Console.WriteLine(circle);

                        Console.WriteLine("------- Rectangle Calculations -----------");
                        Rectangle rectangle = new Rectangle();
                        Console.WriteLine(rectangle);
                        rectangle = new Rectangle(3,2, "Yellow");
                        Console.WriteLine(rectangle);

                        Console.WriteLine("------- Triangle Calculations -----------");
                        Triangle triangle = new Triangle();
                        Console.WriteLine(triangle);
                        triangle = new Triangle(9, "Blue");
                        Console.WriteLine(triangle);
            */
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();

            Drawing makeDrawing = new Drawing();
            makeDrawing.Draw(rectangle);
            makeDrawing.Draw(circle);
            makeDrawing.Draw(triangle);

            Console.WriteLine(makeDrawing);
            //makeDrawing = new Drawing();


        }
    }
}
