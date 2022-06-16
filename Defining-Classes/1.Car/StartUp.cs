using System;

namespace CarManufacturer
{
   public class StartUp
    {
        public static void Main()
        {
            var car = new Car();

            car.Make = "VW";
            car.Model = "Mk3";
            car.Year = 1992;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}

