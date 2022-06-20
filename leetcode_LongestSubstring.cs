namespace LeetCode
{
    class leetcode_LongestSubstring
    {
        public int LengthOfLongestSubstring(string s) 
        {
            // int length = 0;
            
            // Dictionary<int, int> ds = new Dictionary<int, int>();
            int max = 0;
            // if (s == " ")
            // {
            //     return 1;
            // }
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                for (int j = i; j < s.Length; j++)
                {
                    if (j == i)
                    {
                        count++;
                        // max = count;
                        
                    }
                    else if (s[i] != s[j])
                    {
                        count++;
                    }
                    if (count>max)
                    {
                        max = count;
                    }
                    else
                    {
                        // ds.Add(i,count);
                        break; 
                    }
                }
                
            }
            // foreach (KeyValuePair<int, int> item in ds)
            // {
            //     System.Console.WriteLine("key = {0}, Value is: {1}",item.Key,item.Value);
                
            // }
            System.Console.WriteLine(max);
            return max;;
        }

        public void mainn()
        {
            string s = "pwwkww";
            LengthOfLongestSubstring(s);

        }
    }
}


