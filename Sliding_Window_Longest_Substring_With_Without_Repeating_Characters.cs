namespace SlidingWindow
{
    class Sliding_Window_Longest_Substring_With_Without_Repeating_Characters
    {
        public int LengthOfLongestSubstring(string s) 
        {
            int i = 0, j = 0, max = 0;
            Dictionary<char, int> Dcount = new Dictionary<char, int>();
            while (j<s.Length)
            {
                // if (Dcount.Count < j-i+1)
                // {
                    if (!Dcount.ContainsKey(s[j]))
                {
                    Dcount.Add(s[j], 1);
                    // x = j-i+1;
                    
                }
                else if (Dcount.ContainsKey(s[j]))
                {
                    Dcount.TryGetValue(s[j], out var currentcount);
                    Dcount[s[j]] = currentcount + 1;
                    // x = j-i+1;
                    
                }
                // }
                
                if (Dcount.Count == j-i+1)
                {
                    if (max < j-i+1)
                    {
                        max = j-i+1;
                    }
                }
                if (Dcount.Count < j-i+1)
                {
                    
                    while (Dcount.Count < j-i+1)
                    {
                        if (Dcount[s[i]]>1)
                        {
                            Dcount.TryGetValue(s[i],out var currentcount1);
                            Dcount[s[i]] = currentcount1 -1;
                        }
                        else if (Dcount[s[i]] == 1)
                        {
                            Dcount.Remove(s[i]);
                        }
                        i++;
                    }   
                }
                j++;
            }
            foreach (var item in Dcount)
            {
                System.Console.WriteLine(item);
            }
            return max;
        }
        public void mainn()
        {
            string s = "pwwkew";
            int result = LengthOfLongestSubstring(s);
            System.Console.WriteLine("Max count is: "+result);
        }
    }
}