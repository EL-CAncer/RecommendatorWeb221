namespace RecommendatorWeb.Models
{
    public class Service
    {
        public Service()
        {
            ServiceUserRatings = new HashSet<UserRatingService>();
        }


        public int Id { get; set; }
        bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PicMain { get; set; }
        public string ManyPics { get; set;}
        public string[] Pics => ManyPics.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public virtual ICollection<UserRatingService> ServiceUserRatings { get; set; }



    }
}
        