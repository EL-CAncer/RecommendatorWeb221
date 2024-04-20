namespace RecommendatorWeb.Models
{
    public class ServiceUserComment
    {
        public int Id { get; set; }

        public string AppUserId { get; set; }
        public virtual AppUser  Author { get; set; }

        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        DateTime CreatedOn { get; set; }
        public string Content { get; set; }
    }
}
