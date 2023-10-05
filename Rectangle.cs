namespace Arvuppgift3
{
    public class Rectangle : IShape
    {
        int height; 
        int width; 
        public int Area()
        {
            int area = height * width;
            return area;
        }

        public int Circumference()
        {
            int omkrets = (height*2) + (width*2);
            return omkrets;
        }

    }
}