﻿using System;
namespace CarManufacturer
{
	public class Tire
	{
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

		private int _year;
		private double _pressure;

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
		public double Pressure
        {
            get
            {
                return _pressure;
            }
            set
            {
                _pressure = value;
            }
        }
	}
}

