namespace RecursionN
{
    class Drecursion
    {
        //direct recursion
        public int DrecursionM(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int x = DrecursionM(n-1);
                System.Console.WriteLine("x is: "+x);
                return 1+ DrecursionM(n-1);
            }  
        }

        //tail recursion

        int tailrecursion(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                System.Console.WriteLine(num);
            }
            return tailrecursion(num - 1);
        }

        //non tail recursion
        void nonTailRecursion(int num)
        {
            if (num == 0)
            {
                return;
            }
            nonTailRecursion(num-1);
            System.Console.WriteLine(num);
        }

        public void mrec()
        {
            int n = 3;
            System.Console.WriteLine("direct");
            System.Console.WriteLine(DrecursionM(n));
            System.Console.WriteLine("tail");
            System.Console.WriteLine(tailrecursion(n));
            System.Console.WriteLine("non tail");
            nonTailRecursion(n);



            
        }
    }
}