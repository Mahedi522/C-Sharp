using System.Text;

namespace Enosis
{
    class Wrapc
    {
        public void wrapm(){
            string str = "The unmo ulated wave has a higher frequrequencies up too., any bands so that different uses can be accommodated without interfering with each other.";
            // string news = "A word is defined as a character sequence consisting of non-space characters only.";
            StringBuilder sb = new StringBuilder(str);
            sb.Append(" Hi This is raj");
            // String[] words = news.Split(" ");
            // foreach(String word in words){
            //     System.Console.WriteLine(word.Length);
            // }
            int n = 15;
            System.Console.WriteLine(sb.Length);
            for (int i = n; i < sb.Length-1; i+=n)
            {
                // System.Console.WriteLine("i is: "+i);
                if (sb[i] == '.'|| sb[i] == ',')
                {
                    
                    // sb[i+1]='\n';
                    sb.Insert(i+1,"\n");
                    i = i+1;
                }
                
                else if (sb[i+1] == ' ')
                {
                    
                    sb[i+1]='\n';
                    i = i+1;
                }
                
                else
                {
                    for (int j = i ; j>i-n ;j=j-1)
                    {
                        // System.Console.WriteLine("j is: "+j);
                        if (sb[j] == ' ')
                        {
                        
                        // sb.Insert(j,"\n");
                        sb[j]='\n';
                        i = j;
                        break;
                        
                    }
                    }
                }
                
            }
            System.Console.WriteLine(sb);
        }
    }
}