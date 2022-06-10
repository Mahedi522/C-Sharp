namespace deligate
{
    class Rectangle
    {

        public void GetArea(double width, double height)
        {
            System.Console.WriteLine("Area of rectangle is: "+ width*height);
        }
        public void GetPerimeter(double width, double height)
        {
            System.Console.WriteLine("Perimeter of rectangle is: "+ 2*(width+height));
        }
        
    }
}