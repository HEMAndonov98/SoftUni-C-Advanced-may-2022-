﻿using System;
namespace DefiningClasses
{
	public class Person
	{
        public Person()
        {
			this.Name = "No name";
			this.Age = 1;
        }
		public Person(int age) : this()
		{
			this.Age = age;
		}
        public Person(string name, int age)
        {
			this.Name = name;
			this.Age = age;
        }

		private string name;
		private int age;

        public string Name { get
			{
				return name;
			}
			set
            {
				name = value;
            }
		}
		public int Age
        {
			get { return age; }
			set { age = value; }
        }
    }
}

