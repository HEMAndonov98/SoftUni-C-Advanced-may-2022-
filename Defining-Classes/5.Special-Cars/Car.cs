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
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
            Engine engine, Tire[] tires)
        : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        private string _make;
        private string _model;
        private int _year;
        private double _fuelQty;
        private double _fuelConsumption;
        private Engine _engine;
        private Tire[] _tires;

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
        public Engine Engine
        {
            get
            {
                return _engine;
            }
            set
            {
                _engine = value;
            }
        }
        public Tire[] Tires
        {
            get
            {
                return _tires;
            }
            set
            {
                _tires = value;
            }
        }

        public void Drive(double distance)
        {
            this._fuelQty -= (this._fuelConsumption / 100) * distance;
        }
        public string WhoAmI()
        {
            return $"Make: {this._make}\nModel: {this._model}\nYear: {this._year}\nHorsePowers: {this._engine.HorsePower}\nFuelQuantity: {this._fuelQty:F1}";
        }
    }
}

