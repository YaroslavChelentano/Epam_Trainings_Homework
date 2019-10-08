using System;
using System.Collections.Generic;
using System.Text;

namespace Training1.Rectangle
{
    public interface ISize
    {
        double Width { get; set; }
        double Height { get; set; }
        double Perimeter(double width, double height);
    }
}
