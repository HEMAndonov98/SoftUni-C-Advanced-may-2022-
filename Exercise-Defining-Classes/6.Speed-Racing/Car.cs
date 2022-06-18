using System;
namespace DefiningClasses
{
	public class Car
	{
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
			this.Model = model;
			this.FuelAmount = fuelAmount;
			this.FuelConsumption = fuelConsumption;
			this._traveledDistance = 0;
        }

		private string _model;
		private double _fuelAmount;
		private double _fuelConsumption; //Per kilomiter
		private double _traveledDistance;

		public string Model { get { return _model; } set { _model = value; } }
        public double FuelAmount { get { return _fuelAmount; } set { _fuelAmount = value; } }
        public double FuelConsumption { get { return _fuelConsumption; } set { _fuelConsumption = value; } }

		public void Drive(int distance)
        {
			double fuelNeeded = distance * this._fuelConsumption;
            if (fuelNeeded <= this._fuelAmount)
            {
				this._fuelAmount -= fuelNeeded;
				this._traveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            //"{model} {fuelAmount} {distanceTraveled}" format
            return $"{this._model} {this._fuelAmount:F2} {this._traveledDistance}";
        }
    }
}

