// using System.Text;
// namespace test
// {
//     class testC
//     {
//         int value;
//         public testC left;
//         public testC right;

//         public testC(int value)
//         {
//             this.value = value;
//         }
//         public void testM()
//         {

//             testC root = new testC(30);
//             testC n1 = new testC(25);
//             testC n2 = new testC(20);
//             testC n3 = new testC(35);
//             testC n4 = new testC(40);
            
//             root.left = n1;
//             root.right = n3;
//             n1.left = n2;
//             n2.right = n4;

//             System.Console.WriteLine(root.value);
//             System.Console.WriteLine(root.left.value);

//         }  
//             // StringBuilder stb = new StringBuilder();

//             // char[] ch = new char[10];

//             // foreach (var item in Enumerable.Range(0,10))
//             // {
//             //     stb[item] = Convert.ToChar(item);
//             //     stb[item] = 'a';
                
//             // }

            
//             // for (int i = 0; i < 10; i++)
//             // {
//             //     stb.Append('a');
//             //     ch[i] = 'b';
//             // }

//             // System.Console.WriteLine(stb.ToString());
//             // foreach (var item in stb)
//             // {
//             //     System.Console.WriteLine(item);
//             // }
//             // System.Console.WriteLine(stb);
//             // foreach (var item in ch)
//             // {
//             //     System.Console.WriteLine(item);
//             // }

//             // Stack<int> operands = new Stack<int>();
            
//             // char symbol = '8';
//             // if (symbol >= '0' && symbol <='9')
//             // {
//             //     operands.Push(symbol-'0');
//             // }

//             // System.Console.WriteLine(operands.Pop());

//         //     char[] x = new char[] {'a', 'b', 'c'};
//         //     string s = new string (x);
//         //     System.Console.WriteLine(s);
        
//         //  public void Search(testC root, testC node)
//         // {
//         // }

//     }
// }