using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public struct Pixel
    {
        public Pixel(double r, double g, double b)
        {
            //We fulfill the formal requirement of the compile
            //to initialize all properties of the object
            this.r = this.g = this.b = 0;

            R = r;
            G = g;
            B = b;
        }

        double r;
        public double R
        {
            get  => 
                r;
            set  => 
                r = Check(value);
        }

        double g;
        public double G
        {
            get  =>
                g;
            set  =>
                g = Check(value);
        }

        double b;
        public double B
        {
            get  =>
                b;
            set  =>
                b = Check(value);
        }

        public static double Trim(double range)  =>
            range > 1 ? 1 : (range < 0 ? 0 : range);

        public double Check(double value)
        {
            if (value < 0 || value > 1)
                throw new ArgumentException();
            return value;
        }

        public static Pixel operator* (Pixel p, double num)
        {
            return new Pixel(
                        Pixel.Trim(p.R * num),
                        Pixel.Trim(p.G * num),
                        Pixel.Trim(p.B * num));
        }

        public static Pixel operator* (double num, Pixel p)
        {
            return p * num;
        }
    }
}
