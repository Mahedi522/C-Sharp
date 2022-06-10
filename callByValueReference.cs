namespace callByValueReference
{
    class callByValueReferenceC
    {
        public void call()
        {
            int x = 10;
            int y = 20;
            Fun(x,y);
            System.Console.WriteLine("x is {0}, y is: {1}",x,y);
            Fun1(ref x, ref y);
            System.Console.WriteLine("x is {0}, y is: {1}",x,y);
        }
        public void Fun(int x, int y)
        {
            x = 20;
            y = 10;
        }

        public void Fun1(ref int x, ref int y)
            {
                x = 20;
                y = 10;
            }
    }
    
}