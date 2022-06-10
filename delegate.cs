namespace deligate
{
    // public delegate int AddDeligate(int x, int y);
    public delegate void RectDel(double x, double y);
    
    class delegateC
    {
        public static int Addnums(int num1, int num2)
        {
            return num1 + num2;
        }
        
        public void call ()
        {
            // AddDeligate addnums = new AddDeligate(Addnums);
            // int result = addnums(10,40);
            // System.Console.WriteLine(result);
            Rectangle rect = new Rectangle();
            RectDel rectdel = new RectDel(rect.GetArea);
            rectdel +=rect.GetPerimeter;

            rectdel.Invoke(10.2, 20.44);
        }
    }
    
}