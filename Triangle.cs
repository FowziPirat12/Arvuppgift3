using System.Reflection.Metadata;

namespace Arvuppgift3
{
    public class Triangle : IShape
    {
        int height;
        int width;
        public int Area()
        {
            int area = (height * width) / 2;
            return area;
        }

        public int Circumference()
        {
            int c = (int)Math.Sqrt((height * height) + (width  * width));
            int omkrets = c + height + width; 
            return omkrets; 
        }
    }
}