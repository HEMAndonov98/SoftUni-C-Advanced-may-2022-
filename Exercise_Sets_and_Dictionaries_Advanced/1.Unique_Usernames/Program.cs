using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<string> usernames = new List<string>();
        string exists = string.Empty;

        for (int i = 0; i < n; i++)
        {
            string username = Console.ReadLine();

            exists = usernames.FirstOrDefault(x => x.Contains(username));
            if (exists != null)
            {
                continue;
            }

            usernames.Add(username);
        }
        foreach (var name in usernames)
        {
            Console.WriteLine(name);
        }
    }
}

