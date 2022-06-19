using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            //Format
            //"0 {model}
            //1 {engineSpeed} 2 {enginePower}
            //3 {cargoWeight} 4 {cargoType}
            //5 {tire1Pressure} 6 {tire1Age} 7 {tire2Pressure} 8 {tire2Age} 9 {tire3Pressure} 10 {tire3Age} 11 {tire4Pressure} 12 {tire4Age}"
            //All in one line!!!

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];

                Engine newEngine = CreateEngine(tokens);
                Cargo newCargo = CreateCargo(tokens);
                Tire[] tires = AddTires(tokens);

                var newCar = new Car(model, newEngine, newCargo, tires);
                cars.Add(newCar);
            }

            PrintOutput(cars, Console.ReadLine());
        }
        private static Engine CreateEngine(string[] tokens)
        {
            int engineSpeed = int.Parse(tokens[1]);
            int enginePower = int.Parse(tokens[2]);
            var newEngine = new Engine(engineSpeed, enginePower);
            return newEngine;
        }
        private static Cargo CreateCargo(string[] tokens)
        {
            int cargoWeight = int.Parse(tokens[3]);
            string cargoType = tokens[4];
            var newCargo = new Cargo(cargoType, cargoWeight);
            return newCargo;
        }
        private static Tire[] AddTires(string[] tokens)
        {
            Tire[] tires = new Tire[4];
            int tireIndex = 0;
            //This way we only read 4 tires as in the description and there is no chance to go outside of the index of tires
            for (int j = 0; j < 8; j += 2)
            {
                // + 5 because 5 is the first variable representing the tire weight
                double tirePressure = double.Parse(tokens[j + 5]);
                // + 6 we take the variable next to the pressure
                int tireAge = int.Parse(tokens[j + 6]);

                var newTire = new Tire(tirePressure, tireAge);
                tires[tireIndex++] = newTire;
            }

            return tires;
        }
        private static void PrintOutput(List<Car> cars, string searchCommand)
        {
            Action<List<Car>> printCars = print =>
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            };

            if (searchCommand == "fragile")
            {
                cars = cars.Where(c => c.Cargo.Type == "fragile" &&
                c.Tires.Any(t => t.Pressure < 1))
                    .ToList();

                printCars(cars);
            }
            else if (searchCommand == "flammable")
            {
                cars = cars.Where(c => c.Cargo.Type == "flammable" &&
                c.Engine.Power > 250).ToList();

                printCars(cars);
            }
        }
    }
}
