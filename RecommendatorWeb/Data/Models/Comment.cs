namespace RecommendatorWeb.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        // Foreign key
        public int UserId { get; set; }
        // Navigation property
        public AppUser1 User { get; set; }
        DateTime CreatedOn { get; set; }
        // Foreign key
        public int TopicId { get; set; }
        // Navigation property
        public Topic Topic { get; set; }
    }
}
