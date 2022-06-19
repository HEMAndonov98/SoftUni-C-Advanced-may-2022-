using System;

namespace DefiningClasses
{
	public class Car
	{
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
			this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

		private string model;
		private Engine engine;
		private Cargo cargo;
		private Tire[] tires = new Tire[4];


        public string Model { get { return model; } set { model = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Cargo Cargo { get { return cargo; } set { cargo = value; } }
        public Tire[] Tires { get { return tires; } set { tires = value; } }

        public override string ToString()
        {
            return $"{this.model}";
        }
    }
}

