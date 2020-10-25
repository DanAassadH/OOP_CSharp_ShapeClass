using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shapes.Shapes
{
    abstract class Shape
    {

        // Public getter that is is overridden by derived class
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
        
        //Traditional Property
        public string Color { get; set; }

        //defult constructor 
        protected Shape()
        {
            Color = "White";
        }


        //greedy constructor
        protected Shape(string color)
        {
            Color = color;
        }
    }
}
