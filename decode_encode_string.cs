using System.Text;
namespace Enosis
{
    class D_EncodeC
    {
        string str = "3[a2[bc]]";
        public void D_EncodeM()
        {
            Stack<int> countStack = new Stack<int>();
            Stack<string> wordStack = new Stack<string>();

            int number = 0;
            StringBuilder word = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (char.IsDigit(c))
                {
                    number = number * 10 + (c - '0');
                }
                else if (char.IsLetter(c))
                {
                    word.Append(c);
                }
                else if (c == '[')
                {
                    countStack.Push(number);
                    wordStack.Push(word.ToString());
                    number = 0;
                    word = new StringBuilder();
                }
                else
                {
                    int count = countStack.Pop();
                    StringBuilder duplicatedWord = new StringBuilder(wordStack.Pop());
                    for (int j = 1; j <= count; j++)
                    {
                        duplicatedWord.Append(word);
                    }
                    word = duplicatedWord;
                }
            }
            System.Console.WriteLine(word.ToString());
        }
    }
}