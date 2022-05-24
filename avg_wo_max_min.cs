namespace Enosis
{
    class avC
    {
        public void avM()
        {
            int[] nums = new int[] {2, 34, 6, 8, 8, 10, 2, 5};
            int max = 0;
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                else if (nums[i]< min)
                {
                    min = nums[i];
                }
            }
            System.Console.WriteLine("max is {0}, min is: {1}",max,min);
            double divisor = 0;
            double dividend = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != max && nums[i] != min)
                {
                    System.Console.WriteLine("numbers: "+nums[i]);
                    dividend = dividend + nums[i];
                    divisor = divisor + 1;
                }
            }
            double quotient = dividend / divisor;
            System.Console.WriteLine("avg without max and min nums {0} / {1} = {2}", dividend,divisor, quotient);
        }
    }
    
}