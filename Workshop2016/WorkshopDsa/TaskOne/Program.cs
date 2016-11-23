using System;
using System.Collections.Generic;

namespace TaskOne
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var current = input[i];
                int parsed;
                if (!int.TryParse(current, out parsed))
                {
                    int firstOperand = stack.Pop();
                    int secondOperand =stack.Pop();

                    switch (current)
                    {
                        case "+": stack.Push( secondOperand + firstOperand); break;
                        case "-": stack.Push( secondOperand - firstOperand); break;
                        case "*": stack.Push( secondOperand * firstOperand); break;
                        case "/": stack.Push( secondOperand / firstOperand); break;
                        case "&": stack.Push( secondOperand & firstOperand); break;
                        case "|": stack.Push( secondOperand | firstOperand); break;
                        case "^": stack.Push( secondOperand ^ firstOperand); break;
                        default: throw new ArgumentException("Invalid operator");
                    }
                }
                else
                {
                    stack.Push(int.Parse(current.ToString()));
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}