using System;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQty;
        private double fuelConsumption;

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public double FuelQuantity { get
            {
                return fuelQty;
            } set
            {
                fuelQty = value;
            }
        }
        public double FuelConsumption { get
            {
                return fuelConsumption;
            }
            set
            {
                fuelConsumption = value;
            }
        }

        public void Drive(double distance)
        {
            if (this.fuelQty - (distance * fuelConsumption) >= 0)
            {
                this.fuelQty -= distance * this.fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.make}\nModel: {this.model}\nYear: {this.year}\nFuel: {this.fuelQty:F2}L";
        }
    }
}

