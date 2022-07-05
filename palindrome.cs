namespace palindromeN
{
    class palindrome
    {
        public void isPalindrome(string text)
        {
            
            string c = string.Join("", text.ToCharArray().Reverse());
            foreach (var item in c)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
            if (c == text)
            {
                System.Console.WriteLine("palindrome");
            }
            else
            {
                System.Console.WriteLine("Not a palindrome");
            }
        }
        public void checkPalindrome(string str)
        {
            bool palindrome = true;
            int length = str.Length;
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[length - 1 - i])
                {
                    System.Console.WriteLine("Not Palindrome");
                    palindrome = false;
                    break;
                } 
            }
            if (palindrome == true)
            {
                System.Console.WriteLine("Is palindrome");
            }
        }
        public void mainn()
        {
            string text = "anana";
            isPalindrome(text);
            System.Console.WriteLine("----------------------------");
            checkPalindrome(text);
        }
    }
}