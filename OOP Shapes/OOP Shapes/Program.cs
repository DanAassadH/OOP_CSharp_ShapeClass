using OOP_Shapes.Shapes;
using System;

namespace OOP_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- Drawing Details -----------");

            Drawing makeDrawing = new Drawing();

            Console.WriteLine(new Triangle(9, "Blue"));
            Console.WriteLine(new Rectangle(3, 2, "Yellow"));
            Console.WriteLine(new Circle(3, "Red"));
            Console.WriteLine(new Rectangle());

            makeDrawing.Draw(new Triangle(9, "Blue"));
            makeDrawing.Draw(new Rectangle(3, 2, "Yellow"));
            makeDrawing.Draw(new Circle(3, "Red"));
            makeDrawing.Draw(new Rectangle());

            Console.WriteLine(makeDrawing);
            Console.WriteLine($"Total Perimeter covered by all the shapes is :  {string.Format("{0:0.##}", makeDrawing.LinesDrawn)}");
            Console.WriteLine($"Total area covered by all the shapes is :  {string.Format("{0:0.##}", makeDrawing.SpaceCovered)}");



            /*  Console.WriteLine("------- Circle Calculations -----------");

              Circle circle = new Circle();
              Console.WriteLine(circle);
              circle = new Circle(3, "Red");
              Console.WriteLine(circle);

              Console.WriteLine("------- Rectangle Calculations -----------");
              Rectangle rectangle = new Rectangle();
              Console.WriteLine(rectangle);
              rectangle = new Rectangle(3, 2, "Yellow");
              Console.WriteLine(rectangle);

              Console.WriteLine("------- Triangle Calculations -----------");
              Triangle triangle = new Triangle();
              Console.WriteLine(triangle);
              triangle = new Triangle(9, "Blue");
              Console.WriteLine(triangle);*/

            /* Rectangle rectangle = new Rectangle();
               Circle circle = new Circle();
               Triangle triangle = new Triangle();
               makeDrawing.Draw(rectangle);
              makeDrawing.Draw(circle);
              makeDrawing.Draw(triangle);*/
        }
    }
}
