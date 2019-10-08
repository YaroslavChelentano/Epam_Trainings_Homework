using System;
using System.Collections.Generic;
using System.Text;

namespace Training1.Rectangle
{
    public class Rectangle : ISize , ICoordinates
    {
        public double HeightRectangle;
        public double WidthRectangle;
        public double XRectangle;
        public double YRectangle;
        // Constructor
        public Rectangle(double width,double height)
        {
            HeightRectangle = height;
            WidthRectangle = width;
        }
        // Properties
        public double Height { get { return HeightRectangle; } }
        public double Width {  get { return WidthRectangle; } }
        public double X {  get { return XRectangle; } } 
        public double Y {  get { return YRectangle; } }
        // Method to find Rectangle Perimeter
        public double Perimeter ()
        {
            return 2 * (Height + Width);
        }
    }
}
