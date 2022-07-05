namespace SlidingWindow
{
    class Sliding_Window_Longest_Substring_With_K_Unique_Characters
    {
        public void longestKSubstr(string s, int k) 
        {
            Dictionary<char, int> uc = new Dictionary<char, int>();
            int i = 0,j = 0, max = 0;
            while (j<s.Length)
            {
                if (!uc.ContainsKey(s[j]))
                {
                    uc.Add(s[j], 1);
                    j++;
                }
                else if(uc.ContainsKey(s[j]))
                {
                    uc.TryGetValue(s[j], out var currentcount);
                    uc[s[j]] = currentcount+1;
                    j++;
                }
                if (uc.Count == k)
                {
                    if (max < j - i+1)
                    {
                        max = j - i+1;
                    }
                }
                if(uc.Count > k)
                {
                    while (uc.Count> k)
                    {
                        uc.TryGetValue(s[i], out var currentcount);
                        uc[s[i]] = currentcount -1;
                        if (uc[s[i]] == 0)
                        {
                            uc.Remove(s[i]);
                        }
                        i++;
                    }
                    i++;
                    j++;
                }
            }
            foreach (var item in uc)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("max is: "+max);
        }
        public void mainn()
        {
            String S = "aabacbebebe"; 
            int K = 3;
        
            longestKSubstr(S, K);
        }
    }
}