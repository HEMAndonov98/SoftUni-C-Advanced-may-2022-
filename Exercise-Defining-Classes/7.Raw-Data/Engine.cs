using System;

namespace DefiningClasses
{
	public class Engine
	{
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

		private int speed;
		private int power;

        public int Speed { get { return speed; } set { speed = value; } }
        public int Power { get { return power; } set { power = value; } }

    }
}

