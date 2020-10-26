using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shapes.Shapes
{
    // Used Encapsulation when defined classes for each of the different shapes. 
    class Triangle : Shape // Depicts Inheritance , the class Triangle had properties "area" and "perimeter" derived from base class "Shape"
    {
        // Equilateral Triangle -- all 3 sides are equal Base
        public double BaseLength { get; set; }

        // Height of Triangle = (1/2) * √3 * Base
        private double _height;  //Anstraction to hide unnecessary details 
        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = 0.5 * Math.Sqrt(3) * BaseLength;
            }
        }

        // Perimeter of Triangle = 3 * Base
        public override double Perimeter  // the area and perimeter property shows an example of polymorphism. Polymorphism means that you can have multiple classes that can be used interchangeably, even though each class implements the same properties or methods in different ways.
        {
            get => 3 * BaseLength;

        }

        // Area of Triangle = (1/4) * √3 * a^2
        public override double Area
        {
            get => 0.25 * Math.Sqrt(3) * (BaseLength * BaseLength);

        }

        public Triangle(double baseLength, string color)
            :base(color)
        {
            BaseLength = baseLength;
            Height = Height;
        }

        public Triangle()
        {
            BaseLength = 5;
            Height = Height;
        }

        public override string ToString()
        {
            string perim = string.Format("{0:0.##}", Perimeter);
            string area = string.Format("{0:0.##}", Area);
            string height = string.Format("{0:0.##}", Height);
            return $"\n-----------A {Color} Triangle-----------\nBase of Triangle : {BaseLength}\nHeight of Triangle : {height}\nPerimeter of Triangle : {perim}\nArea of Triangle : {area}";
        }
    }
}
