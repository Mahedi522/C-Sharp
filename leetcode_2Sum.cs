namespace LeetCode
{
    class leetcode_2Sum
    {
        
        public int[] TwoSum(int[] nums, int target) 
        {
            int[] results = new int[2];  
            for (int i = 0; i< nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    else if(nums[i] + nums [j] == target)
                    {
                        results[0] =i;
                        results[1] = j;  
                        count = 1;
                        break;  
                    }
                }
                if (count == 1)
                {
                    
                    break;
                }
            }
            return results;  
        }
        public int counter = 0;
        public int a = 0;
        public void TwoSums(int[] nums, int target) 
        {
            
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (a == i)
                {
                    continue;
                }

                else if (target - nums[a] == nums[i])
                {
                    System.Console.WriteLine("a is {0}, i is{1}",a,i);
                    int[] aa = new int[]{a, i};
                    counter = 1;
                    break;
                }
                 
            }
            

            if (counter != 1)
            {
                a += 1; 
                TwoSums(nums, target);
            }

        }
        public void mainn()
        {
            int[] nums = {3, 2, 4};
            int target = 6;
            int [] x = TwoSum(nums, target); 
            
            foreach (var item in x)
            {
                System.Console.WriteLine(item);
            }
            TwoSums(nums, target); 
        } 

    }
}
