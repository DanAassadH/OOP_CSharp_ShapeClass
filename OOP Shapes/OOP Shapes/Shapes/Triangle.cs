using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shapes.Shapes
{
    class Triangle : Shape
    {
        // Equilateral Triangle -- all 3 sides are equal Base
        public double BaseLength { get; set; }

        // Height of Triangle = (1/2) * √3 * Base
        private double _height;
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
        public override double Perimeter
        {
            get
            {
                return 3 * BaseLength;
            }
        }

        // Area of Triangle = (1/4) * √3 * a^2
        public override double Area
        {
            get
            {
                return 0.25 * Math.Sqrt(3) * (BaseLength* BaseLength);
            }
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
            return $"\n-----------A {Color} Triangle-----------\nBase of Triangle : {BaseLength}\nHeight of Triangle : {height}\nPerimeter of Triangle : {perim}\nArea of Triangle : {area}\n";
        }
    }
}
