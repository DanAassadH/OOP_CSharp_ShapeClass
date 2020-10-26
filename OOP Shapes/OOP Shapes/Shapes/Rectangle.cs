using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shapes.Shapes
{
    //https://www.calculatorsoup.com/calculators/geometry-plane/rectangle.php
    class Rectangle : Shape
    {

        // Length of Rectangle 
        public double Length { get; set; }
        // Width of Rectangle
        public double Width { get; set; }

        // Perimeter of Rectangle = 2L + 2W
        public override double Perimeter
        {
            get
            {
                return 2*Length + 2*Width;
            }
        }

        // Area of Rectangle = L * W
        public override double Area
        {
            get
            {
                return Length*Width;
            }
        }

        public Rectangle(double length, double width, string color)
            : base(color)
        {
            Length = length;
            Width = width;
        }

        public Rectangle()
        {
            Length = 20;
            Width = 10;
        }

        public override string ToString()
        {
            string perim = string.Format("{0:0.##}", Perimeter);
            string area = string.Format("{0:0.##}", Area);
            return $"\n-----------A {Color} Rectangle-----------\nLength of Rectangle : {Length}\nWidth of Rectangle : {Width}\nPerimeter of Rectangle : {perim}\nArea of Rectangle : {area}";
        }
    }
}
