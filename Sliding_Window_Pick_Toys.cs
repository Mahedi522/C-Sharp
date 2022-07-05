namespace SlidingWindow
{
    class Sliding_Window_Pick_Toys
    {
        public void toyCount(string str, int k)
        {        
            int i = 0, j = 0, max = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            if (str.Length < 2)
            {
                max = str.Length;
            }
            while (j < str.Length)
            {
                // if(dict.Count < k)
                // {
                    if (!dict.ContainsKey(str[j]))
                    {
                        dict.Add(str[j], 1);
                    }
                    else if(dict.ContainsKey(str[j]))
                    {
                        dict.TryGetValue(str[j], out var currentcount);
                        dict[str[j]] = currentcount + 1;
                    }
                // }
                if (dict.Count == k)
                {
                    if (max < j- i+1)
                    {
                        max = j-i+1;
                    }
                }
                else if (dict.Count > k)
                {
                    if (dict.ContainsKey(str[i]))
                    {
                        if (dict[str[i]] == 1)
                        {
                            dict.Remove(str[i]);
                        }
                        else if (str[i] > 1)
                        {
                            dict.TryGetValue(str[i], out var currentcount);
                            dict[str[i]] = currentcount - 1;
                        }
                    }
                    i++;
                    
                }
                j++;
            }
            System.Console.WriteLine(max);
        }
        public void mainn()
        {
            string str = "a";
            int n = 2;
            toyCount(str, n);
        }
    }
}