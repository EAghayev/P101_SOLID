﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    class Circle : Shape
    {
        public double Radius;

        public override double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
