using System;
using System.Collections.Generic;

namespace _8.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read input
            string input = Console.ReadLine();
            Stack<char> parentheses = new Stack<char>();

            bool isBalanced = false;

            //Loop through the string
            for (int i = 0; i < input.Length; i++)
            {
                //take current parentheses
                char currChar = input[i];

                //check if the length is an even num
                //so we don't try to pop an empty stack and get a runtime error.
                if (input.Length % 2 != 0)
                {
                    break;
                }

                //check if the current character is an opening parentheses
                if (currChar == '(' || currChar == '[' || currChar == '{')
                {
                    parentheses.Push(currChar);
                }
                //for each closing parentheses we run a check to see if the last parentheses is an opening of the same type.
                //If we find one inbalanced bracket we break out of the loop and print the result.
                else if (currChar == ')')
                {
                    if (parentheses.Pop() == '(')
                    {
                        isBalanced = true;
                        continue;
                    }
                    isBalanced = false;
                    break;
                }
                else if (currChar == ']')
                {
                    if(parentheses.Pop() == '[')
                    {
                        isBalanced = true;
                        continue;
                    }
                    isBalanced = false;
                    break;
                }
                else if (currChar == '}')
                {
                    if (parentheses.Pop() == '{')
                    {
                        isBalanced = true;
                        continue;
                    }
                    isBalanced = false;
                    break;
                }
            }

            //if all the check pass true then we print Yes 
            if (isBalanced == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

