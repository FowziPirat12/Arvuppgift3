namespace Arvuppgift3
{
    public class Sphere : IShape
    {

        int radius;
        public int Area()
        {
            int area = (int)Math.PI*4*radius*2; 
            return area;
        }

        public int Circumference()
        {
            int c = (int)Math.PI*2*radius;
            return c; 
        }

    }
}