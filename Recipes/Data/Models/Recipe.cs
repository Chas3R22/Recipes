using System.ComponentModel.DataAnnotations;

namespace Recipes.Data.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
