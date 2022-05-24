namespace Enosis
{
    class Repeat1
    {
        public void RepeatM()
        {
            int[] nums = {1, 3, 3, 2, 1, 3};
            Dictionary<int, int> ds = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int x = 0;
                if (!ds.ContainsKey(nums[i]))
                {
                    for (int j = nums.Length-1; j >= i; j--)
                    {
                        
                            if (nums[i] == nums[ j])
                            {
                                x=x+1;
                                // System.Console.WriteLine("x is: "+x);
                                // ds.Add(nums[i],x);
                                ds[nums[i]] = x;
                            }
                    }
                }
            }
            // foreach (KeyValuePair<int, int> item in ds)
            // {
            //     System.Console.WriteLine("key = {0}, Value is: {1}",item.Key,item.Value);
            // }
            //asc
            // ds = ds.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            //dsc
            ds = ds.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            for (int i = 0; i < 2;i++)
            {
                // System.Console.WriteLine(ds.ElementAt(i));
                System.Console.WriteLine("key = {0}, Value is: {1}",ds.ElementAt(i).Key,ds.ElementAt(i).Value);
                // System.Console.WriteLine(ds.Values.Max());
            }
        }
    }
}