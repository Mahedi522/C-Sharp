// 1. [1,3,3,2,1,3]
// print repeating elements.

namespace Enosis
{
    class Repeat
    {
        public void RepeatM()
        {
            int[] nums = {1, 3, 3, 2, 1, 3};
            Dictionary<int, int> ds = new Dictionary<int, int>();
            
            // for(int i = 0; i < nums.Length; i = i + 1)
            // {   
            //     int x = 1;

            //     for (int j = i+1; j < nums.Length; j = j + 1)
            //     {
            //         if (nums[0]==nums[j])
            //         {
            //             x = x+1;
            //             // ds.Add(nums[i],x);
            //             // nums = nums.Except(new int[]{nums[i]}).ToArray();
            //             // nums = nums.Except(new int[]{i}).ToArray();
            //         }
            //         if (j == nums.Length-1)
            //         {
            //             ds.Add(nums[i],x);
            //             nums = nums.Except(new int[]{nums[0]}).ToArray();
            //         }
            //     }  
            // }
            int x = 1;
            for(int i = 1; i < nums.Length; i = i + 1)
            {
                 if (nums[0]==nums[i])
                    {
                        x = x+1;
                        // ds.Add(nums[i],x);
                        //{1, 3, 3, 2, 1, 3};
                        // nums = nums.Except(new int[]{nums[i]}).ToArray();
                        // nums = nums.Except(new int[]{i}).ToArray();
                        ds.Add(nums[i],x);
                        
                        System.Console.WriteLine("0th position is: "+ nums[0]);
                        
                    }
                    System.Console.WriteLine("i is: "+ i);
                    if (i == nums.Length)
                    {
                        System.Console.WriteLine("x is: "+x);
                        
                        nums = nums.Except(new int[]{nums[0]}).ToArray();
                        x = 1;
                        System.Console.WriteLine("length is: "+nums.Length);
                    }
            }

            foreach (KeyValuePair<int, int> item in ds)
            {
                System.Console.WriteLine("key = {0}, Value is: {1}",item.Key,item.Value);
            }

            // nums = nums.Except(new int[]{1}).ToArray();
            foreach (int num in nums)
            {
                System.Console.WriteLine("num: "+num);
            }

        }
        
    }
    
}