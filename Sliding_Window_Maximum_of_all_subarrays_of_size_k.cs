namespace SlidingWindow
{
    class Sliding_Window_Maximum_of_all_subarrays_of_size_k
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int i = 0, j = 0;
            List<int> li = new List<int>{};
            List<int> result = new List<int>();
            while (j < nums.Length)
            {
                while (li.Count > 0 && li.Last()<nums[j])
                {
                    li.Remove(li.Last());
                }
                li.Add(nums[j]);
                //calculation
                if (j-i+1 < k) 
                {
                    j++;
                }

                else if (j-i+1 == k)
                {
                    result.Add(li.First());
                    //calculate ans
                    if (nums[i] == li.First())
                    {
                        li.Remove(li[0]); 
                    }
                    i++;
                    j++;
                }
            }
            return result.ToArray();
        }
        public void mainn()
        {
        int[] nums = new int[]{1,3,1,2,0,5};
        int k = 3;
        int[] x = MaxSlidingWindow(nums, k);
        foreach (var item in x)
            {
                System.Console.Write(item + " ");
            }
        }
    }
}