using System.ComponentModel.DataAnnotations;

namespace TravelExperienceGraphQLAPI.Models
{
    public class BlogPost
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string? description_small { get; set; }
        public string? image_url { get; set; }
        public string? post_link { get; set; }
        [Required]
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DetailedBlogPost? DetailedBlogPost { get; set; }
        public BlogCategories? Category { get; set; }
    }
}
