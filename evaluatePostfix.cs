namespace Tree
{
    class evaluatePostfixC
    {
        public string postfix;
        public evaluatePostfixC(string pfix)
        {
            this.postfix = pfix;
        }
        public void evaluatePostfixM()
        {
            Stack<int> operands = new Stack<int>();
            for (int i = 0; i < postfix.Length; i++)
            {
                char symbol = postfix[i];
                if (symbol >= '0' && symbol <='9')
                {
                    operands.Push(symbol-'0');
                }
                else
                {
                    int operand1 = operands.Pop();
                    int operand2 = operands.Pop();

                    switch (symbol)
                    {
                        case '+':
                        int result = operand2 + operand1;
                        operands.Push(result);
                            break;
                        case '-':
                        result = operand2 - operand1;
                        operands.Push(result);
                            break;
                        case '*':
                        result = operand2 * operand1;
                        operands.Push(result);
                            break;
                        case '/':
                        result = operand2 / operand1;
                        operands.Push(result);
                            break;
                        case '^':
                        result = operand2 ^ operand1;
                        operands.Push(result);
                            break;
                        
                    }
                }
            }
            System.Console.WriteLine(operands.Pop());
        }
    }
}