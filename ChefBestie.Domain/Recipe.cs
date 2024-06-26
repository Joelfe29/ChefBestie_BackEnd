using Newtonsoft.Json;

namespace ChefBestie.Domain
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Difficulty { get; set; }

        public string TimeToMake { get; set; }

        public bool IsApproved { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
