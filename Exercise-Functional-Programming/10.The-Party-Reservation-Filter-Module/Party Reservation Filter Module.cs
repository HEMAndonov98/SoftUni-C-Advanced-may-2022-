using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //Read list of names
        List<string> names = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        Action<List<string>> PRFM = names =>
        {
            //filters store the command parameters (filterType, variable)
            var filters = new Dictionary<string, string>();

            string command;
            while ((command = Console.ReadLine()) != "Print")
            {
                //Creating a key for the dictionary consisting of the filter type and variable
                string filterName = string.Join(' ', command.Split(';').Skip(1));
                if (command.StartsWith("Add filter"))
                {
                    //add filter
                    if (!filters.ContainsKey(filterName))
                    {
                        filters[filterName] = command;
                    }
                }
                else if (command.StartsWith("Remove filter"))
                {
                    //remove filter
                    filters.Remove(filterName);
                }
            }

            foreach (var (fName, fCmd) in filters)
            {
                //cmd -> Add filter;Starts with;P
                string cmd = fCmd;
                //Predicate function
                Func<string, bool> filter = name => CreateFilter(cmd, name);
                names.RemoveAll(n => filter(n));
            }
            //print output
            Console.WriteLine(String.Join(' ', names));
        };

        PRFM(names);
    }

    private static bool CreateFilter(string cmd, string name)
    {
        //here we create a custom filter for each of the filters requested
        string filterType = cmd.Split(';')[1].Trim();
        string param = cmd.Split(';')[2].Trim();
        if (filterType == "Starts with")
        {
            return name.StartsWith(param);
        }
        else if (filterType == "Ends with")
        {
            return name.EndsWith(param);
        }
        else if (filterType == "Length")
        {
            return name.Length == int.Parse(param);
        }
        else if (filterType == "Contains")
        {
            return name.Contains(param);
        }
        return false;
    }
}

