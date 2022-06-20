using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var engines = new List<Engine>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //"{model} {power} {displacement} {efficiency}"
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var engine = BuildEngine(tokens);
                engines.Add(engine);
            }

            var cars = new List<Car>();
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                //"[0](string){model} [1](Engine){engine} [2](int){weight} [3](string){color}"
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var car = BuildCar(engines, tokens);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
        public static Engine BuildEngine(string[] tokens)
        {
            string model = tokens[0];
            int power = int.Parse(tokens[1]);
            int dissplacement;
            string efficiency = string.Empty;
            //Base parameter engine
            Engine engine = new Engine(model, power);

            //variant where one of the optional parameters is missing
            if (tokens.Length == 3)
            {
                if (!int.TryParse(tokens[2], out dissplacement))
                {
                    dissplacement = -1;
                    efficiency = tokens[2];
                }

                //if disspacement doesn't exist!!!
                if (dissplacement == -1)
                    engine = new Engine(model, power, efficiency);
                else //If disspacement is different from -1(it Exists)!!
                    engine = new Engine(model, power, dissplacement);
            }
            //variant where all the parameters are present
            else if (tokens.Length == 4)
            {
                dissplacement = int.Parse(tokens[2]);
                efficiency = tokens[3];
                engine = new Engine(model, power, dissplacement, efficiency);
            }
            return engine;
        }
        private static Car BuildCar(List<Engine> engines, string[] tokens)
        {
            //Necessary paramenters
            string model = tokens[0];
            var engine = engines.FirstOrDefault(e => e.Model == tokens[1]);
            var car = new Car(model, engine);

            int weight;
            string color = string.Empty;
            if (tokens.Length == 3)
            {
                if (!int.TryParse(tokens[2], out weight))
                {
                    weight = -1;
                    color = tokens[2];
                }

                //If weight = -1(doesn't exist)
                if (weight == -1)
                    car = new Car(model, engine, color);
                else //weight is different from -1(it exists)
                    car = new Car(model, engine, weight);
            }
            else if (tokens.Length == 4)
            {
                weight = int.Parse(tokens[2]);
                color = tokens[3];
                car = new Car(model, engine, weight, color);
            }
            return car;
        }

    }
}
