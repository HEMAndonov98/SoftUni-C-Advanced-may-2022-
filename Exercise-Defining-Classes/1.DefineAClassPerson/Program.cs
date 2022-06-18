using System;
using _1.DefineAClassPerson;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var person1 = new Person() { Name = "Jhon", Age = 25 };
            var person2 = new Person("Alex", 15);
        }
    }
}

