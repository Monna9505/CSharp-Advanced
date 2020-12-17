using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> ACollectionOfPokemon { get; set; }
        public Trainer(string name, Pokemon aCollectionOfPokemon)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.ACollectionOfPokemon = new List<Pokemon>();
        }

        public void AddBadge()
        {
            this.NumberOfBadges++;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            ACollectionOfPokemon.Add(pokemon);
        }
    }
}
