using Microsoft.AspNetCore.Identity;

namespace RecommendatorWeb.Models
{
    public class AppUser :IdentityUser<string>
    {
        internal string ShippingAddress;

        public AppUser()
        {
            UserRatedServices = new HashSet<UserRatingService>();
        }


        public string ProfilePic { get; set; }
        public virtual ICollection<UserRatingService> UserRatedServices { get; set; }
    }
}
