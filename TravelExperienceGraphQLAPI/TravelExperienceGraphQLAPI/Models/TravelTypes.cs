using System.ComponentModel.DataAnnotations;

namespace TravelExperienceGraphQLAPI.Models
{
    public class TravelTypes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? TypeName { get; set;}
    }
}
