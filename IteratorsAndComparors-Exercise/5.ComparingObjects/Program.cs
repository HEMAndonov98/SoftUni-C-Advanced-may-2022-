using System;
using System.Collections.Generic;

namespace _5.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            string lines;
            while ((lines = Console.ReadLine()) != "END")
            {
                //{name} {age} {town}
                var personArgs = lines.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(personArgs[0], int.Parse(personArgs[1]), personArgs[2]));
            }

            int personToCompare = int.Parse(Console.ReadLine()) - 1;
            var comparor = people[personToCompare];

            int numberOfMatches = 0;
            int numberOfNonMatches = 0;
            int numberOfPeople = people.Count;
            foreach (var peron in people)
            {
                if (comparor.CompareTo(peron) == 0)
                {
                    numberOfMatches++;
                    continue;
                }
                numberOfNonMatches++;
            }

            //"{count of matches} {number of not equal people} {total number of people}"
            if (numberOfMatches > 1)
            {
                Console.WriteLine($"{numberOfMatches} {numberOfNonMatches} {numberOfPeople}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}

