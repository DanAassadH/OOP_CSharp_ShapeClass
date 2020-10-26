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

        public double SpaceCovered { get; }

        public double LinesDrawn { get; }

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

                return $"A Drawing consiting of {i} shapes";
        }
    }
}
