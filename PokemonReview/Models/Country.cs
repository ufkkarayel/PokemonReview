namespace PokemonReview.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string CountryName { get; set; }
        public ICollection<Owner> Owners { get; set; }
    }
}
