using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefBestie.Domain
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Unity { get; set; }

        [JsonIgnore]
        public Recipe Recipe { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
