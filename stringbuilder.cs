using System.Text;
namespace stringbuildern
{
    class Stringbuilderc
    {


        public void stringbuilderm()
        {
        StringBuilder sb = new StringBuilder("1st text");
        sb.Append("2nd text");
        sb.AppendLine("new line");
        sb.Append('-',6);

        sb.Replace("line","lineeeeeeee");
        System.Console.WriteLine(sb); 
        sb.Remove(0,5);
        sb.Insert(8,"Hi");
        System.Console.WriteLine(sb);
        
        System.Console.WriteLine(sb[4]);
        System.Console.WriteLine(sb.Length);
        System.Console.WriteLine(sb[4].GetType());
        
        if (sb[6] == ' ')
                {
                    System.Console.WriteLine("Its a space");
                }

        }
        
    }

}