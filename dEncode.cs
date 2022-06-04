namespace Enosis
{
    class dEncode
    {
        static string str = "10[a]2[bc]";
        Stack<int> s_number = new Stack<int>();
        Stack<string> s_word = new Stack<string>();
        Char[] charArray = str.ToCharArray();
        public void dEncodeM()
        {
            string word = "";
            int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                
                if (char.IsDigit(charArray[i]))
                {
                    num = (num * 10) + charArray[i] - '0';
                    // System.Console.WriteLine("digit is: "+ (charArray[i] - '0'));
                }
                else if (char.IsLetter(charArray[i]))
                {
                    word = word + charArray[i];
                }
                else if (charArray[i] == '[')
                {
                    s_word.Push(word);
                    word = "";
                    s_number.Push(num);
                    num = 0;
                }
                else
                {
                    word = string.Concat(Enumerable.Repeat(word , s_number.Pop()));
                    if (s_word.Count != 0)
                    {
                        word = s_word.Pop() + word; 
                    }
                    
                }
            }

            System.Console.WriteLine(word);
        }
    }
}