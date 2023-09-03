using System.ComponentModel.DataAnnotations;

namespace TravelExperienceGraphQLAPI.Models
{
    public class TipCategories
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<BlogPost>? BlogPosts { get; set; }
    }
}
