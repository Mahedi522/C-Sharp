namespace Tree
{
    class infixTopostfix_1C
    {
        public string infix;

        public infixTopostfix_1C(string s)
        {
            this.infix = s;
        }
        
        Stack<char>operators = new Stack<char>();
        int j = 0;
        int precedence(int symbol)
        {
            switch (symbol)
            {
                case '^':
                    return 3;
                case '*':
                case '/':
                    return 2;
                case '+':
                case '-':
                    return 1;
                default:
                    return 0;
            }
        }
        public void infixTopostfix_1M()
        {
            System.Console.WriteLine("Infix is: "+ infix);
            char[] postfix = new char[infix.Length];
            for (int i = 0; i < infix.Length; i++)
            {
                char symbol = infix[i];
                char next;
                
                switch(symbol)
                {
                    case ' ':
                        continue;
                    case'(' :
                        operators.Push(symbol);
                        break;
                    case ')':
                        while ((next = operators.Pop()) != '(')
                        {
                            postfix[j++] = next;
                        }
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '^':
                        while (operators.Count != 0 && precedence(operators.Peek()) >= precedence(symbol))
                        {
                            postfix[j++] = operators.Pop();
                        }
                        operators.Push(symbol);
                        break;
                    default:
                        postfix[j++] = symbol;
                        break;
                }
            }
            while(operators.Count != 0)
            {
                postfix[j++] = operators.Pop();
            }
            
            foreach (var item in postfix)
            {
                System.Console.Write(item);

            }
            string s = new string(postfix);
            System.Console.WriteLine("postfix is: "+s);
            evaluatePostfixC epc = new evaluatePostfixC(s);
            System.Console.Write("Result is: ");
            epc.evaluatePostfixM();
        }
        
    }
    
}