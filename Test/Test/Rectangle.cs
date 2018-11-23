using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Rectangle
    {
        // Coordinates of bottom left corner
        public int LeftX { get; set; }
        public int BottomY { get; set; }
         
        // Dimensions
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() { }

        public Rectangle(int leftX, int bottomY, int width, int height)
        {
            LeftX = leftX;
            BottomY = bottomY;
            Width = width;
            Height = height;
        }
    }

    public static class CollisonDetector
    {
        //check if two rectangles intersectwww.
        public static bool Intersect(Rectangle r1, Rectangle r2)
        {
            var r1x1 = r1.LeftX;
            var r1x2 = r1x1 + r1.Width;
            var r1y1 = r1.BottomY + r1.Height;
            var r1y2 = r1.BottomY;

            var r2x1 = r2.LeftX;
            var r2x2 = r2x1 + r2.Width;
            var r2y1 = r2.BottomY + r2.Height; 
            var r2y2 = r2.BottomY;

            if (ShareCommonXCoordinates(r1x1, r1x2, r2x1, r2x2) && ShareCommonYCoordinates(r1y1, r1y2, r2y1, r2y2))
                return true;

            return false;

        }

        private static bool ShareCommonYCoordinates(int a1, int a2, int b1, int b2)
        {
            if (((b1 >= a1) && (b2 <= a1)) || ((b1 <= a1) && (b1 >= a2)))
                return true;
            else
                return false;
        }

        private static bool ShareCommonXCoordinates(int a1, int a2, int b1, int b2)
        {
            if (((b1 <= a1) && (b2 >= a1)) || ((b1 >= a1) && (b1 <= a2)))
                return true;
            else
                return false;
        }
    }

}
