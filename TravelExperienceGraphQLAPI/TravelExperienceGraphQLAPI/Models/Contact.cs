using System.ComponentModel.DataAnnotations;

namespace TravelExperienceGraphQLAPI.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Website { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime SubmissionDate { get; set; }
        public ContactStatus Status { get; set; }
    }

    public enum ContactStatus {
        New,
        Read,
        Responded
    }
}
