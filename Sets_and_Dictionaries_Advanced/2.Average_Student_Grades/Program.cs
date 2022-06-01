using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<decimal>> gradeBook = new Dictionary<string, List<decimal>>();

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string studentName = tokens[0];
            decimal grade = decimal.Parse(tokens[1]);

            if (!gradeBook.ContainsKey(studentName))
            {
                gradeBook[studentName] = new List<decimal>();
            }

            gradeBook[studentName].Add(grade);
        }

        foreach (var (name, grades) in gradeBook)
        {
            Console.Write($"{name} -> ");

            foreach (var grade in grades)
            {
                Console.Write($"{grade:F2} ");
            }
            Console.WriteLine($"(avg: {grades.Average():F2})");
        }
    }
}



