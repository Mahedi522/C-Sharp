namespace SlidingWindow
{
    class Maximum_Sum_Subarray_of_size_K
    {
        public void MaxSlidingWindow(int[] nums, int k) 
        {
            int sum = 0, i = 0, j = 0, mx = 0;
            while (j < nums.Length)
            {
                sum = sum+nums[j];
                if (j-i+1 < k)
                {
                    j++;
                    continue;
                }
                else if (j-i+1 == k)
                {
                    mx = Math.Max(mx, sum);
                    sum = sum - nums[i];
                    i++;
                    j++;
                }
            }
            System.Console.WriteLine("max is : "+mx);
        }
        public void mainn()
        {
            int[] nums = {1,3,-1,-3,5,3,6,7};
            int k = 3;
            MaxSlidingWindow(nums, k);
        }
    }
}