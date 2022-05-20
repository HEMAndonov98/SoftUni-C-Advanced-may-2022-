using System;
using System.Collections.Generic;

namespace _6.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read input
            Queue<string> songsQueue = new Queue<string>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            while (songsQueue.Count > 0)
            {
                string[] inputParams = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = inputParams[0];

                if (command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command == "Add")
                {
                    //create a string with the name of the song by turning the command into an empty string
                    //and then joining the remaining sentances with a space separator
                    //p.s you have to remove the white space which is after the command.
                    inputParams[0] = string.Empty;
                    string songToAdd = string.Join(' ', inputParams).TrimStart();
                    //Check if the queue already contains the song
                    if (songsQueue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                        continue;
                    }

                    songsQueue.Enqueue(songToAdd);
                }
                else if (command == "Show")
                {
                    //print all songs
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}

