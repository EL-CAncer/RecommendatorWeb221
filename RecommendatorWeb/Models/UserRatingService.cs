namespace RecommendatorWeb.Models
{
    public class UserRatingService  
    {

        public string AppUserId { get; set; }
        public virtual AppUser Rater { get; set; }
        public string ServiceId { get; set;}
        public virtual Service Service { get; set; }

        public ServiceRating Rating { get; set;}
    }
}
