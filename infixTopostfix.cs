using System.Text;
namespace Tree
{
    class infixTopostfix
    {
        public string infix;

        public infixTopostfix(string st)
        {
            this.infix = st;
        }

        int precedence(char symbol)
        {
            switch (symbol)
            {
                case '^':
                    return 3;
                case '/':
                case '*':
                    return 2;
                case '+':
                case '-':
                    return 1;
                default:
                    return 0;
            }
        }

        public void infixTopostfixM()
        {
            System.Console.WriteLine(infix);
            // StringBuilder postfix = new StringBuilder();
            char[] postfix = new char[infix.Length];
            Stack<char> operators = new Stack<char>();

            int j = 0;
            foreach (var item in Enumerable.Range(0,infix.Length))
            {
                char symbol = infix[item],next;
                // if (char.IsLetter(symbol))
                // {
                //     postfix.Append(symbol);
                // }
                switch (symbol)
                {
                    case '(':
                        operators.Push(symbol);
                        break;
                    case ')' :
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
                    // case char.IsLetter(symbol) :
                    default :
                        postfix[j++] = symbol;
                        break;

                }

            }
            while (operators.Count != 0)
            {
                postfix[j++] = operators.Pop();
            }
            postfix[j] = '\0';
        
        foreach (var item in postfix)
        {
            System.Console.Write(item);
        }
        }
        
    }
    
}