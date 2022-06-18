using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
	public class Family
	{
		private List<Person> family = new List<Person>();

		public void AddMember(Person person)
        {
			family.Add(person);
        }

		public Person GetOldestMember()
        {
			return family.OrderByDescending(person => person.Age).FirstOrDefault();
        }
    }

}

