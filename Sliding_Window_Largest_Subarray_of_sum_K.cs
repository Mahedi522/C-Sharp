namespace SlidingWindow
{
    class Sliding_Window_Largest_Subarray_of_sum_K
    {
         public int SubarraySum(int[] nums, int k)
         {
            int i = 0, j = 0, max = 0, sum = 0;
            while (j < nums.Length)
            {
                // while (sum < k)
                // {
                sum = sum + nums[j];
                if (sum < k)
                {
                    j++;    
                }
                    
                // }
                else if (sum == k)
                {
                    // if (max < j-i)
                    // {
                    //     max = j-i;
                    max = Math.Max(max, j-i+1);
                    // }
                    j++;
                }
                else if (sum > k)
                {
                    while (sum > k)
                    {
                        sum = sum - nums[i];  
                        i++; 
                    }
                    j++;   
                }
            }
            return max;
         }

         public void mainn()
         {
            int[] nums = new int[]{4, 1, 1, 1, 2, 3, 5};
            int k = 5;
            int result = SubarraySum(nums, k);
            System.Console.WriteLine(result);
         }
    }
}