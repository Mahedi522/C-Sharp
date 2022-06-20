namespace recursion
{
    class printName
    {
        public void printNameM(int x)
        {
            System.Console.WriteLine("Front name no: "+x);
            if (x<10)
            {
                x++;
                printNameM(x);
                
            }
            System.Console.WriteLine("Last name no: "+x);
        }
    }
}