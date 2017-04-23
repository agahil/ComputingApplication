using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputingApplication
{
    public class Calculator
    {
        public Coordinates ExtrapolatePosition(Coordinates p0, Coordinates p1, int x0, int x1, int xk)
        {
            double fraction = (xk - x0) / (x1 - x0);
            Coordinates result = new Coordinates();

            result.X = p0.X + fraction *(p1.X-p0.X);
            result.Y = p0.Y + fraction * (p1.Y - p0.Y);
            result.Z = p0.Z + fraction * (p1.Z - p0.Z);

            return result;
        }
    }


}
