using System.ComponentModel.DataAnnotations;

namespace TravelExperienceGraphQLAPI.Models
{
    public class BlogCategories
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
