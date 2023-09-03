using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelExperienceGraphQLAPI.Models
{
    public class DetailedBlogPost
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(BlogPost))]
        public int BlogPostId { get; set; }

        [Required]
        public string? DetailedDescription { get; set; }

        public string? AdditionalImages { get; set; }

    }
}
