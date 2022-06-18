using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                // Car input format -> "{model} {fuelAmount} {fuelConsumptionFor1km}"
                string[] carTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carTokens[0];
                double fuelAmount = double.Parse(carTokens[1]);
                double fuelConsumption = double.Parse(carTokens[2]); // Per kilomiter
                var newCar = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(newCar);
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                //command format -> "Drive {carModel} {amountOfKm}"
                string[] cmdTokens = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = cmdTokens[1];
                int distance = int.Parse(cmdTokens[2]);

                var searchedCar = cars.FirstOrDefault(c => c.Model == model);
                if (searchedCar == null)
                    continue;

                searchedCar.Drive(distance);
            }

            //print each car in this format -> "{model} {fuelAmount} {distanceTraveled}"

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}

