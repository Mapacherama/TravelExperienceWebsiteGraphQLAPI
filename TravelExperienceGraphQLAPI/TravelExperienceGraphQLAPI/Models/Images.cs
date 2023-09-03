using System.ComponentModel.DataAnnotations;

namespace TravelExperienceGraphQLAPI.Models
{
    public class Images
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        public TravelTypes TravelType { get; set; }
        public Subject Subject { get; set; }

    }

    
}
