using RecommendatorWeb.Data.Models;

public class Rating
{
    public int Id { get; set; }
    public int Value { get; set; }

    // Foreign key
    public int UserId { get; set; }
    // Navigation property
    public AppUser1 User { get; set; }

    // Foreign key
    public int TopicId { get; set; }
    // Navigation property
    public Topic Topic { get; set; }
}
