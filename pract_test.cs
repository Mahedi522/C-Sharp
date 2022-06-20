using System.Text;
namespace LeetCode
{
    class LongestSubstring
    {
        // public void LengthOfLongestSubstring(string s) 
        // {
        //     int max = 0;
        //     for (int i = 0; i < s.Length; i++)
        //     {
                
        //         int count = 0;
        //         for (int j = i; j < s.Length; j++)
        //         {
        //             if (j == i)
        //             {
        //                 count++;
        //             }
        //             else if (s[j] != s[i])
        //             {
        //                 count++;
        //                 if (i == s.Length)
        //                 {
        //                     if (count>max)
        //                     {
        //                         max = count;
        //                     }
        //                 }
        //             }
        //             else if(s[i] == s[j])
        //             {
        //                 if (count>max)
        //                 {
        //                     max = count;
        //                 }
        //                 break;
        //             }
        //         }
                
        //     }
        //     System.Console.WriteLine(max);
        // }
        public void LengthOfLongestSubstring(string s) 
        {
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                for (int j = i; j < s.Length; j++)
                {
                    if (s[i] != sb[j])
                    {
                        sb.Append(s[i]);
                    }
                }
            }
        }
        public void mainn()
        {
            string s = "abbb";
            LengthOfLongestSubstring(s);

        }
    }
}


