using System;
using System.Collections.Generic;
using System.Linq;

class PredicateParty
{
    static void Main()
    {
        List<string> names = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        
        string command;
        while ((command = Console.ReadLine()) != "Party!")
        {
            Predicate<string> criteria = name =>
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string condition = tokens[1];
                if (condition == "StartsWith")
                {
                    return name.StartsWith(tokens[2]);
                }
                else if (condition == "EndsWith")
                {
                    return name.EndsWith(tokens[2]);
                }
                else if (condition == "Length")
                {
                    return name.Length == int.Parse(tokens[2]);
                }

                throw new ArgumentException("Invalid command");
            };
            Func<List<string>, List<string>> executeCommand = names =>
            {
                if (command.StartsWith("Double"))
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (criteria(names[i]))
                        {
                            names.Insert(i + 1, names[i]);
                            i++;
                        }
                    }
                }
                else if (command.StartsWith("Remove"))
                {
                    names.RemoveAll(criteria);
                }
                return names;
            };
            names = executeCommand(names);
        }
        Action<List<string>> printEveryoneGoing = x =>
        {
            if (x.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", x)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        };
        printEveryoneGoing(names);
    }
}

