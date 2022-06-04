using System.IO;
using System.Text;
namespace ds
{
    class stringC
    {
        public void stringM()
        {
            string message = "Hello, World!";
            //string is an array of chars
            for (int i = 0; i < message.Length; i++)
            {
                if (i>6 && i< 12)
                {
                    System.Console.Write(message[i]);
                }
            }
            System.Console.WriteLine();
            //but can't change string in c# in this way
            //message[7] = 'w';

            message = "The number to be parsed is: 123";

            //this creates a new string
            //substring, trim, Is NullOrWhitespace will also produce more strings

            string num = message.Substring(message.IndexOf(':') + 3);
            int.TryParse(num,out var a);
            System.Console.WriteLine(a);
            System.Console.WriteLine(a.GetType());

            //this does not create string copies
            ReadOnlySpan<char> msgSpan = message;
            ReadOnlySpan<char> numspan = msgSpan.Slice(msgSpan.IndexOf(':')+ 2);
            int.TryParse(numspan,out var b);
            System.Console.WriteLine(b);
            System.Console.WriteLine(b.GetType());

            string firstString = "Test string";
            string secondString = "Test string";

            System.Console.WriteLine(object.ReferenceEquals(firstString, secondString));


            // Memory<char> mem = MemoryMarshal.AsMemory(firstString.asMeomory());
            // mem.Span[5] = 'z';

            // System.Console.WriteLine(firstString);
            // System.Console.WriteLine(secondString);

            var sb = new StringBuilder();
            foreach (int i in Enumerable.Range(1, 10))
            {
                sb.Append(i.ToString());
            }
            System.Console.WriteLine(sb.ToString());
        }
    }
    
}