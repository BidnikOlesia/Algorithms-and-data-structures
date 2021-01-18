using System;
using System.Collections.Generic;

namespace Homeworks
{
    public class Postfix
    {
        public static int Priority(char op)
        {
            switch (op)
            {
                case '*':
                case '/':
                    return 2;
                case '+':
                case '-':
                    return 1;
            }
            return 0;
        }

        public static void InfixToPostfix(string infix)
        {
            Console.WriteLine($"Инфиксная запись: {infix}");
            char[] infixArray = infix.ToCharArray();
            Queue<char> queue1 = new Queue<char>();
            Stack<char> stack3 = new Stack<char>();

            for (int i = 0; i < infixArray.Length; i++)
            {
                if (Char.IsDigit(infixArray[i]))
                    queue1.Enqueue(infixArray[i]);
                else if (infixArray[i] == '+' || infixArray[i] == '-' || infixArray[i] == '*' || infixArray[i] == '/')
                {
                    if (stack3.Count == 0 || stack3.Peek() == '(')
                        stack3.Push(infixArray[i]);
                    else if (Priority(infixArray[i]) > Priority(stack3.Peek()))
                        stack3.Push(infixArray[i]);
                    else if (Priority(infixArray[i]) <= Priority(stack3.Peek()))
                    {
                        for (int j = 0; j < stack3.Count; j++)
                        {
                            if (Priority(stack3.Peek()) > Priority(infixArray[i]))
                                queue1.Enqueue(stack3.Pop());
                            else if (Priority(stack3.Peek()) < Priority(infixArray[i]) || stack3.Peek() == '(')
                                break;
                        }
                        stack3.Push(infixArray[i]);
                    }

                }
                else if (infixArray[i] == '(')
                    stack3.Push(infixArray[i]);
                else if (infixArray[i] == ')')
                {
                    for (int j = 0; j < stack3.Count; j++)
                    {
                        char p = stack3.Pop();
                        if (p == '(')
                            break;
                        else
                            queue1.Enqueue(p);
                    }
                }
            }
            for (int j = 0; j < stack3.Count; j++)
                queue1.Enqueue(stack3.Pop());

            Console.Write($"Постфиксная запись: ");
            foreach (var row in queue1)
                Console.Write(row);
            Console.WriteLine();
        }
    }
}
