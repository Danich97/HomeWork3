namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an mathematic expression:");
            string expression = Console.ReadLine();

            double result = Calculate(expression);

            Console.WriteLine("Result: " + result);
        }

        static double Calculate(string expression)
        {
            Stack<double> values = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]))
                {
                    string num = "";
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        num += expression[i];
                        i++;
                    }
                    values.Push(double.Parse(num));
                    i--;
                }
                else if (expression[i] == '(')
                {
                    operators.Push(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        values.Push(PerformOperation(operators.Pop(), values.Pop(), values.Pop()));
                    }
                    operators.Pop();
                }
                else if (IsOperator(expression[i]))
                {
                    while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(expression[i]))
                    {
                        values.Push(PerformOperation(operators.Pop(), values.Pop(), values.Pop()));
                    }
                    operators.Push(expression[i]);
                }
            }

            while (operators.Count > 0)
            {
                values.Push(PerformOperation(operators.Pop(), values.Pop(), values.Pop()));
            }

            return values.Pop();
        }

        static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        static int Precedence(char op)
        {
            if (op == '+' || op == '-')
                return 1;
            if (op == '*' || op == '/')
                return 2;
            return 0;
        }

        static double PerformOperation(char op, double b, double a)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b != 0)
                        return a / b;
                    else
                        throw new DivideByZeroException("Division by zero is not allowed.");
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }
    }
}
