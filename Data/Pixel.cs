using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class Pixel
    {
        double r;
        public double R
        {
            get => 
                r;
            set => 
                r = Check(value);
        }

        double g;
        public double G
        {
            get =>
                g;
            set =>
                g = Check(value);
        }

        double b;
        public double B
        {
            get =>
                b;
            set =>
                b = Check(value);
        }

        public static double Trim(double range) =>
            range > 1 ? 1 : (range < 0 ? 0 : range);

        public double Check(double value)
        {
            if (value < 0 || value > 1)
                throw new ArgumentException();
            return value;
        }
    }
}
