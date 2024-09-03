using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Stack<T>
    {
        T[] data;
        int top;
        public Stack(int size)
        {
            data = new T[size];
            top = -1;
        }

        public void Push(T val)
        {
            if(top == data.Length - 1)
            {
                Console.WriteLine("Out of range");
            } else
            {
                this.data[++top] = val;
            }
        }

        public T Pop()
        {
            if(top <= -1)
            {
                Console.WriteLine("Stack is Empty...");
                return default;
            }
            return data[top--];
        }

        public T Peek()
        {
            if (top <= -1)
            {
                Console.WriteLine("Stack is Empty...");
                return default;
            }
            return data[top];
        }

        public bool IsEmpty()
        {
            return top <= -1 ? true : false;
        }

        public void Print()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.Write($"{data[i]}, ");
            }
        }
    }

    static class StackProblems
    {
        public static string ReverseStringUsingStack(string str)
        {
            Stack<char> stackStr = new Stack<char>(str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                stackStr.Push(str[i]);
            }

            string reversedString = "";
            for (int i = 0; i < str.Length; i++)
            {
                reversedString += stackStr.Pop();
            }

            return reversedString;
        }

        public static bool BalancedBrackets(string str)
        {
            Stack<char> stackStr = new Stack<char>(str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{' || str[i] == '(' || str[i] == '[')
                {
                    stackStr.Push(str[i]);
                }

                if (str[i] == '}')
                {
                    if (stackStr.Peek() == '{')
                    {
                        stackStr.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

                if (str[i] == ')')
                {
                    if (stackStr.Peek() == '(')
                    {
                        stackStr.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

                if (str[i] == ']')
                {
                    if (stackStr.Peek() == '[')
                    {
                        stackStr.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }



            return stackStr.IsEmpty();
        }

        //public static string InFixToPostFix(string str)
        //{
        //    if (str.Length <= 0) return "";
        //    string result = "";
        //    Stack<char> stackChar = new Stack<char>(str.Length);
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        switch (str[i])
        //        {
        //            case '(':
        //                string subStr = "";
        //                for (int j = i+1; j < str.Length; j++)
        //                {
        //                    if(str[j] == ')')
        //                    {
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        subStr += str[j];
        //                    }
        //                }
        //                result += InFixToPostFix(subStr);
        //                i += subStr.Length + 1;
        //                break;

        //            case '+':
        //            case '-':
        //                if(!stackChar.IsEmpty())
        //                {
        //                    if( stackChar.Peek() != '/' && stackChar.Peek() != '*')
        //                    {
        //                        stackChar.Push(str[i]);
        //                    }
        //                    else
        //                    {
        //                        result += stackChar.Pop();
        //                        stackChar.Push(str[i]);
        //                    }

        //                } else
        //                {
        //                stackChar.Push(str[i]);
        //                }
        //                break;
        //            case '*':
        //            case '/':
        //                if (!stackChar.IsEmpty())
        //                {
        //                    if (stackChar.Peek() == '+' || stackChar.Peek() == '-')
        //                    {
        //                        stackChar.Push(str[i]);
        //                    }
        //                    else
        //                    {
        //                        result += stackChar.Pop();
        //                        stackChar.Push(str[i]);
        //                    }

        //                }
        //                else
        //                {
        //                    stackChar.Push(str[i]);
        //                }
        //                break;
        //            default:
        //                result += str[i];
        //                break;

        //        }
        //    }

        //    while (!stackChar.IsEmpty()) result += stackChar.Pop();
        //    return result;
        //}

        public static string InFixToPostFix(string str)
        {
            if (str.Length <= 0) return "";

            string result = "";
            Stack<char> stackChar = new Stack<char>(str.Length);

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (char.IsLetterOrDigit(c))
                {
                    // Operand: Directly add to result
                    result += c;
                }
                else if (c == '(')
                {
                    // Push '(' to stack
                    stackChar.Push(c);
                }
                else if (c == ')')
                {
                    // Pop from stack until '(' is found
                    while (!stackChar.IsEmpty() && stackChar.Peek() != '(')
                    {
                        result += stackChar.Pop();
                    }
                    stackChar.Pop(); // Remove '(' from stack
                }
                else if (IsOperator(c))
                {
                    // Operator: Pop from stack until an operator with less precedence is found
                    while (!stackChar.IsEmpty() && Precedence(c) <= Precedence(stackChar.Peek()))
                    {
                        result += stackChar.Pop();
                    }
                    stackChar.Push(c);
                }
            }

            // Pop all the operators left in the stack
            while (!stackChar.IsEmpty())
            {
                result += stackChar.Pop();
            }

            return result;
        }

        private static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '^';
        }

        private static int Precedence(char c)
        {
            switch (c)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return -1;
            }
        }


        public static int CalculateRPN(string PostFix)
        {
            Stack<int> stack = new Stack<int>(PostFix.Length);

            for (int i = 0; i < PostFix.Length; i++)
            {
                char c = PostFix[i];
                if (char.IsWhiteSpace(c)) continue;
                if (char.IsNumber(c))
                {
                    stack.Push(c - '0');
                }
                else
                {
                    int num1 = stack.Pop();
                    int num2 = stack.Pop();

                    switch (c)
                    {
                        case '+':
                            stack.Push(num2 + num1);  // num2 first, then num1
                            break;
                        case '-':
                            stack.Push(num2 - num1);  // num2 first, then num1
                            break;
                        case '*':
                            stack.Push(num2 * num1);  // num2 first, then num1
                            break;
                        case '/':
                            stack.Push(num2 / num1);  // num2 first, then num1
                            break;
                        case '^':
                            stack.Push((int)Math.Pow(num2, num1));  // num2 first, then num1
                            break;
                        default:
                            throw new InvalidOperationException($"Invalid operator {c}");
                    }
                }
            }

            return stack.Pop();
        }
    }
}
