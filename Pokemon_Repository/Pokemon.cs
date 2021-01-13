using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public class PokeTeam
    {
        public string teamName { get; set; }
        //public PokeTeam()
        //{    //TODO
        //    public PokeTeam(string a)
        //    {
        //        teamName = a;
        //    }
        //}
    }
    public enum PokemonType
    {
        Normal = 100,
        Grass,
        Fire,
        Water,
        Electric,
        Ice,
        Bug,
        Ground,
        Rock,
        Fighting,
        Psychic,
        Ghost,
        Dark,
        Fairy,
        Dragon,
        None
    }

    public class Pokemon
    {
        private string species;
        private string name;
        private PokemonType typeOne;
        private PokemonType typeTwo;

        public int TeamPosition { get; set; }
        public string PokemonSpeciesName { get; set; }
        public string PokemonNickName { get; set; }
        public int Level { get; set; }
        public string PokemonType { get; set; }
        public string SecondaryType { get; set; }
        public string MoveOne { get; set; }
        public string MoveTwo { get; set; }
        public string MoveThree { get; set; }
        public string MoveFour { get; set; }

        public Pokemon(int teamPosition, string speciesName, string NickName, int level, string pokemonType, string secondaryType, string moveOne, string moveTwo, string moveThree, string moveFour)
        {
            TeamPosition = teamPosition;
            PokemonSpeciesName = speciesName;
            PokemonNickName = NickName;
            Level = level;
            PokemonType = pokemonType;
            SecondaryType = secondaryType;
            MoveOne = moveOne;
            MoveTwo = moveTwo;
            MoveThree = moveTwo;
            MoveFour = moveFour;
        }

        public Pokemon(string species, string name, int level, PokemonType typeOne, PokemonType typeTwo, string moveOne, string moveThree, string moveFour)
        {
            this.species = species;
            this.name = name;
            Level = level;
            this.typeOne = typeOne;
            this.typeTwo = typeTwo;
            MoveOne = moveOne;
            MoveThree = moveThree;
            MoveFour = moveFour;
        }
    }
}
    







    
    

