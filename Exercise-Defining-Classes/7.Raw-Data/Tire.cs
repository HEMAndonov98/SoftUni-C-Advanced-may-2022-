using System;

namespace DefiningClasses
{
	public class Tire
	{
        public Tire( double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }

		private double pressure;
		private int age;

        public double Pressure { get { return pressure; } set { pressure = value; } }
        public int Age { get { return age; } set { age = value; } }

    }
}

