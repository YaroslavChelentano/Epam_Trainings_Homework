using System;
using System.Collections.Generic;
using System.Text;

namespace Training1.Rectangle
{
    public interface ISize
    {
        double Width { get; }
        double Height { get; }
        double Perimeter();
    }
}
