using System;
using System.Collections.Generic;
using System.Text;

namespace Training1.Rectangle
{
    public interface ISize
    {
        int Width { get; set; }
        int Height { get; set; }
        int Perimeter(int width, int height);
    }
}
