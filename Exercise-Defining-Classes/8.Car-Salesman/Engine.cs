using System;

namespace DefiningClasses
{
	public class Engine
	{
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, int power, int dissplacement) :this(model, power)
        {
            this.Dissplacement = dissplacement;
        }
        public Engine(string model, int power, string efficiency) :this(model, power)
        {
            this.Efficieny = efficiency;
        }
        public Engine(string model, int power, int dissplacement, string efficiency) :this(model, power)
        {
            this.Dissplacement = dissplacement;
            this.Efficieny = efficiency;
        }

		private string _model;
		private int _power;
		private int _displacement = -1;
		private string _efficieny = "n/a";

        public string Model { get { return _model; } set { _model = value; } }
        public int Power { get { return _power; } set { _power = value; } }
        public int Dissplacement { get { return _displacement; } set { _displacement = value; } }
        public string Efficieny { get { return _efficieny; } set { _efficieny = value; } }

    }
}

