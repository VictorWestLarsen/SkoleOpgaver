using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex57_StacksAndQueues
{
    public class Calculator
    {

        internal static int Prec(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }
        private static string ParseInfixToPostFix(string expression)
        {
            string result = "";
            Stack<char> operators = new Stack<char>();

            foreach (char c in expression)
            {
                //if (c == ' ') continue;
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }
                else if (c == '(')
                {
                    operators.Push(c);
                }
                else if (c == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        result += operators.Pop();
                    }
                    if (operators.Count > 0 && operators.Peek() != '(')
                    {
                        return "Invalid Expression";
                    }
                    else if (operators.Count > 0)
                    {
                        operators.Pop();
                    }
                }
                else
                {
                    while (operators.Count > 0 && Prec(c) <= Prec(operators.Peek()) && Prec(operators.Peek()) != -1)
                    {
                        result += operators.Pop();
                    }
                    result += " ";
                    operators.Push(c);
                }
            }

            while (operators.Count > 0 )
            {
                result += operators.Pop();
            }
            return result;

        }
        public static double Calculate(string expression)
        {
            Stack<double> operands = new Stack<double>();
            string tmp;
            double operand;

            expression = ParseInfixToPostFix(expression);

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ') continue;
                if (char.IsDigit(expression[i]))
                {
                    tmp = string.Empty;
                    while (char.IsDigit(expression[i]) && expression[i] != ' ')
                    {
                        tmp += expression[i];
                        i++;
                    }
                    operand = double.Parse(tmp);
                    operands.Push(operand);
                    i--;

                }
                else
                {
                    double digit1, digit2;
                    digit2 = operands.Pop();
                    digit1 = operands.Pop();
                    switch (expression[i])
                    {
                        case '+':
                            operands.Push(digit1 + digit2);
                                break;
                        case '-':
                            operands.Push(digit1 - digit2);
                            break;
                        case '*':
                            operands.Push(digit1 * digit2);
                            break;
                        case '/':
                            operands.Push(digit1 / digit2);
                            break;
                        case '^':
                            operands.Push(Math.Pow(digit1,digit2));
                            break;
                    }
                }
            }
            return operands.Pop();             
        }
    }
}
