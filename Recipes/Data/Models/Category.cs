using System.ComponentModel.DataAnnotations;

namespace Recipes.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.Id = Guid.NewGuid();
            this.Recipes = new HashSet<Recipe>();
        }
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
