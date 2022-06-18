using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            var person2 = new Person(2);
            var person3 = new Person("Caleb", 16);
        }
    }
}
