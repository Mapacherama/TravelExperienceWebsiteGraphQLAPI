namespace TravelExperienceGraphQLAPI.Models
{
    public class DetailedBlogPostDTO
    {
        public int Id { get; set; }
        public int BlogPostId { get; set; }
        public string? DetailedDescription { get; set; }
        public string? AdditionalImages { get; set; }
        public string? BlogPostTitle { get; set; } // Example of flattening the BlogPost navigation property
    }
}
