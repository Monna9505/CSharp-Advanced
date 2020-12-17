using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string info = "";
            List<Trainer> trainerList = new List<Trainer>();

            while ((info = Console.ReadLine()) != "Tournament")
            {
                string[] splitted = info.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string trainerName = splitted[0];
                string pokemonName = splitted[1];
                string pokemonElement = splitted[2];
                int pokemonHealth = int.Parse(splitted[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer(trainerName, pokemon);

                if (trainerList.Any(n => n.Name == trainerName))
                {
                    var currentrainer = trainerList.First(n => n.Name == trainerName);
                    currentrainer.AddPokemon(pokemon);
                }
                else
                {
                    trainerList.Add(trainer);
                    trainer.AddPokemon(pokemon);
                }
            }

            string tournamentInfo = "";

            while ((tournamentInfo = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainerList)
                {
                    if (trainer.ACollectionOfPokemon.Any(n => n.Element == tournamentInfo))
                    {
                        trainer.AddBadge();
                    }
                    else
                    {
                        trainer.ACollectionOfPokemon.ForEach(n => n.LoseHealth());
                        trainer.ACollectionOfPokemon.RemoveAll(n => n.Health <= 0);
                    }
                }
            }

            trainerList = trainerList.OrderByDescending(n => n.NumberOfBadges).ToList();
            foreach (var item in trainerList)
            {
                Console.WriteLine($"{item.Name} {item.NumberOfBadges} {item.ACollectionOfPokemon.Count}");
            }
        }
    }
}
