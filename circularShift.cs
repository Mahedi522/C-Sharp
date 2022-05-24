namespace Enosis
{
    class circularShiftC
    {
        public void circularShiftM()
        {
            //removing etra spaces
            string str = "Hello             World";
            System.Console.WriteLine("-------removing extra white space-------");
            System.Console.WriteLine(str);
            char[] charArray = str.ToCharArray();
            string str1 = string.Empty;            
            for (int i = 0; i < charArray.Length; i++)
            {
                if (str1 == string.Empty && charArray[i] == ' ')
                {
                    continue;
                }
                if (charArray[i] == ' ' && charArray[i+1] == ' ')
                {
                    continue;
                }
                else
                {
                    str1 = str1 + charArray[i];
                }
            }
            System.Console.WriteLine(str1);
            // Circular Shift
            System.Console.WriteLine("-------circular shift--------");
            char[] chars = str1.ToCharArray();
            char c = chars[0];
            for (int i = chars.Length-1; i >= 0; i--)
            {  
                if (i == chars.Length-1)
                {
                    chars[0] = chars[i];
                    chars[i] = chars[i-1];
                }
                else if (i > 1)
                {
                    chars[i] = chars[i-1];
                }
            }
            chars[1] = c;
            string s = string.Join("",chars);
            System.Console.WriteLine(s);
            
            //shortcut circular shift
            System.Console.WriteLine("--------circular shift shortcut--------");
            char[] char_ = str1.ToCharArray();
            if (char_.Length > 1)
            {
                var current = char_[0];
                var next = char_[0];
                for (int i = 0; i < char_.Length-1; i++)
                {
                    next = char_[i + 1];
                    char_[i + 1] = current;
                    current = next;
                }
                char_[0] = next;   
            }

            string sc = string.Join("",char_);
            System.Console.WriteLine(sc);
        }
        
    }
}