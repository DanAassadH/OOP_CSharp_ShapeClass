using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shapes.Shapes
{
    //https://www.calculatorsoup.com/calculators/geometry-plane/circle.php
    class Circle : Shape
    {
        // radius of circle = r .... base for all circle calculations in Circle class
        public double Radius { get; set; }

        // Diameter of circle = 2r
        private double _diameter;
        public double Diameter
        {
            get
            {
                return _diameter;
            }

            set
            {
                _diameter = 2 * Radius;
            }
        }


        //Circumference(Equivalent to Perimeter)  of Circle = 2PI*r
        public override double Perimeter
        {
            get
            {
                return 2 * 3.14 * Radius;
            }
        }

        // Area of circle = PI * r^2
        public override double Area
        {
            get
            {
                return 3.14 * Radius * Radius;
            }
        }

        public Circle(double radius, string color)
            :base(color)
        {
            Radius = radius;
            Diameter = Diameter;
        }

        public Circle()
        {
            Radius = 10;
            Diameter = Diameter;
        }

        /**https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
        *https://www.daveoncsharp.com/2009/09/formatting-decimals-in-csharp/
        */
/*        public override string ToString()
        {
            string perim = string.Format("{0:0.##}", Perimeter);
            string area = string.Format("{0:0.##}", Area); 
            return $"\n-----------A {Color} Circle-----------\nRadius of Circle : {Radius}\nDiameter of Circle : {Diameter}\nCircumference of Circle : {perim}\nArea of Circle : {area}\n";
        }*/
    }
}
