namespace Enosis
{
    class sLoopC
    {
        public void sLoopM()
        {
            for (int i = 1; i <= 19; i++)
            {
                if (i<=10)
                {
                    System.Console.WriteLine(i);
                }
                else
                {
                    System.Console.WriteLine(10-(i%10));
                }
            }
            
        }       
    }
}