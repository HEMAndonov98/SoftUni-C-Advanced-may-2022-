using System;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this._fuelConsumption = 10;
        }
        public Car(string make, string model, int year)
        : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        private string _make;
        private string _model;
        private int _year;
        private double _fuelQty;
        private double _fuelConsumption;

        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        public double FuelQuantity { get
            {
                return _fuelQty;
            } set
            {
                _fuelQty = value;
            }
        }
        public double FuelConsumption { get
            {
                return _fuelConsumption;
            }
            set
            {
                _fuelConsumption = value;
            }
        }

        public void Drive(double distance)
        {
            if (this._fuelQty - (distance * _fuelConsumption) >= 0)
            {
                this._fuelQty -= distance * this._fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this._make}\nModel: {this._model}\nYear: {this._year}\nFuel: {this._fuelQty:F2}L";
        }
    }
}

