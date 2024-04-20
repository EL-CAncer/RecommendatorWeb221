namespace RecommendatorWeb.Data.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public TopicStatus Status { get; set; }

        // Foreign key
        public int UserId { get; set; }
        // Navigation property
        public AppUser1 User { get; set; }

        // Navigation property
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public enum TopicStatus
        {
            Approved,
            PendingApproval,
            Rejected
        }
    }
}
