﻿namespace PokemonReview.Models
{
    public class Owner
    {
        public int ID { get; set; }
        public string OwnerName { get; set; }
        public string Gym { get; set; }
        public Country Country { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }

    }
}
