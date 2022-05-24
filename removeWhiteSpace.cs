using System.Text;
namespace WhiteSpace
{
    class whiteSpaceC
    {
        public void whiteSpaceM()
        {
            string str = "Hello        World";
            //List
            System.Console.WriteLine("--------------List--------------");
            List<string> ls = str.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
            string st = string.Join(" ",ls);
            foreach(var item in ls)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine(st);

            //charArray
            System.Console.WriteLine("----------------Char Array-----------------");
            if (string.IsNullOrEmpty(str))
            {
                System.Console.WriteLine("The string is empty");
            }

            int current = 0;
            char[] output = new char[str.Length];
            bool skipped = false;

            foreach (char item in str.ToCharArray())
            {
                if (char.IsWhiteSpace(item))
                {
                    if (!skipped)
                    {
                        if (current > 0)
                        {
                            output[current++] = ' ';
                            skipped = true;
                        }
                    } 
                }
                else
                {
                    skipped = false;
                    output[current++] = item;
            }    
            
            // foreach (var c in output)
            // {
            //     System.Console.WriteLine(c);
            // }  
            }
            string result = new string(output, 0, current);
            System.Console.WriteLine(result);  

            //stringBuilder
            // System.Console.WriteLine("------------------stringBuilder-----------------");
            // StringBuilder sb = new StringBuilder(str);
            // System.Console.WriteLine(sb);


            // for (int i = 0; i < sb.Length-1 ; i++)
            // {
            //     // System.Console.WriteLine("i is :"+sb[i]);
            //     if (sb[i] == ' ' && sb[i+1] == ' ')
            //     {
            //         sb.Remove(i,i);
            //     }
            //     // System.Console.WriteLine(sb[i]);
            // }

            // System.Console.WriteLine(sb);

            //chararray
            System.Console.WriteLine("----------char string-------------");
            var chars = str.ToCharArray();
            var str1 = string.Empty;
            // int x = 0;
            for (int i = 0; i < chars.Length ; i++)
            {    
                if (str1 == string.Empty && chars[i] == ' ')
                {
                    continue;
                }
                if (chars[i] == ' ' && chars[i+1] == ' ')
                {
                    continue;
                }
                else
                {
                    str1 = str1 + chars[i];
                }
            }
            System.Console.WriteLine(str1);
            // foreach (var eachchar in chars)
            // {
            //     if (eachchar !=' ')
            //     {
            //         str1 = str1 + eachchar;
            //     }
                
            //     if (eachchar == ' ' && x == 1)
            //     {
            //         x = 0;
            //         continue;
            //     }
            //     if (eachchar == ' ')
            //     {
            //         x = x+1;
            //         str1 = str1 + eachchar;
            //     }
            // }
        }
    }
    
}