namespace RecursionN
{
    class indirectRecursionC
    {

        //add 1 when even and substract when odd;
        
        public void even(int num)
        {
            if (num <=5)
            {
                System.Console.WriteLine(num+1);
                num++;
                Odd(num);
            }
            return;
        }

        public void Odd(int num)
        {
            if (num <=5)
            {
                System.Console.WriteLine(num-1);
                num++;
                even(num);
            }
            return;
        }
    }
}