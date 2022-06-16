using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            var tiresList = AddTires();
            var engines = AddEngines();
                

            var cars = new List<Car>();
            string carCmd;
            while ((carCmd = Console.ReadLine()) != "Show special")
            {
                string[] tokens = carCmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);


                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tiresList[tiresIndex]));
            }


            cars = cars.Where(x => x.Year >= 2017 &&
            x.Engine.HorsePower > 330 &&
            x.Tires.Select(y => y.Pressure).Sum() > 9 &&
            x.Tires.Select(y => y.Pressure).Sum() < 10)
                .ToList();

            foreach (var car in cars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }

        
        public static List<Tire[]> AddTires()
        {
            var tiresList = new List<Tire[]>();
            string tiresCmd;
            int listIndex = -1;
            while ((tiresCmd = Console.ReadLine()) != "No more tires")
            {
                listIndex++;
                string pattern = @"\d \d.\d";
                var mathes = Regex.Matches(tiresCmd, pattern);
                tiresList.Add(new Tire[mathes.Count]);

                int tireIndex = 0;
                foreach (var match in mathes)
                {
                    string[] tireParams = match.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    tiresList[listIndex][tireIndex] = new Tire(int.Parse(tireParams[0]), double.Parse(tireParams[1]));
                    tireIndex++;
                }
            }
            return tiresList;
        }
        public static List<Engine> AddEngines()
        {
            var engines = new List<Engine>();
            string engineCmd;
            while ((engineCmd = Console.ReadLine()) != "Engines done")
            {
                string[] tokens = engineCmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                engines.Add(new Engine(int.Parse(tokens[0]), double.Parse(tokens[1])));
            }
            return engines;
        }
    }
}

