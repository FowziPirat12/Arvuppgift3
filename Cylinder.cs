namespace Arvuppgift3
{
    public class Cylinder : IShape
    {

        int height; 
        int radius; 
        public int Area()
        {
            int area = (int)(Math.PI*2*radius*height) + (int)Math.PI*2*(radius*radius);
            return area;
        }

        public int Circumference()
        {
            int omkrets = (int)Math.PI*2*radius;
            return omkrets; 
        }

    }
}