﻿using System;
using System.Collections.Generic;
using System.Linq;
//The class need to be in the main program folder because otherwise the judge system won't recognize to use it
class Person
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; }
    public int Age { get; }

}
class FilterByAge
{
    static void Main()
    {
        
        List<Person> people = AddPeople();
        string condition = Console.ReadLine();
        int ageThreshold = int.Parse(Console.ReadLine());

        Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
        people = people.Where(filter).ToList();

        Action<Person> printer = CreateTemplate(Console.ReadLine());
        people.ForEach(printer);
    }
    private static List<Person> AddPeople()
    {
        List<Person> people = new List<Person>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0];
            int age = int.Parse(tokens[1]);

            var person = new Person(name, age);
            people.Add(person);
        }
        return people;
    }
    private static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
    {
        if (condition == "younger")
        {
            //this uses the return types in parameter in this case Person class to return a function based on conditions
            //and age threshold
            return x => x.Age < ageThreshold;
        }
        else if (condition == "older")
        {
            return x => x.Age >= ageThreshold;
        }

        throw new ArgumentException("Invalid parameters");
    }
    private static Action<Person> CreateTemplate(string format)
    {
        //Action is mainly used for void type methods like printing
        //this method returns a function based on which format parameter it has recived
        if (format == "name")
        {
            return p => Console.WriteLine($"{p.Name}");
        }
        else if (format == "age")
        {
            return p => Console.WriteLine($"{p.Age}");
        }
        else if (format == "name age")
        {
            return p => Console.WriteLine($"{p.Name} - {p.Age}");
        }

        throw new ArgumentException("The format provided is Invalid");
    }


}

