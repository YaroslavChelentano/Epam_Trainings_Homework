using System;

namespace TrainingStyleCoding
{
    public class RectangleStyleCoding
    {
        // Coordinates
        public double LeftX { get; set; }
        public double RightX { get; set; }
        public double DownY { get; set; }
        public double UpY { get; set; }
        // Sides of rectangle ABCD
        public double AB { get; set; }
        public double BC { get; set; }
        public double CD { get; set; }
        public double AD { get; set; }

        public RectangleStyleCoding(double leftx, double rightx, double downy, double upy)
        {
            LeftX = leftx;
            RightX = rightx;
            DownY = downy;
            UpY = upy;
            CD = AB = upy - downy;
            AD = BC = rightx - leftx;
        }

        public void DisplayRectangle()
        {
            Console.WriteLine($"B({LeftX},{UpY})\tC({RightX},{UpY})\nA({LeftX},{DownY})\tD({RightX},{DownY})");
        }
        public RectangleStyleCoding MoveRectangle(string direction,double length)
        {
            if(direction=="Up")
            {
                DownY += length;
                UpY += length;
            }
            else if(direction=="Down")
            {
                DownY -= length;
                UpY -= length;
            }
            else if(direction=="Left")
            {
                LeftX -= length;
                RightX -= length;
            }
            else if(direction=="Right")
            {
                LeftX += length;
                RightX += length;
            }
            return new RectangleStyleCoding(LeftX, RightX, DownY, UpY);
        }
        public RectangleStyleCoding ChangeLengthOfRectangle(string side,string lowerOrHigher,double length)
        {
            if(lowerOrHigher=="Higher")
            {
                if(side=="Width")
                {
                    RightX += length;
                }
                if(side=="Height")
                {
                    UpY += length;
                }
            }
            if(lowerOrHigher=="Lower")
            {
                if (side == "Width")
                {
                    RightX -= length;
                }
                if (side == "Height")
                {
                    UpY -= length;
                }
            }
            return new RectangleStyleCoding(LeftX, RightX, DownY, UpY);
        }
        public RectangleStyleCoding UnionOfRectangles(RectangleStyleCoding firstRectangle, RectangleStyleCoding secondRectangle)
        {
            if (firstRectangle.LeftX <= secondRectangle.LeftX)
            {
                LeftX = firstRectangle.LeftX;
            }
            else
            {
                LeftX = secondRectangle.LeftX;
            }
            if (firstRectangle.RightX <= secondRectangle.RightX)
            {
                RightX = secondRectangle.RightX;
            }
            else
            {
                RightX = firstRectangle.RightX;
            }
            if (firstRectangle.DownY <= secondRectangle.DownY)
            {
                DownY= firstRectangle.DownY;
            }
            else
            {
                DownY = secondRectangle.DownY;
            }
            if (firstRectangle.UpY <= secondRectangle.UpY)
            {
                UpY = secondRectangle.UpY;
            }
            else
            {
                UpY = firstRectangle.UpY;
            }
            return new RectangleStyleCoding(LeftX, RightX, DownY, UpY);
        }
    }
}
