namespace PokemonReview.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
