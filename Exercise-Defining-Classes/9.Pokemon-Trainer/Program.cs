using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();
            string line;
            while ((line = Console.ReadLine()) != "Tournament")
            {
                //Format:
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                string[] tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                var existingTrainer = trainers.FirstOrDefault(t => t.Name == trainerName);

                //If no trainer with the given name exists
                if (existingTrainer == null)
                {
                    //We create a new object Trainer with the name given in the input
                    var newTrainer = new Trainer(trainerName);
                    //We add it to our list
                    trainers.Add(newTrainer);
                    //And we add the first pokemon to him
                    newTrainer.AddPokemon(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    continue;
                }

                //In this case trainer is not null (there is such a trainer with the name given)
                //We just add to him the pokemon given in the input
                existingTrainer.AddPokemon(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

            }

            while ((line = Console.ReadLine()) != "End")
            {
                CheckTrainers(trainers, line);
            }

            Action<List<Trainer>> printTrainers = trainers =>
            {
                trainers = trainers.OrderByDescending(t => t.Badges).ToList();

                foreach (var trainer in trainers)
                {
                    Console.WriteLine(trainer);
                }
            };
            printTrainers(trainers);

           
        }

        private static void CheckTrainers(List<Trainer> trainers, string line)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.CheckElement(line))
                {
                    trainer.Addbadge();
                    continue;
                }
                trainer.TakeHealth();
            }
        }
    }
}
