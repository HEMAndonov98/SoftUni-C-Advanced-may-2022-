using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] personParams = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(personParams[0], int.Parse(personParams[1]));
                people.Add(person);
            }

            people = people.Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }
    }
}