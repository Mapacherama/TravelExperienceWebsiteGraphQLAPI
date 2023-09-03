namespace TravelExperienceGraphQLAPI.Models
{
    public class BlogPostDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? DescriptionSmall { get; set; }
        public string? ImageUrl { get; set; }
        public string? PostLink { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? DetailedBlogPostId { get; set; }
        public int? CategoryId { get; set; }
    }
}
