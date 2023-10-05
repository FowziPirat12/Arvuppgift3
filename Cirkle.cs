using System.Data;

namespace Arvuppgift3
{
    public class Cirkle : IShape
    {
        int radius;
        public int Area()
        {
            int area = (int)Math.PI*(radius*radius);
            return area;
        }

        public int Circumference()
        {
            int c = (int)Math.PI *radius*2;
            return c; 
        }

    }
}