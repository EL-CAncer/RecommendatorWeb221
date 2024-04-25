using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecommendatorWeb.Models;

namespace RecommendatorWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser,IdentityRole,string>
    {

        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceUserComment> ServiceUserComments  { get; set; }
        public DbSet<UserRatingService> UserRatingServices { get; set; }
        public object Topics { get; internal set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserRatingService>().HasKey(x => new { x.ServiceId, x.AppUserId });
            
            
            
            base.OnModelCreating(builder);
        }
    }
}