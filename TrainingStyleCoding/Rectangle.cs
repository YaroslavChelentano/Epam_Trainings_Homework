using System;

namespace TrainingStyleCoding
{
    public class Rectangle
    {
        public double LeftX { get; set; }
        public double RightX { get; set; }
        public double DownY { get; set; }
        public double UpX { get; set; }

        public Rectangle (double leftx, double rightx,double downy, double upx)
        {
            LeftX = leftx;
            RightX = rightx;
            DownY = downy;
            UpX = upx;
        }


    }
}
