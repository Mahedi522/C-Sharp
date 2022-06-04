using System.Text;
namespace test
{
    class testC
    {
        public void testM()
        {
            StringBuilder stb = new StringBuilder();

            char[] ch = new char[10];

            // foreach (var item in Enumerable.Range(0,10))
            // {
            //     stb[item] = Convert.ToChar(item);
            //     stb[item] = 'a';
                
            // }
            for (int i = 0; i < 10; i++)
            {
                stb.Append('a');
                ch[i] = 'b';
            }

            // System.Console.WriteLine(stb.ToString());
            // foreach (var item in stb)
            // {
            //     System.Console.WriteLine(item);
            // }
            System.Console.WriteLine(stb);
            foreach (var item in ch)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}