using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputingApplication
{
    public class Coordinates
    {
        private double x;
        private double y;
        private double z;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
 

        public double Y
        {
            get { return y; }
            set { y = value; }
        }



        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Coordinates()
        {
            x = 0.0;
            y = 0.0;
            z = 0.0;
        }

        public Coordinates(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }



    
    }
}
