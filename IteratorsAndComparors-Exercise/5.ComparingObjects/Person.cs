using System;
using System.Diagnostics.CodeAnalysis;

namespace _5.ComparingObjects
{
	public class Person : IComparable<Person>  
	{
		private string name;
		private int age;
		private string town;

		public Person(string name, int age, string town)
		{
			this.Name = name;
			this.Age = age;
			this.Town = town;
		}

		public string Name { get { return this.name; } set { this.name = value; } }
		public int Age { get { return this.age; } set { this.age = value; } }
		public string Town { get { return this.town; } set { this.town = value; } }

        public int CompareTo([AllowNull] Person other)
        {
			int result = this.name.CompareTo(other.name);
            if (result == 0)
            {
				result = this.age.CompareTo(other.age);
            }

            if (result == 0)
            {
				this.town.CompareTo(other.town);
            }
          
			return result;
		}
    }
}

