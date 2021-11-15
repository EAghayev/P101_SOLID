using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    class AreCalculator
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;

            foreach (var item in shapes)
            {
                area += item.Area();
                //if(item is Rectangle)
                //{
                //    Rectangle rec = (Rectangle)item;
                //    area += rec.Width * rec.Height;
                //}
                //else if(item is Circle)
                //{
                //    Circle circle = (Circle)item;
                //    area = circle.Radius * circle.Radius * Math.PI;
                //}
            }

            return area;
        }
    }
}
