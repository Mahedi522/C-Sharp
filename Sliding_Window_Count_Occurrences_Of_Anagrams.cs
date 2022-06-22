namespace SlidingWindow
{
    class Sliding_Window_Count_Occurrences_Of_Anagrams
    {
        public void FindAnagrams(string s, string p)
        {
            int ans = 0;
            Dictionary<char, int> ds = new Dictionary<char, int>();
            List<int> result = new List<int>();
            for (int k = 0; k < p.Length; k++)
            {
                char x = p[k];
                if (!ds.ContainsKey(x))
                {
                    ds.Add(x, 1);
                }
                else if (ds.ContainsKey(x))
                {
                    ds.TryGetValue(x,out var currentCount);
                    ds[x] = currentCount + 1;
                }
            }
            int count = ds.Count;
            // System.Console.WriteLine("Count is: "+count);

            // foreach (KeyValuePair<char, int> item in ds)
            // {
            //     System.Console.WriteLine("key = {0}, Value is: {1}",item.Key,item.Value);
            // } 
            int i = 0, j = 0;
            while (j < s.Length)
            {
                if (ds.ContainsKey(s[j]))
                {
                    ds.TryGetValue(s[j], out var currentCount); 
                    ds[s[j]] = currentCount - 1;
                    if (ds[s[j]] == 0)
                    {
                        count--;
                    }
                }

                if (j-i+1 <p.Length)
                {
                    j++;
                }
                else if (j-i+1 == p.Length)
                {
                    if (count == 0)
                    {
                        ans++;
                        result.Add(i);
                    }

                    if (ds.ContainsKey(s[i]))
                    {
                        ds.TryGetValue(s[i],out var currentcount);
                        ds[s[i]] = currentcount + 1;
                        if (ds[s[i]] == 1)
                        {
                           count++; 
                        }
                        
                    }                    
                    i++;
                    j++;
                }
            }
            System.Console.WriteLine("Number of anagram is: "+ ans);
            foreach (var item in result)
            {
                System.Console.Write(item +" ");
            }
        }
        public void mainn()
        {
            string s = "cbaebabacd";
            string p = "abc";
            FindAnagrams(s, p);

        }
    }
}