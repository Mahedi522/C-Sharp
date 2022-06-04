namespace Enosis
{
    class ReverseC
    {
        
        public void ReverseM()
        {
            string str = "We are students.";
            
            // char[] charArray = str.ToCharArray();
            // Array.Reverse( charArray );
            // System.Console.WriteLine(charArray);
            // string x = new string(charArray);
            // // String charArray_ = Convert.ToString(charArray);
            // System.Console.WriteLine(x.GetType());
            

            char[] delimiters = new char[] {' ',',','.'};
            
            // foreach (var item in str.Split(delimiters))
            // {
            //     char[] chararray = item.ToCharArray();
            //     Array.Reverse(chararray);
            //     string rvs = new string(chararray);
            //     System.Console.WriteLine(rvs);   
            // }

            // By Stack
            // string s ="";
            // Stack<char> stC = new Stack<char>();
            // foreach (var item in str.Split(delimiters))
            // {
            //     char[] chararray = item.ToCharArray();
            //     for (int i = 0; i < item.Length; i++)
            //     {
            //         stC.Push(chararray[i]);
            //     }
            //     while (stC.Count != 0)
            //     {
            //         s = s + stC.Pop();
            //     }
            //     s = s + " ";    
            // }
            // System.Console.WriteLine(s);


            //only for
            
            string st = "";
            foreach (var item in str.Split(delimiters))
            {
                char[] ch = item.ToCharArray();
                
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    st =st+  ch[i];
                }
                st = st + " ";
            }
            System.Console.WriteLine(st);
        } 
    }    
}