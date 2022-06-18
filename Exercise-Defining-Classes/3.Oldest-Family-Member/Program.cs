using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(tokens[0], int.Parse(tokens[1]));
                family.AddMember(person);
            }

            var oldestPerson = family.GetOldestMember();

            if (oldestPerson != null)
            {
                Console.WriteLine(oldestPerson);
            }
        }
    }
}