using System.ComponentModel.DataAnnotations;

namespace TravelExperienceGraphQLAPI.Models
{
    public class Tip
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? DescriptionSmall { get; set; }
        public string? Image { get; set;}

        public TipCategory? Category { get; set; }
    }
}
