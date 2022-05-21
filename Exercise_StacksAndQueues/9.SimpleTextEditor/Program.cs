using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read input
            int n = int.Parse(Console.ReadLine());

            Stack<char> edditorStack = new Stack<char>();
            //I save all the 1 and 2 commands with their arguments in a seperate stack
            Stack<string> undoos = new Stack<string>();
            StringBuilder sb = new StringBuilder();

            //loop through n(number of commands)
            for (int i = 0; i < n; i++)
            {
                //split the input into tokens
                string[] operationTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                //operation command argument
                int commandArg = int.Parse(operationTokens[0]);

                //Append argument

                if (commandArg == 1)
                {
                    //argument token
                    string text = operationTokens[1];

                    //llop through the text and add it to the text editor
                    for (int j = 0; j < text.Length; j++)
                    {
                        edditorStack.Push(text[j]);
                    }

                    //save my action in the undo stack
                    undoos.Push(text);
                    undoos.Push(commandArg.ToString());

                }

                //Erase count

                if (commandArg == 2)
                {
                    //number of elements to erase
                    int count = int.Parse(operationTokens[1]);

                    //loop through the count
                    for (int k = 0; k < count; k++)
                    {
                        //I apped to a stringbuilder the text i'm deleting from my editor
                        sb.Append(edditorStack.Pop());
                    }

                    //add the command and argument inside my undoo stack
                    undoos.Push(sb.ToString());
                    sb.Clear();
                    undoos.Push(commandArg.ToString());

                }

                //Print the element at the given index

                if (commandArg == 3) 
                {
                    //the stack has its the appednded string characteres in reverse
                    //to get the correct index simply subtract the desired element position from the count of the text.
                    int index = edditorStack.Count - int.Parse(operationTokens[1]);
                    Console.WriteLine(edditorStack.ElementAt(index));
                }

                //Undo the last not undone command

                if (commandArg == 4)
                {
                    //Pop the last "1" or "2" action from the undoo stack
                    commandArg = int.Parse(undoos.Pop());

                    //To undoo an append to the text editor delete the length of the characters added
                    if (commandArg == 1)
                    {
                        int textLength = undoos.Pop().Length;

                        for (int l = 0; l < textLength; l++)
                        {
                            edditorStack.Pop();
                        }
                    }
                    //To undoo a deletion of characteres append the deleted text back in the text editor
                    else if (commandArg == 2)
                    {
                        //example text "cba"
                        string textToReturn = undoos.Pop();
                        //loop backwards through the deleted text so you can add it back in the editor the corect way
                        //This way we return it to the stack "abc"
                        for (int x = textToReturn.Length - 1; x >= 0; x--)
                        {
                            edditorStack.Push(textToReturn[x]);
                        }
                    }
                }
            }
        }
    }
}

