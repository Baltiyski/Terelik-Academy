using System;

class XExpression
{
    static void Main(string[] args)
    {
        string expression = Console.ReadLine();

        decimal sum = 0;
        decimal bracketResult = 0;
        char currOperator = '+';
        char bracketOperator = '+';
        bool inBraket = false;

        foreach (var symbol in expression)
        {
            if (symbol == '(')
            {
                inBraket = true;
                continue;
            }
            if (symbol == ')')
            {
                inBraket = false;
                switch (currOperator)
                {
                    case '+':
                        sum += bracketResult;
                        break;
                    case '-':
                        sum -= bracketResult;
                        break;
                    case '*':
                        sum *= bracketResult;
                        break;
                    case '/':
                        sum /= bracketResult;
                        break;
                    default:
                        break;
                }
                bracketResult = 0;
                bracketOperator = '+';
            }

            if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
            {
                if (inBraket)
                {
                    bracketOperator = symbol;
                }
                else
                {
                    currOperator = symbol;
                }
            }

            if (char.IsDigit(symbol))
            {
                int currNum = symbol - '0';

                if (inBraket)
                {
                    switch (bracketOperator)
                    {
                        case '+':
                            bracketResult += currNum;
                            break;
                        case '-':
                            bracketResult -= currNum;
                            break;
                        case '*':
                            bracketResult *= currNum;
                            break;
                        case '/':
                            bracketResult /= currNum;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (currOperator)
                    {
                        case '+':
                            sum += currNum;
                            break;
                        case '-':
                            sum -= currNum;
                            break;
                        case '*':
                            sum *= currNum;
                            break;
                        case '/':
                            sum /= currNum;
                            break;
                        default:
                            break;
                    }
                } 
            }
        }
        Console.WriteLine("{0:F2}",sum);
    }
}
