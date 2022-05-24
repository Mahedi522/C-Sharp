namespace Enosis
{
    class nonrepeatC
    {
        public void nonrepeatM()
        {
            int[] nums = {4, 5,6 ,6 , 7, 7, 4, 5 };
            // string str = "hello world";
            // char[] nums = str.ToCharArray();

            //-------------------solving by nested for loop---------------

            // int count = 0;
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     count = 0;
            //     for (int j = nums.Length-1; j >= 0; j--)
            //     {
            //         // System.Console.WriteLine(i+","+j);
            //         if (nums[i] == nums[j] && i != j)
            //         {
                        
            //             // System.Console.WriteLine("First repeating character is: "+ nums[i]);
            //             count = count + 1;
            //             // System.Console.WriteLine("count is: "+count);
            //             break;
            //         }
            //     }
            //     if (count == 0)
            //     {
            //         System.Console.WriteLine("First non repeating character is: "+ nums[i]);
            //         break;
            //     }   
            // }
            // if (count == 1)
            //     {
            //         System.Console.WriteLine("no non repeating character");
                    
            //     }   

            //-----------------solving by using dictionary--------------------
            Dictionary<int,int> ds = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!ds.ContainsKey(nums[i]))
                {
                    ds[nums[i]] = 1;
                }
                else
                {
                    ds[nums[i]] = ds[nums[i]] + 1;
                }
            }
            // foreach (var item in ds)
            // {
            //     System.Console.WriteLine(item);    
            // }
            for (int i = 0; i < nums.Length; i++)
            {
                if (ds[nums[i]] == 1)
                {
                    System.Console.WriteLine("First non repeating character is: "+ nums[i]);
                    break;
                }
            }
        }   
    }   
}