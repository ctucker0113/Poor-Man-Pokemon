using System;
using System.Collections.Generic;
using Poor_Man_Pokemon.Models; // Reference to the Pokemon model

namespace Poor_Man_Pokemon.Data
{
    public class PokemonSampleData
    {
        public static List<Pokemon> Pokedex = new List<Pokemon>
        {
            new Pokemon
            {
                ID = 1,
                Name = "Bulbasaur",
                Type = "Grass",
                HP = 40
            },

            new Pokemon
            {
                ID = 2,
                Name = "Charmander",
                Type = "Fire",
                HP = 40
            },

            new Pokemon
            {
                ID = 3,
                Name = "Squirtle",
                Type = "Water",
                HP = 40
            },

            new Pokemon
            {
                ID = 25,
                Name = "Pikachu",
                Type = "Electric",
                HP = 40
            },
        };
    }
}
