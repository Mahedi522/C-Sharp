namespace SlidingWindow
{
    class Sliding_Window_Minimum_Window_Substring
    {
        public string MinWindow(string s, string t) 
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int i = 0;
            while (i< t.Length)
            {
                if (!dict.ContainsKey(t[i]))
                {
                    dict.Add(t[i], 1);
                }
                else
                {
                    dict.TryGetValue(t[i], out var currentcount);
                    dict[t[i]] = currentcount + 1;
                }
                i++;
            }
            i = 0; int j = 0;
            String max = "";
            int count = dict.Count;
            System.Console.WriteLine(count);
            
            while (j < s.Length)
            {
                if (count > 0)
                {
                   if (dict.ContainsKey(s[j]))
                    {
                        dict.TryGetValue(s[j], out var currentcount);
                        dict[s[j]] = currentcount - 1;
                        
                        if (dict[s[j]] == 0)
                        {
                            count = count - 1;
                        }
                    } 
                }
                if (count == 0)
                {  
                    while (count != 1 && i < s.Length)
                    {
                        if (dict.ContainsKey(s[i]))
                        {
                            dict.TryGetValue(s[i], out var currentcount);
                            dict[s[i]] = currentcount + 1;
                            
                            if (max == "" || max.Length > j-i+1)
                            {
                                max = s.Substring(i,j-i+1);
                            }
                            if (dict[s[i]] > 0)
                            {
                                count = count + 1;
                            }
                        }
                        i++;
                    }
                }
                j++; 
            }   
            return max;         
        }
        public void mainn()
        {
            String s = "adarg", t = "aa";
            System.Console.WriteLine(MinWindow(s, t));
        }
    }
}