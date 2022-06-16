using System;
namespace CarManufacturer
{
	public class Engine
	{
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

		private int _horsePower;
		private double _cubicCapacity;

        public int HorsePower
        {
            get
            {
                return _horsePower;
            }
            set
            {
                _horsePower = value;
            }
        }
        public double CubicCapacity
        {
            get
            {
                return _cubicCapacity;
            }
            set
            {
                _cubicCapacity = value;
            }
        }
    }
}

