namespace LeetCode
{
    class Longest_Palindromic_Substring
    {
        public int IsPalindrome(string text)
        {
            
            string c = string.Join("", text.ToCharArray().Reverse());
            foreach (var item in c)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
            if (c == text)
            {
                // System.Console.WriteLine("palindrome");
                return 1;
            }
            else
            {
                // System.Console.WriteLine("Not a palindrome");
                return 0;
            }
        }
        public string LongestPalindrome(string s)
        {
            string mx = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j <=s.Length-i; j++)
                {
                    string st = s.Substring(i,j);
                    int result = IsPalindrome(st);
                    if (result == 1)
                    {
                        if (st.Length > mx.Length)
                        {
                            mx = st;
                            
                        }
                    }
                }
            }
            System.Console.WriteLine("mx is: "+ mx);
            return mx;
        }
        public void mainn()
        {
            string s = "anad";
            // string x =s.Substring(0,4);
            // System.Console.WriteLine("x is: "+x);
            LongestPalindrome(s);

        }
    }
}

