using OOP_Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shapes
{
    class Drawing
    {
        private List<Shape> _shapes;
        public List<Shape> Shapes
        {
            private get
            {
                return _shapes;
            }

            set
            {
                _shapes = value;
            }
        }

        public double SpaceCovered 
        {
            get
            {
                double totalArea=0;
                foreach (Shape aShape in Shapes)
                {
                    totalArea += aShape.Area ;
                }
                return totalArea;
            } 
        
        }

        public double LinesDrawn
        {
            get
            {
                double totalPerimeter = 0;
                foreach (Shape aShape in Shapes)
                {
                    totalPerimeter += aShape.Perimeter;
                }
                return totalPerimeter;
            }
        }

        public void Draw(Shape shapeToAdd)
        {
            Shapes.Add(shapeToAdd);
        }

        public Drawing()
        {
            Shapes = new List<Shape>();
        }

        public override string ToString()
        {
            int i = 0;
            foreach (Shape aShape in Shapes)
            {
                i++;
            }

                return $"\nA Drawing consiting of {i} shapes";
        }
    }
}
