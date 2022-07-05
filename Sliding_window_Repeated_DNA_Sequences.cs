namespace SlidingWindow
{
    class Sliding_window_Repeated_DNA_Sequences
    {
        public IList<string> FindRepeatedDnaSequences(string s) 
        {
            int i = 0, j = -1;
            String str = "";
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<String> ls = new List<string>();
            if (s.Length < 10)
            {
                return ls;
            }
            while (j< s.Length)
            {
                if (j- i +1 < 10)
                {
                    System.Console.Write(s[j-i+1]);
                    System.Console.WriteLine("->"+(j-i+1));
                    j++;
                }
                


                if (j- i+1 == 10)
                {
                    str = s.Substring(j+1-10, 10);
                    if (dict.ContainsKey(str) && dict[str] == 1)
                    {
                        ls.Add(str);
                        dict.TryGetValue(str,out var currentcount);
                        dict[str] = currentcount + 1;
                    }
                    if (!dict.ContainsKey(str))
                    {
                        dict.Add(str, 1);
                    }
                    i++;
                    j++;
                }
            }
            return ls;
        }
        public void mainn()
        {
//             "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT" "ACGTACGTA"
// "AAAAAAAAAAAAA"
            string s = "AAAAAAAAAAAAA";
            foreach (var item in FindRepeatedDnaSequences(s))
            {
                System.Console.WriteLine(item);
            }
        }
        
    }
}