using System;

namespace TrainingStyleCoding
{
    public class Rectangle
    {
        // Coordinates
        public double LeftX { get; set; }
        public double RightX { get; set; }
        public double DownY { get; set; }
        public double UpX { get; set; }
        // Sides of rectangle ABCD
        public double AB { get; set; }
        public double BC { get; set; }
        public double CD { get; set; }
        public double AD { get; set; }
        public Rectangle (double leftx, double rightx,double downy, double upx)
        {
            LeftX = leftx;
            RightX = rightx;
            DownY = downy;
            UpX = upx;
        }




    }
}
